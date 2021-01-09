
namespace ITServiceManagement.AdminForms.Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_users = new MetroFramework.Controls.MetroGrid();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_users = new System.Windows.Forms.GroupBox();
            this.tsp_users = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btn_editUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btn_addUserTask = new System.Windows.Forms.ToolStripButton();
            this.btn_printUsers = new System.Windows.Forms.ToolStripButton();
            this.lbl_searchUserRole = new System.Windows.Forms.ToolStripLabel();
            this.cmb_selectUserRole = new System.Windows.Forms.ToolStripComboBox();
            this.lbl_searchUser = new System.Windows.Forms.ToolStripLabel();
            this.txt_searchUser = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.grb_users.SuspendLayout();
            this.tsp_users.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.AllowUserToResizeRows = false;
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Age,
            this.PhoneNumber,
            this.NationalCode,
            this.IsLocked,
            this.Role,
            this.Email,
            this.InsertTime,
            this.EmployeeId,
            this.ID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_users.EnableHeadersVisualStyles = false;
            this.dgv_users.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_users.Location = new System.Drawing.Point(3, 28);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_users.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_users.Size = new System.Drawing.Size(924, 332);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "نام";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "BirthDay";
            this.Age.HeaderText = "تاریخ تولد";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "شماره موبایل";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.HeaderText = "شماره ملی";
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.ReadOnly = true;
            // 
            // IsLocked
            // 
            this.IsLocked.DataPropertyName = "IsLocked";
            this.IsLocked.HeaderText = "وضعیت";
            this.IsLocked.Name = "IsLocked";
            this.IsLocked.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "RoleId";
            this.Role.HeaderText = "نقش";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // InsertTime
            // 
            this.InsertTime.DataPropertyName = "InsertTime";
            this.InsertTime.HeaderText = "تاریخ ثبت";
            this.InsertTime.Name = "InsertTime";
            this.InsertTime.ReadOnly = true;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "کد کارمندی";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "UserId";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // grb_users
            // 
            this.grb_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_users.Controls.Add(this.dgv_users);
            this.grb_users.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_users.Location = new System.Drawing.Point(6, 81);
            this.grb_users.Name = "grb_users";
            this.grb_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grb_users.Size = new System.Drawing.Size(930, 363);
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
            this.tsp_users.Size = new System.Drawing.Size(942, 54);
            this.tsp_users.TabIndex = 4;
            this.tsp_users.Text = "toolStrip1";
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
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
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
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
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
            this.cmb_selectUserRole.Click += new System.EventHandler(this.cmb_selectUserRole_Click);
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
            this.txt_searchUser.Size = new System.Drawing.Size(150, 54);
            this.txt_searchUser.TextChanged += new System.EventHandler(this.txt_searchUser_TextChanged);
            // 
            // frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.tsp_users);
            this.Controls.Add(this.grb_users);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_users";
            this.Text = "کاربران";
            this.Load += new System.EventHandler(this.frm_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.grb_users.ResumeLayout(false);
            this.tsp_users.ResumeLayout(false);
            this.tsp_users.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgv_users;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsLocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}