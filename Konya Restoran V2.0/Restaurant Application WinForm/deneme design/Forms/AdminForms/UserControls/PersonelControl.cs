using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using deneme_design.Model;
using Guna.UI2.WinForms;

namespace deneme_design.Forms.AdminForms.UserControls
{
    public partial class PersonelControl : UserControl
    {
        AdminForm adminForm = null;
        Employee employee = null;
        
        public PersonelControl()
        {
            InitializeComponent();
        }
        public PersonelControl(AdminForm adminForm, Employee employee)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            this.employee = employee;
            btnEmployee.Text = employee.firstName + " " + employee.lastName;
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            adminForm.openChildForm(new PersonelDetails(adminForm, employee));
        }
    }
}
