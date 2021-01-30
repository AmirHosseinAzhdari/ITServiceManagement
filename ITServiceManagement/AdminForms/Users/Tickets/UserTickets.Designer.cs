
namespace ITServiceManagement.AdminForms.Users.Tickets
{
    partial class frm_tickets
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
            this.dgv_tickets = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSuccessfull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tickets
            // 
            this.dgv_tickets.AllowUserToAddRows = false;
            this.dgv_tickets.AllowUserToDeleteRows = false;
            this.dgv_tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.Status,
            this.IsSuccessfull});
            this.dgv_tickets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_tickets.Location = new System.Drawing.Point(0, 115);
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.ReadOnly = true;
            this.dgv_tickets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_tickets.Size = new System.Drawing.Size(737, 290);
            this.dgv_tickets.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "وضعیت";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // IsSuccessfull
            // 
            this.IsSuccessfull.DataPropertyName = "IsSuccessfull";
            this.IsSuccessfull.HeaderText = "موفقیت آمیز";
            this.IsSuccessfull.Name = "IsSuccessfull";
            this.IsSuccessfull.ReadOnly = true;
            // 
            // frm_tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 405);
            this.Controls.Add(this.dgv_tickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_tickets";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "وظایف کاربر";
            this.Load += new System.EventHandler(this.frm_tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsSuccessfull;
    }
}