
namespace ITServiceManagement.AdminForms.Users
{
    partial class frm_addOrEditUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addOrEditUser));
            this.grb_userImage = new System.Windows.Forms.GroupBox();
            this.btn_insertPicture = new System.Windows.Forms.Button();
            this.pcb_userImage = new System.Windows.Forms.PictureBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grb_userInfo = new System.Windows.Forms.GroupBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_gender = new System.Windows.Forms.Panel();
            this.rdb_single = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.rdb_married = new System.Windows.Forms.RadioButton();
            this.txt_employeeId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_lockedNo = new System.Windows.Forms.RadioButton();
            this.rdb_lockedYes = new System.Windows.Forms.RadioButton();
            this.txt_nationalCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_birthDay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phobeNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.grb_userRole = new System.Windows.Forms.GroupBox();
            this.cmb_userRole = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofd_insertImage = new System.Windows.Forms.OpenFileDialog();
            this.userName_validator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.email_validator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.mobileNumber_validator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.nationalCode_validator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.birthDay_validator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.userAddress_validator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.userRole_validator = new ValidationComponents.RequiredFieldValidator(this.components);
            this.nationalCodeRange_validator = new ValidationComponents.RangeValidator(this.components);
            this.mobileNumberRange_Validator = new ValidationComponents.RangeValidator(this.components);
            this.grb_userImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_userImage)).BeginInit();
            this.grb_userInfo.SuspendLayout();
            this.pnl_gender.SuspendLayout();
            this.grb_userRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_userImage
            // 
            this.grb_userImage.Controls.Add(this.btn_insertPicture);
            this.grb_userImage.Controls.Add(this.pcb_userImage);
            this.grb_userImage.Location = new System.Drawing.Point(490, 25);
            this.grb_userImage.Name = "grb_userImage";
            this.grb_userImage.Size = new System.Drawing.Size(218, 280);
            this.grb_userImage.TabIndex = 0;
            this.grb_userImage.TabStop = false;
            this.grb_userImage.Text = "عکس کاربر";
            // 
            // btn_insertPicture
            // 
            this.btn_insertPicture.Location = new System.Drawing.Point(6, 242);
            this.btn_insertPicture.Name = "btn_insertPicture";
            this.btn_insertPicture.Size = new System.Drawing.Size(206, 23);
            this.btn_insertPicture.TabIndex = 1;
            this.btn_insertPicture.Text = "افزودن عکس";
            this.btn_insertPicture.UseVisualStyleBackColor = true;
            this.btn_insertPicture.Click += new System.EventHandler(this.btn_insertPicture_Click);
            // 
            // pcb_userImage
            // 
            this.pcb_userImage.Location = new System.Drawing.Point(6, 20);
            this.pcb_userImage.Name = "pcb_userImage";
            this.pcb_userImage.Size = new System.Drawing.Size(206, 208);
            this.pcb_userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_userImage.TabIndex = 0;
            this.pcb_userImage.TabStop = false;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.Location = new System.Drawing.Point(607, 433);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(95, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "ثبت";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Location = new System.Drawing.Point(496, 433);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // grb_userInfo
            // 
            this.grb_userInfo.Controls.Add(this.txt_password);
            this.grb_userInfo.Controls.Add(this.label9);
            this.grb_userInfo.Controls.Add(this.pnl_gender);
            this.grb_userInfo.Controls.Add(this.txt_employeeId);
            this.grb_userInfo.Controls.Add(this.label7);
            this.grb_userInfo.Controls.Add(this.label6);
            this.grb_userInfo.Controls.Add(this.rdb_lockedNo);
            this.grb_userInfo.Controls.Add(this.rdb_lockedYes);
            this.grb_userInfo.Controls.Add(this.txt_nationalCode);
            this.grb_userInfo.Controls.Add(this.label5);
            this.grb_userInfo.Controls.Add(this.dtp_birthDay);
            this.grb_userInfo.Controls.Add(this.label4);
            this.grb_userInfo.Controls.Add(this.txt_phobeNumber);
            this.grb_userInfo.Controls.Add(this.label3);
            this.grb_userInfo.Controls.Add(this.txt_email);
            this.grb_userInfo.Controls.Add(this.label2);
            this.grb_userInfo.Controls.Add(this.txt_adress);
            this.grb_userInfo.Controls.Add(this.label1);
            this.grb_userInfo.Controls.Add(this.txt_userName);
            this.grb_userInfo.Controls.Add(this.lbl_userName);
            this.grb_userInfo.Location = new System.Drawing.Point(23, 83);
            this.grb_userInfo.Name = "grb_userInfo";
            this.grb_userInfo.Size = new System.Drawing.Size(435, 379);
            this.grb_userInfo.TabIndex = 3;
            this.grb_userInfo.TabStop = false;
            this.grb_userInfo.Text = "اطلاعات کاربر";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(127, 95);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(200, 21);
            this.txt_password.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "رمز ورود :";
            // 
            // pnl_gender
            // 
            this.pnl_gender.Controls.Add(this.rdb_single);
            this.pnl_gender.Controls.Add(this.label8);
            this.pnl_gender.Controls.Add(this.rdb_married);
            this.pnl_gender.Location = new System.Drawing.Point(17, 125);
            this.pnl_gender.Name = "pnl_gender";
            this.pnl_gender.Size = new System.Drawing.Size(104, 100);
            this.pnl_gender.TabIndex = 18;
            // 
            // rdb_single
            // 
            this.rdb_single.AutoSize = true;
            this.rdb_single.Checked = true;
            this.rdb_single.Location = new System.Drawing.Point(9, 27);
            this.rdb_single.Name = "rdb_single";
            this.rdb_single.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdb_single.Size = new System.Drawing.Size(48, 17);
            this.rdb_single.TabIndex = 20;
            this.rdb_single.TabStop = true;
            this.rdb_single.Text = "مجرد";
            this.rdb_single.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "جنسیت :";
            // 
            // rdb_married
            // 
            this.rdb_married.AutoSize = true;
            this.rdb_married.Location = new System.Drawing.Point(9, 50);
            this.rdb_married.Name = "rdb_married";
            this.rdb_married.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdb_married.Size = new System.Drawing.Size(54, 17);
            this.rdb_married.TabIndex = 19;
            this.rdb_married.Text = "متاهل";
            this.rdb_married.UseVisualStyleBackColor = true;
            // 
            // txt_employeeId
            // 
            this.txt_employeeId.Location = new System.Drawing.Point(195, 183);
            this.txt_employeeId.MaxLength = 9;
            this.txt_employeeId.Name = "txt_employeeId";
            this.txt_employeeId.Size = new System.Drawing.Size(132, 21);
            this.txt_employeeId.TabIndex = 17;
            this.txt_employeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phobeNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "کد کارمندی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "غیر فعال شود ؟";
            // 
            // rdb_lockedNo
            // 
            this.rdb_lockedNo.AutoSize = true;
            this.rdb_lockedNo.Checked = true;
            this.rdb_lockedNo.Location = new System.Drawing.Point(206, 217);
            this.rdb_lockedNo.Name = "rdb_lockedNo";
            this.rdb_lockedNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdb_lockedNo.Size = new System.Drawing.Size(41, 17);
            this.rdb_lockedNo.TabIndex = 14;
            this.rdb_lockedNo.TabStop = true;
            this.rdb_lockedNo.Text = "خیر";
            this.rdb_lockedNo.UseVisualStyleBackColor = true;
            // 
            // rdb_lockedYes
            // 
            this.rdb_lockedYes.AutoSize = true;
            this.rdb_lockedYes.Location = new System.Drawing.Point(268, 215);
            this.rdb_lockedYes.Name = "rdb_lockedYes";
            this.rdb_lockedYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdb_lockedYes.Size = new System.Drawing.Size(38, 17);
            this.rdb_lockedYes.TabIndex = 13;
            this.rdb_lockedYes.Text = "بله";
            this.rdb_lockedYes.UseVisualStyleBackColor = true;
            // 
            // txt_nationalCode
            // 
            this.txt_nationalCode.Location = new System.Drawing.Point(195, 155);
            this.txt_nationalCode.MaxLength = 10;
            this.txt_nationalCode.Name = "txt_nationalCode";
            this.txt_nationalCode.Size = new System.Drawing.Size(132, 21);
            this.txt_nationalCode.TabIndex = 12;
            this.txt_nationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phobeNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "کد ملی :";
            // 
            // dtp_birthDay
            // 
            this.dtp_birthDay.Location = new System.Drawing.Point(127, 243);
            this.dtp_birthDay.Name = "dtp_birthDay";
            this.dtp_birthDay.Size = new System.Drawing.Size(201, 21);
            this.dtp_birthDay.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "تاریخ تولد :";
            // 
            // txt_phobeNumber
            // 
            this.txt_phobeNumber.Location = new System.Drawing.Point(195, 125);
            this.txt_phobeNumber.MaxLength = 11;
            this.txt_phobeNumber.Name = "txt_phobeNumber";
            this.txt_phobeNumber.Size = new System.Drawing.Size(132, 21);
            this.txt_phobeNumber.TabIndex = 7;
            this.txt_phobeNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phobeNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "شماره موبایل";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(5, 62);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(322, 21);
            this.txt_email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ایمیل :";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(6, 280);
            this.txt_adress.Multiline = true;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(321, 93);
            this.txt_adress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "آدرس :";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(6, 31);
            this.txt_userName.MaxLength = 50;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(321, 21);
            this.txt_userName.TabIndex = 1;
            this.txt_userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_userName_KeyPress);
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(333, 34);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(96, 13);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "نام و نام خانوادگی :";
            // 
            // grb_userRole
            // 
            this.grb_userRole.Controls.Add(this.cmb_userRole);
            this.grb_userRole.Location = new System.Drawing.Point(490, 311);
            this.grb_userRole.Name = "grb_userRole";
            this.grb_userRole.Size = new System.Drawing.Size(218, 100);
            this.grb_userRole.TabIndex = 4;
            this.grb_userRole.TabStop = false;
            this.grb_userRole.Text = "نقش کاربر";
            // 
            // cmb_userRole
            // 
            this.cmb_userRole.DataSource = this.rolesBindingSource;
            this.cmb_userRole.DisplayMember = "RoleName";
            this.cmb_userRole.FormattingEnabled = true;
            this.cmb_userRole.Location = new System.Drawing.Point(23, 47);
            this.cmb_userRole.Name = "cmb_userRole";
            this.cmb_userRole.Size = new System.Drawing.Size(167, 21);
            this.cmb_userRole.TabIndex = 0;
            this.cmb_userRole.ValueMember = "RoleId";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(ITServiceManagement.DataLayer.Roles);
            // 
            // ofd_insertImage
            // 
            this.ofd_insertImage.Filter = "Image Files|*.jpg|Image Files|*.png";
            // 
            // userName_validator
            // 
            this.userName_validator.CancelFocusChangeWhenInvalid = false;
            this.userName_validator.ControlToValidate = this.txt_userName;
            this.userName_validator.ErrorMessage = "نام و نام خانوادگی نباید خالی باشد";
            this.userName_validator.Icon = ((System.Drawing.Icon)(resources.GetObject("userName_validator.Icon")));
            // 
            // email_validator
            // 
            this.email_validator.CancelFocusChangeWhenInvalid = false;
            this.email_validator.ControlToValidate = this.txt_email;
            this.email_validator.ErrorMessage = "ایمیل نباید خالی باشد";
            this.email_validator.Icon = ((System.Drawing.Icon)(resources.GetObject("email_validator.Icon")));
            // 
            // mobileNumber_validator
            // 
            this.mobileNumber_validator.CancelFocusChangeWhenInvalid = false;
            this.mobileNumber_validator.ControlToValidate = this.txt_phobeNumber;
            this.mobileNumber_validator.ErrorMessage = "شماره موبایل نباید خالی باشد";
            this.mobileNumber_validator.Icon = ((System.Drawing.Icon)(resources.GetObject("mobileNumber_validator.Icon")));
            // 
            // nationalCode_validator
            // 
            this.nationalCode_validator.CancelFocusChangeWhenInvalid = false;
            this.nationalCode_validator.ControlToValidate = this.txt_nationalCode;
            this.nationalCode_validator.ErrorMessage = "کد ملی نباید خالی باشد";
            this.nationalCode_validator.Icon = ((System.Drawing.Icon)(resources.GetObject("nationalCode_validator.Icon")));
            // 
            // birthDay_validator
            // 
            this.birthDay_validator.CancelFocusChangeWhenInvalid = false;
            this.birthDay_validator.ControlToValidate = this.dtp_birthDay;
            this.birthDay_validator.ErrorMessage = "تاریخ تولد نباید خالی بماند";
            this.birthDay_validator.Icon = ((System.Drawing.Icon)(resources.GetObject("birthDay_validator.Icon")));
            // 
            // userAddress_validator
            // 
            this.userAddress_validator.CancelFocusChangeWhenInvalid = false;
            this.userAddress_validator.ControlToValidate = this.txt_adress;
            this.userAddress_validator.ErrorMessage = "آدرس نباید خالی باشد";
            this.userAddress_validator.Icon = ((System.Drawing.Icon)(resources.GetObject("userAddress_validator.Icon")));
            // 
            // userRole_validator
            // 
            this.userRole_validator.CancelFocusChangeWhenInvalid = false;
            this.userRole_validator.ControlToValidate = this.cmb_userRole;
            this.userRole_validator.ErrorMessage = "نقش کاربر نباید خالی باشد";
            this.userRole_validator.Icon = ((System.Drawing.Icon)(resources.GetObject("userRole_validator.Icon")));
            // 
            // nationalCodeRange_validator
            // 
            this.nationalCodeRange_validator.CancelFocusChangeWhenInvalid = false;
            this.nationalCodeRange_validator.ControlToValidate = this.txt_nationalCode;
            this.nationalCodeRange_validator.ErrorMessage = "لطفا کد ملی معتبر وارد کنید";
            this.nationalCodeRange_validator.Icon = ((System.Drawing.Icon)(resources.GetObject("nationalCodeRange_validator.Icon")));
            this.nationalCodeRange_validator.MaximumValue = "1500000000";
            this.nationalCodeRange_validator.MinimumValue = "1000000000";
            this.nationalCodeRange_validator.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // mobileNumberRange_Validator
            // 
            this.mobileNumberRange_Validator.CancelFocusChangeWhenInvalid = false;
            this.mobileNumberRange_Validator.ControlToValidate = this.txt_phobeNumber;
            this.mobileNumberRange_Validator.ErrorMessage = "لطفا شماره موبایل معتبر وارد کنید";
            this.mobileNumberRange_Validator.Icon = ((System.Drawing.Icon)(resources.GetObject("mobileNumberRange_Validator.Icon")));
            this.mobileNumberRange_Validator.MaximumValue = "10000000000";
            this.mobileNumberRange_Validator.MinimumValue = "9000000000";
            this.mobileNumberRange_Validator.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // frm_addOrEditUser
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(731, 485);
            this.Controls.Add(this.grb_userRole);
            this.Controls.Add(this.grb_userInfo);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.grb_userImage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(731, 485);
            this.MinimumSize = new System.Drawing.Size(731, 485);
            this.Name = "frm_addOrEditUser";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن کاربر";
            this.Load += new System.EventHandler(this.frm_addOrEditUser_Load);
            this.grb_userImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_userImage)).EndInit();
            this.grb_userInfo.ResumeLayout(false);
            this.grb_userInfo.PerformLayout();
            this.pnl_gender.ResumeLayout(false);
            this.pnl_gender.PerformLayout();
            this.grb_userRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_userImage;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_insertPicture;
        private System.Windows.Forms.PictureBox pcb_userImage;
        private System.Windows.Forms.GroupBox grb_userInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phobeNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.GroupBox grb_userRole;
        private System.Windows.Forms.ComboBox cmb_userRole;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnl_gender;
        private System.Windows.Forms.RadioButton rdb_single;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdb_married;
        private System.Windows.Forms.TextBox txt_employeeId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_lockedNo;
        private System.Windows.Forms.RadioButton rdb_lockedYes;
        private System.Windows.Forms.TextBox txt_nationalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_birthDay;
        private System.Windows.Forms.OpenFileDialog ofd_insertImage;
        private ValidationComponents.RequiredFieldValidator userName_validator;
        private ValidationComponents.RequiredFieldValidator email_validator;
        private ValidationComponents.RequiredFieldValidator mobileNumber_validator;
        private ValidationComponents.RequiredFieldValidator nationalCode_validator;
        private ValidationComponents.RequiredFieldValidator birthDay_validator;
        private ValidationComponents.RequiredFieldValidator userAddress_validator;
        private ValidationComponents.RequiredFieldValidator userRole_validator;
        private ValidationComponents.RangeValidator nationalCodeRange_validator;
        private ValidationComponents.RangeValidator mobileNumberRange_Validator;
        private System.Windows.Forms.BindingSource rolesBindingSource;
    }
}