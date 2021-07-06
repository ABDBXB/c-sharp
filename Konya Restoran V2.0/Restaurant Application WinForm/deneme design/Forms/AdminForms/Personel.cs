using deneme_design.Forms.AdminForms.UserControls;
using deneme_design.RestClient;
using System;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms
{
    public partial class Personel : Form
    {
        AdminForm adminForm;
        JsonService jsonService = null;
        public Personel()
        {
            InitializeComponent();
        }
        public Personel(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            this.jsonService = new JsonService();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            GetEmployeesList();
        }

        public void GetEmployeesList()
        {
            jsonService.GetEmployees().ForEach(employee =>
            {
                PersonelControl personel = new PersonelControl(adminForm, employee);
                flowLayoutPanel1.Controls.Add(personel);
            });
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            PersonelDetails personelDetails = new PersonelDetails(adminForm);
            adminForm.openChildForm(personelDetails);
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
