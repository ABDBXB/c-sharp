using deneme_design.Model;
using deneme_design.RestClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace deneme_design.Forms.AdminForms
{
    public partial class PersonelDetails : Form
    {
        AdminForm adminForm = null;
        Employee employee = null;
        JsonService jsonService = null;
        public PersonelDetails(AdminForm admin)
        {
            InitializeComponent();
            this.adminForm = admin;
            jsonService = new JsonService();
            lblHeader.Text = "Yeni Personel Ekle";
            updatePassSwitch.Checked = true;
            updatePassSwitch.Visible = false;
        }

        public PersonelDetails(AdminForm adminForm, Employee employee)
        {
            InitializeComponent();
            jsonService = new JsonService();
            this.adminForm = adminForm;
            this.employee = employee;
            GetEmployeeDetails();
            lblHeader.Text = employee.firstName + " " + employee.lastName;
        }

        private void GetEmployeeDetails()
        {
            txtFirstName.Text = employee.firstName;
            txtLastName.Text = employee.lastName;
            txtUserName.Text = employee.userName;
            txtEmail.Text = employee.email;
            txtPhoneNo.Text = employee.phoneNum;
            txtPass.Text = "****";
            txtPass1.Text = "****";
            if (employee.role.id == 1)
                rbAdmin.Checked = true;
            else
                rbWaiter.Checked = true;
        }

        private void pnlMiddle_Paint(object sender, PaintEventArgs e)
        {
            if (updatePassSwitch.Checked)
            {
                txtPass.Enabled = true;
                txtPass1.Enabled = true;
            }
            else
            {
                txtPass.Enabled = false;
                txtPass1.Enabled = false;
            }
        }

       

        
        private bool isEmpty()
        {
            return txtFirstName.Text.Length == 0 ||
                        txtLastName.Text.Length == 0 ||
                        txtUserName.Text.Length == 0 ||
                        txtEmail.Text.Length == 0 ||
                        txtPhoneNo.Text.Length == 0 ||
                        txtPass.Text.Length == 0 ||
                        txtPass1.Text.Length == 0 ||
                        (!rbAdmin.Checked && !rbWaiter.Checked);
        }

        private void btnRemoveEmployeeProfile_Click(object sender, EventArgs e)
        {
            if (isEmpty())
                return;
            DialogResult result =
                MessageBox.Show(employee.firstName + " " + employee.lastName + "'ye ait tüm bilgiler silenecek\nDevam etmek istiyormusunuz?",
                    "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes.Equals(result))
            {
                long id = jsonService.DeleteEmployee(employee.id);
                if (id == employee.id)
                {
                    MessageBox.Show("işlem tamamlandı");
                    adminForm.openChildForm(new Personel(adminForm));
                }
            }
        }

        private async void btnAddNewEmployeeProfile_Click(object sender, EventArgs e)
        {


            
            
            if (isEmpty())
            {
                MessageBox.Show("Bazı alanları boş bıraktınız tekrar kontrol edeniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (updatePassSwitch.Checked)
            {
                
                if (!txtPass.Text.Equals(txtPass1.Text))
                {
                    MessageBox.Show("Şifreler uyuşmuyor!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            Employee employee = new Employee();
            employee.firstName = txtFirstName.Text;
            employee.lastName = txtLastName.Text;
            employee.userName = txtUserName.Text;
            employee.email = txtEmail.Text;
            employee.phoneNum = txtPhoneNo.Text;

            if (updatePassSwitch.Checked)
                employee._password = PasswordEncoder(txtPass.Text);

            employee.deleted = false;
            Role role = new Role();
            if (rbWaiter.Checked)
            {
                role.id = 2;
                role.name = "waiter";
            }
            else
            {
                role.id = 1;
                role.name = "admin";
            }

            employee.role = role;

            if (this.employee != null)
            {
                employee.id = this.employee.id;
                long id = jsonService.UpdateEmployeeProfile(employee);

                if (id == employee.id)
                {
                    if (updatePassSwitch.Checked)
                    {
                        await SendNewPasswordToEmployeMail(txtPass.Text, employee);
                        MessageBox.Show("Yeni Parola " + employee.email + " mail adresine gönderilmiştir", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    MessageBox.Show("Güncelleme işlemi tamamlandı", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            else
            {
                string result = jsonService.AddNewEmployee(employee);
                await SendNewPasswordToEmployeMail(txtPass.Text, employee);
                string s = result.Split(' ')[0];
                MessageBox.Show(result, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    int x = int.Parse(s);
                }
                catch (Exception)
                {

                    return;
                }
            }
            
            adminForm.openChildForm(new Personel(adminForm));
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            adminForm.openChildForm(new Personel(adminForm));
            this.Close();
        }

        private Task SendNewPasswordToEmployeMail(string pass,Employee employee)
        {
            return Task.Run(() =>
            {
                try
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;

                    client.Credentials = new NetworkCredential("konyarestoran@gmail.com", "1245GHKA.S");

                    MailMessage msg = new MailMessage();
                    msg.To.Add(employee.email);
                    msg.From = new MailAddress("konyarestoran@gmail.com");
                    msg.Subject = "Konya Restoran Şifre Güncelleme";
                    msg.Body = createMailBody(employee, pass);
                    client.Send(msg);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
        private string createMailBody(Employee employee, string pass)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Sayın ");
            builder.Append(employee.firstName);
            builder.Append(" ");
            builder.Append(employee.lastName);
            builder.Append("\n");
            builder.Append(DateTime.Now.ToString());
            builder.Append(" İtibaren Konya Restaoran Sisteminde parolanız güncellenmiştir\n");
            builder.Append("Yeni parola: ");
            builder.Append(pass);
            builder.Append("\n");
            builder.Append("İyi günler!!");

            return builder.ToString();
        }
        
        public string PasswordEncoder(string pass)
        {
            SHA256 sHA256 = new SHA256CryptoServiceProvider();
            byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(pass));
            StringBuilder builder = new StringBuilder();

            foreach (var item in bytes)
                builder.Append(item.ToString("x2"));
            

            return builder.ToString();
        }

        private void btnDeletePersonel_Click(object sender, EventArgs e)
        {

        }
    }
}
