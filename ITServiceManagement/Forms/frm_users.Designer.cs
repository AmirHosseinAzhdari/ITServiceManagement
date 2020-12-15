
namespace ITServiceManagement.Forms
{
    partial class frm_users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grv_users = new MetroFramework.Controls.MetroGrid();
            this.grb_users = new System.Windows.Forms.GroupBox();
            this.tsp_users = new System.Windows.Forms.ToolStrip();
            this.lbl_searchUserRole = new System.Windows.Forms.ToolStripLabel();
            this.cmb_selectUserRole = new System.Windows.Forms.ToolStripComboBox();
            this.lbl_searchUser = new System.Windows.Forms.ToolStripLabel();
            this.txt_searchUser = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btn_editUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btn_printUsers = new System.Windows.Forms.ToolStripButton();
            this.btn_addUserTask = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grv_users)).BeginInit();
            this.grb_users.SuspendLayout();
            this.tsp_users.SuspendLayout();
            this.SuspendLayout();
            // 
            // grv_users
            // 
            this.grv_users.AllowUserToAddRows = false;
            this.grv_users.AllowUserToDeleteRows = false;
            this.grv_users.AllowUserToResizeRows = false;
            this.grv_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.grv_users.EnableHeadersVisualStyles = false;
            this.grv_users.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grv_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grv_users.Location = new System.Drawing.Point(6, 31);
            this.grv_users.Name = "grv_users";
            this.grv_users.ReadOnly = true;
            this.grv_users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grv_users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_users.Size = new System.Drawing.Size(777, 292);
            this.grv_users.TabIndex = 0;
            // 
            // grb_users
            // 
            this.grb_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_users.Controls.Add(this.grv_users);
            this.grb_users.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_users.Location = new System.Drawing.Point(6, 115);
            this.grb_users.Name = "grb_users";
            this.grb_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_users.Size = new System.Drawing.Size(789, 329);
            this.grb_users.TabIndex = 1;
            this.grb_users.TabStop = false;
            this.grb_users.Text = "لیست کاربران ثبت شده";
            // 
            // tsp_users
            // 
            this.tsp_users.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btn_editUser,
            this.toolStripButton3,
            this.btn_addUserTask,
            this.btn_printUsers,
            this.lbl_searchUserRole,
            this.cmb_selectUserRole,
            this.lbl_searchUser,
            this.txt_searchUser});
            this.tsp_users.Location = new System.Drawing.Point(0, 0);
            this.tsp_users.Name = "tsp_users";
            this.tsp_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsp_users.Size = new System.Drawing.Size(801, 54);
            this.tsp_users.TabIndex = 4;
            this.tsp_users.Text = "toolStrip1";
            // 
            // lbl_searchUserRole
            // 
            this.lbl_searchUserRole.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchUserRole.Margin = new System.Windows.Forms.Padding(0, 1, 25, 2);
            this.lbl_searchUserRole.Name = "lbl_searchUserRole";
            this.lbl_searchUserRole.Size = new System.Drawing.Size(116, 51);
            this.lbl_searchUserRole.Text = "فیلتر بر اساس نقش کاربر :";
            // 
            // cmb_selectUserRole
            // 
            this.cmb_selectUserRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_selectUserRole.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_selectUserRole.Name = "cmb_selectUserRole";
            this.cmb_selectUserRole.Size = new System.Drawing.Size(121, 54);
            // 
            // lbl_searchUser
            // 
            this.lbl_searchUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchUser.Margin = new System.Windows.Forms.Padding(0, 1, 25, 2);
            this.lbl_searchUser.Name = "lbl_searchUser";
            this.lbl_searchUser.Size = new System.Drawing.Size(43, 51);
            this.lbl_searchUser.Text = "جستجو :";
            // 
            // txt_searchUser
            // 
            this.txt_searchUser.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchUser.MaxLength = 1000000;
            this.txt_searchUser.Name = "txt_searchUser";
            this.txt_searchUser.Size = new System.Drawing.Size(150, 21);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::ITServiceManagement.Properties.Resources.add_user;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 51);
            this.toolStripButton2.Text = "افزودن کاربر";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_editUser
            // 
            this.btn_editUser.Image = global::ITServiceManagement.Properties.Resources.user;
            this.btn_editUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_editUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_editUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(73, 51);
            this.btn_editUser.Text = "ویرایش کاربر";
            this.btn_editUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_editUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::ITServiceManagement.Properties.Resources.delete_user;
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(62, 51);
            this.toolStripButton3.Text = "حذف کاربر";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_printUsers
            // 
            this.btn_printUsers.Image = global::ITServiceManagement.Properties.Resources.printer;
            this.btn_printUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_printUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_printUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_printUsers.Name = "btn_printUsers";
            this.btn_printUsers.Size = new System.Drawing.Size(100, 51);
            this.btn_printUsers.Text = "چاپ لیست کاربران";
            this.btn_printUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_printUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_addUserTask
            // 
            this.btn_addUserTask.Image = global::ITServiceManagement.Properties.Resources.clipboard;
            this.btn_addUserTask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_addUserTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_addUserTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addUserTask.Name = "btn_addUserTask";
            this.btn_addUserTask.Size = new System.Drawing.Size(118, 51);
            this.btn_addUserTask.Text = "ایجاد وظیفه برای کاربر";
            this.btn_addUserTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_addUserTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.tsp_users);
            this.Controls.Add(this.grb_users);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_users";
            this.Text = "کاربران";
            this.Load += new System.EventHandler(this.frm_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_users)).EndInit();
            this.grb_users.ResumeLayout(false);
            this.tsp_users.ResumeLayout(false);
            this.tsp_users.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grv_users;
        private System.Windows.Forms.GroupBox grb_users;
        private System.Windows.Forms.ToolStrip tsp_users;
        private System.Windows.Forms.ToolStripButton btn_printUsers;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btn_editUser;
        private System.Windows.Forms.ToolStripLabel lbl_searchUserRole;
        private System.Windows.Forms.ToolStripComboBox cmb_selectUserRole;
        private System.Windows.Forms.ToolStripLabel lbl_searchUser;
        private System.Windows.Forms.ToolStripTextBox txt_searchUser;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btn_addUserTask;
    }
}