using ITServiceManagement.DataLayer;
using ITServiceManagement.DataLayer.Context;
using ITServiceManagement.Utilities.Generators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ValidationComponents;

namespace ITServiceManagement.AdminForms.Users
{
    public partial class frm_addOrEditUser : MetroFramework.Forms.MetroForm
    {
        private Guid? _userId;

        public frm_addOrEditUser(Guid? userId = null)
        {
            InitializeComponent();
            this.ControlBox = false;
            _userId = userId;
        }

        private void frm_addOrEditUser_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Roles> roles = (List<Roles>)db.RoleRepository.Get();
                cmb_userRole.DataSource = roles;

                // edit mode
                if (_userId != null)
                {
                    this.Text = "ویرایش کاربر";
                    btn_ok.Text = "ویرایش";
                    var user = db.UserRepository.Get(_userId);
                    txt_userName.Text = user.UserName;
                    txt_email.Text = user.Email;
                    txt_phobeNumber.Text = user.PhoneNumber;
                    txt_nationalCode.Text = user.NationalCode;
                    txt_employeeId.Text = user.EmployeeId.ToString();
                    if (user.IsLocked)
                        rdb_lockedYes.Checked = true;
                    if (user.Gender)
                        rdb_married.Checked = true;
                    dtp_birthDay.Value = user.BirthDay;
                    txt_adress.Text = user.Address;
                    pcb_userImage.ImageLocation = user.ImageUrl;
                    cmb_userRole.SelectedValue = user.RoleId;
                }
                // add mode
                else
                {
                    RequiredFieldValidator validator = new RequiredFieldValidator();
                    validator.ControlToValidate = txt_password;
                    validator.ErrorMessage = "رمز عبور نمیتواند خالی باشد";
                }
            }
        }

        private void btn_insertPicture_Click(object sender, EventArgs e)
        {
            if (ofd_insertImage.ShowDialog() == DialogResult.OK)
            {
                pcb_userImage.ImageLocation = ofd_insertImage.FileName;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                // generate new name for user image ----------------------------------------------------
                string imageName = "custome_user.png";
                string path = Application.StartupPath + "/Images/Users/";
                if (pcb_userImage.ImageLocation != null)
                {
                    imageName = Guid.NewGuid() + Path.GetExtension(pcb_userImage.ImageLocation);
                }

                // check radio buttons -----------------------------------------------------------------
                bool gender = false;
                bool isLocked = false;
                DateTime? lockedTime = null;
                if (rdb_married.Checked == true)
                {
                    gender = true;
                }
                if (rdb_lockedYes.Checked == true)
                {
                    isLocked = true;
                    lockedTime = DateTime.Now;
                }

                // create new user model with new values -----------------------------------------------
                DataLayer.Users user = new DataLayer.Users()
                {
                    UserName = txt_userName.Text,
                    Gender = gender,
                    IsLocked = isLocked,
                    LockedTime = lockedTime,
                    BirthDay = dtp_birthDay.Value,
                    ImageUrl = path + imageName,
                    Address = txt_adress.Text,
                    PhoneNumber = txt_phobeNumber.Text,
                    Email = txt_email.Text,
                    NationalCode = txt_nationalCode.Text,
                    EmployeeId = Convert.ToInt32(txt_employeeId.Text),
                    RoleId = (Int16)cmb_userRole.SelectedValue
                };

                bool addOrEditResult = false;
                // Add mode ----------------------------------------------------------------------------
                if (_userId == null)
                {
                    user.UserId = Guid.NewGuid();
                    user.PasswordHash = HashGenerators.Md5EnCoding(txt_password.Text);
                    user.InsertTime = DateTime.Now;

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (db.UserRepository.Insert(user))
                        {
                            db.UserRepository.Save();
                            addOrEditResult = true;
                        }
                        else
                            RtlMessageBox.Show("خطایی در افزودن کاربر رخ داده است", "اخطار!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // Edit mode --------------------------------------------------------------------------
                else
                {
                    user.UserId = _userId ?? Guid.NewGuid();
                    if (txt_password.Text != "")
                        user.PasswordHash = HashGenerators.Md5EnCoding(txt_password.Text);

                    using (UnitOfWork db = new UnitOfWork())
                    {
                        string oldImageUrl = db.UserService.GetImageNameById(_userId ?? Guid.NewGuid());
                        if (db.UserService.UpdateUser(user))
                        {
                            db.UserRepository.Save();
                            // delete existing image 
                            if (oldImageUrl != null)
                            {
                                if (File.Exists(oldImageUrl) && !oldImageUrl.Contains("custome_user.png"))
                                    File.Delete(oldImageUrl);
                            }
                            addOrEditResult = true;
                        }
                        else
                            RtlMessageBox.Show("خطایی در ویرایش کاربر رخ داده است", "اخطار!",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (addOrEditResult)
                {
                    // Add new image in directory
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    pcb_userImage.Image.Save(path + imageName);
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void txt_phobeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSymbol(e.KeyChar) ||
                Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txt_userName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) ||
                Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}
