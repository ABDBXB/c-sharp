using deneme_design.Cards;
using deneme_design.Forms.AdminForms;
using System;
using System.Windows.Forms;

namespace deneme_design
{
    public partial class AdminForm : Form
    {
        private Form activeForm = null;
        public AdminForm()
        {
            InitializeComponent();   
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlVertical.Visible = true;
            pnlVertical.Top = btnMenu.Top;
            openChildForm(new FoodItemsPanel(this));
        }
        private void btnPerson_Click(object sender, EventArgs e)
        {
            pnlVertical.Visible = true;
            openChildForm(new Personel(this));
            pnlVertical.Top = btnPerson.Top;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            pnlVertical.Visible = true;
            pnlVertical.Top = btnTables.Top;
            openChildForm(new AdminTables(this));
        }
        private void btnTables_Click(object sender, EventArgs e)
        {
            pnlVertical.Visible = true;
            openChildForm(new PdfReader(this));
            pnlVertical.Top = btnBill.Top;
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istiyormusunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (DialogResult.Yes.Equals(result))
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}
