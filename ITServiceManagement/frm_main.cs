﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ITServiceManagement
{
    public partial class frm_main : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frm_main()
        {
            InitializeComponent();
            random = new Random();
            btn_closeChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_users(), sender);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_settings(), sender);
        }

        private void btn_closeChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void pnl_titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_mainTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximaize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btn_minimaize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_close_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Close", btn_close);

            toolTip.OwnerDraw = true;
            toolTip.BackColor = Color.Yellow;
        }

        private void btn_maximaize_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Maximize", btn_maximaize);

            toolTip.OwnerDraw = true;
            toolTip.BackColor = Color.Yellow;
        }

        private void btn_minimaize_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Minimize", btn_minimaize);

            toolTip.OwnerDraw = true;
            toolTip.BackColor = Color.Yellow;
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }




        #region Helper Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F,
                        FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    pnl_titleBar.BackColor = color;
                    pnl_logo.BackColor = ThemeColor.ChangeColorBrighteness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrighteness(color, -0.3);
                    btn_closeChildForm.Visible = true;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_childForms.Controls.Add(childForm);
            this.pnl_childForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_mainTitle.Text = childForm.Text;
        }

        private void DisableButton()
        {
            foreach (Control previusBtn in pnl_menu.Controls)
            {
                if (previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previusBtn.ForeColor = Color.Gainsboro;
                    previusBtn.Font = new Font("Microsoft Sans Serif", 10F,
                        FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Reset()
        {
            DisableButton();
            lbl_mainTitle.Text = "صفحه اصلی";
            pnl_titleBar.BackColor = Color.FromArgb(0, 150, 136);
            pnl_logo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btn_closeChildForm.Visible = false;
        }

        #endregion
    }
}
