using ITServiceManagement.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITServiceManagement.AdminForms.Users.Tickets
{
    public partial class frm_tickets : Form
    {
        public frm_tickets()
        {
            InitializeComponent();
        }

        private void frm_tickets_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgv_tickets.AutoGenerateColumns = false;
                dgv_tickets.DataSource = db.UserRepository.Get();
            }
        }
    }
}
