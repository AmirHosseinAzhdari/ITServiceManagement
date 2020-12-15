
namespace ITServiceManagement
{
    partial class frm_main
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_titleBar = new System.Windows.Forms.Panel();
            this.btn_maximaize = new System.Windows.Forms.Button();
            this.btn_minimaize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_mainTitle = new System.Windows.Forms.Label();
            this.pnl_childForms = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_dateTime = new System.Windows.Forms.Label();
            this.pcb_main = new System.Windows.Forms.PictureBox();
            this.btn_closeChildForm = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.pnl_menu.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            this.pnl_titleBar.SuspendLayout();
            this.pnl_childForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnl_menu.Controls.Add(this.btn_settings);
            this.pnl_menu.Controls.Add(this.btn_customers);
            this.pnl_menu.Controls.Add(this.pnl_logo);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_menu.Location = new System.Drawing.Point(984, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(200, 561);
            this.pnl_menu.TabIndex = 0;
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnl_logo.Controls.Add(this.lbl_dateTime);
            this.pnl_logo.Controls.Add(this.label1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(200, 80);
            this.pnl_logo.TabIndex = 0;
            this.pnl_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_logo_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMIRHOSSEIN AZHDARI";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pnl_titleBar
            // 
            this.pnl_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnl_titleBar.Controls.Add(this.btn_maximaize);
            this.pnl_titleBar.Controls.Add(this.btn_minimaize);
            this.pnl_titleBar.Controls.Add(this.btn_close);
            this.pnl_titleBar.Controls.Add(this.btn_closeChildForm);
            this.pnl_titleBar.Controls.Add(this.lbl_mainTitle);
            this.pnl_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titleBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_titleBar.Name = "pnl_titleBar";
            this.pnl_titleBar.Size = new System.Drawing.Size(984, 80);
            this.pnl_titleBar.TabIndex = 1;
            this.pnl_titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titleBar_MouseDown);
            // 
            // btn_maximaize
            // 
            this.btn_maximaize.FlatAppearance.BorderSize = 0;
            this.btn_maximaize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximaize.Font = new System.Drawing.Font("Segoe UI Emoji", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maximaize.ForeColor = System.Drawing.Color.White;
            this.btn_maximaize.Location = new System.Drawing.Point(30, 0);
            this.btn_maximaize.Name = "btn_maximaize";
            this.btn_maximaize.Size = new System.Drawing.Size(30, 30);
            this.btn_maximaize.TabIndex = 4;
            this.btn_maximaize.Text = "O";
            this.btn_maximaize.UseVisualStyleBackColor = true;
            this.btn_maximaize.Click += new System.EventHandler(this.btn_maximaize_Click);
            this.btn_maximaize.MouseHover += new System.EventHandler(this.btn_maximaize_MouseHover);
            // 
            // btn_minimaize
            // 
            this.btn_minimaize.FlatAppearance.BorderSize = 0;
            this.btn_minimaize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimaize.Font = new System.Drawing.Font("Segoe UI Emoji", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimaize.ForeColor = System.Drawing.Color.White;
            this.btn_minimaize.Location = new System.Drawing.Point(60, 0);
            this.btn_minimaize.Name = "btn_minimaize";
            this.btn_minimaize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimaize.TabIndex = 3;
            this.btn_minimaize.Text = "O";
            this.btn_minimaize.UseVisualStyleBackColor = true;
            this.btn_minimaize.Click += new System.EventHandler(this.btn_minimaize_Click);
            this.btn_minimaize.MouseHover += new System.EventHandler(this.btn_minimaize_MouseHover);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Emoji", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "O";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseHover += new System.EventHandler(this.btn_close_MouseHover);
            // 
            // lbl_mainTitle
            // 
            this.lbl_mainTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mainTitle.AutoSize = true;
            this.lbl_mainTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mainTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_mainTitle.Location = new System.Drawing.Point(428, 28);
            this.lbl_mainTitle.Name = "lbl_mainTitle";
            this.lbl_mainTitle.Size = new System.Drawing.Size(126, 31);
            this.lbl_mainTitle.TabIndex = 0;
            this.lbl_mainTitle.Text = "صفحه اصلی";
            this.lbl_mainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_mainTitle_MouseDown);
            // 
            // pnl_childForms
            // 
            this.pnl_childForms.BackColor = System.Drawing.Color.White;
            this.pnl_childForms.Controls.Add(this.pcb_main);
            this.pnl_childForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_childForms.Location = new System.Drawing.Point(0, 80);
            this.pnl_childForms.Name = "pnl_childForms";
            this.pnl_childForms.Size = new System.Drawing.Size(984, 481);
            this.pnl_childForms.TabIndex = 2;
            // 
            // toolTip
            // 
            this.toolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip_Draw);
            // 
            // lbl_dateTime
            // 
            this.lbl_dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dateTime.AutoSize = true;
            this.lbl_dateTime.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateTime.ForeColor = System.Drawing.Color.Silver;
            this.lbl_dateTime.Location = new System.Drawing.Point(33, 53);
            this.lbl_dateTime.Name = "lbl_dateTime";
            this.lbl_dateTime.Size = new System.Drawing.Size(137, 24);
            this.lbl_dateTime.TabIndex = 1;
            this.lbl_dateTime.Text = "چهارشنبه 25 آذرماه 1399";
            // 
            // pcb_main
            // 
            this.pcb_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_main.Image = global::ITServiceManagement.Properties.Resources._4401280;
            this.pcb_main.Location = new System.Drawing.Point(232, 54);
            this.pcb_main.Name = "pcb_main";
            this.pcb_main.Size = new System.Drawing.Size(510, 378);
            this.pcb_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_main.TabIndex = 0;
            this.pcb_main.TabStop = false;
            // 
            // btn_closeChildForm
            // 
            this.btn_closeChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_closeChildForm.FlatAppearance.BorderSize = 0;
            this.btn_closeChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeChildForm.Image = global::ITServiceManagement.Properties.Resources.cancel;
            this.btn_closeChildForm.Location = new System.Drawing.Point(909, 0);
            this.btn_closeChildForm.Name = "btn_closeChildForm";
            this.btn_closeChildForm.Size = new System.Drawing.Size(75, 80);
            this.btn_closeChildForm.TabIndex = 1;
            this.btn_closeChildForm.UseVisualStyleBackColor = true;
            this.btn_closeChildForm.Click += new System.EventHandler(this.btn_closeChildForm_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_settings.Image = global::ITServiceManagement.Properties.Resources.settings;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(0, 120);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btn_settings.Size = new System.Drawing.Size(200, 40);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "        تنظیمات";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_customers.FlatAppearance.BorderSize = 0;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_customers.Image = global::ITServiceManagement.Properties.Resources.customer__1_;
            this.btn_customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.Location = new System.Drawing.Point(0, 80);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.btn_customers.Size = new System.Drawing.Size(200, 40);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "        کاربران";
            this.btn_customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pnl_childForms);
            this.Controls.Add(this.pnl_titleBar);
            this.Controls.Add(this.pnl_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "frm_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلی";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            this.pnl_titleBar.ResumeLayout(false);
            this.pnl_titleBar.PerformLayout();
            this.pnl_childForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Panel pnl_titleBar;
        private System.Windows.Forms.Label lbl_mainTitle;
        private System.Windows.Forms.Panel pnl_childForms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_closeChildForm;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_maximaize;
        private System.Windows.Forms.Button btn_minimaize;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lbl_dateTime;
        private System.Windows.Forms.PictureBox pcb_main;
    }
}

