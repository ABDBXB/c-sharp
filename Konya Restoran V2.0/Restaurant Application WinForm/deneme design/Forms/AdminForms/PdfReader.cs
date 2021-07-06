using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms
{
    
    public partial class PdfReader : Form
    {
        AdminForm adminForm = null;
        public PdfReader(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            axAcroPDF1.src = Path.GetFullPath("bills\\" + txtBillNo.Text + ".pdf");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
