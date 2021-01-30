using ITServiceManagement.AdminForms.Users.Tickets;
using ITServiceManagement.DataLayer;
using ITServiceManagement.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITServiceManagement.AdminForms.Users
{
    public partial class frm_users : Form
    {
        public frm_users()
        {
            InitializeComponent();
        }

        private void frm_users_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var roles = new List<Roles>
                {
                    new Roles { RoleId = 0, RoleName = "" }
                };
                roles.AddRange((List<Roles>)db.RoleRepository.Get());
                cmb_selectUserRole.ComboBox.DataSource = roles;
                cmb_selectUserRole.ComboBox.ValueMember = "RoleId";
                cmb_selectUserRole.ComboBox.DisplayMember = "RoleName";
                cmb_selectUserRole.ComboBox.SelectedValue = 0;
            }
            BindGrid();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frm_addOrEditUser frm = new frm_addOrEditUser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            if (dgv_users.CurrentRow != null)
            {
                Guid user_id = (Guid)dgv_users.CurrentRow.Cells[9].Value;
                frm_addOrEditUser frm = new frm_addOrEditUser(user_id);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgv_users.CurrentRow != null)
            {
                if (RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "خذف کاربر",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        Guid user_id = (Guid)dgv_users.CurrentRow.Cells[9].Value;
                        string oldImageUrl = db.UserService.GetImageNameById(user_id);
                        if (db.UserRepository.Delete(user_id))
                        {
                            db.UserRepository.Save();
                            // delete image from directory
                            if (oldImageUrl != null)
                            {
                                if (File.Exists(oldImageUrl) && !oldImageUrl.Contains("custome_user.png"))
                                    File.Delete(oldImageUrl);
                            }
                            BindGrid();
                        }
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_searchUser_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
                dgv_users.DataSource = db.UserService.FilterByUserName(txt_searchUser.Text);
        }

        private void btn_addUserTask_Click(object sender, EventArgs e)
        {
            if (dgv_users.CurrentRow != null)
            {
                frm_tickets f = new frm_tickets();
                f.ShowDialog();
            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid()
        {
            dgv_users.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgv_users.DataSource = db.UserRepository.Get();
            }
        }

        private void cmb_selectUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_selectUserRole.Text)
            {
                case "مدیریت":
                    using (UnitOfWork db = new UnitOfWork())
                        dgv_users.DataSource = db.UserService.GetUserByRoleId(1);
                    break;
                case "مدیر آی تی":
                    using (UnitOfWork db = new UnitOfWork())
                        dgv_users.DataSource = db.UserService.GetUserByRoleId(2);
                    break;
                case "کارمندان":
                    using (UnitOfWork db = new UnitOfWork())
                        dgv_users.DataSource = db.UserService.GetUserByRoleId(3);
                    break;
                case "کاربر عادی":
                    using (UnitOfWork db = new UnitOfWork())
                        dgv_users.DataSource = db.UserService.GetUserByRoleId(4);
                    break;
                default:
                    BindGrid();
                    break;
            }
        }
    }
}
