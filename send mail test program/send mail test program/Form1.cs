using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Security.Cryptography;

namespace send_mail_test_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        
        
        string[] password = { "A", "1", "F", "B", "W", "Y", "9", "5", "I", "Q", "H", "C", "J", "K", "D", "M", "l", "L", "E", "O", "Z" };
        string pass = null;
        string sifrelenmis;
        private void Form1_Load(object sender, EventArgs e)
        {






        }

        private void btnsend_Click(object sender, EventArgs e)
        {




            try {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("YourGmail@gmail.com", "YourGmailPassord");
                MailMessage msg = new MailMessage();
                msg.To.Add(textBoxto.Text);
                msg.From = new MailAddress("YourGmail@gmail.com");
                msg.Subject = textBoxsubject.Text;
                msg.Body = textBoxmessage.Text;
                client.Send(msg);
                MessageBox.Show("Done : ) ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = 0;
            for (int i = 0; i < 6; i++)
            {
                number = rand.Next(password.Length);
                pass = pass + password[number].ToString();
            }
            textBoxsubject.Text = "Konya Restoran Şifre Yenileme.";
            textBoxmessage.Text = "sayin Kullaıcı Yeni şifreniz: " + pass;
            
            SHA256 sHA256 = new SHA256CryptoServiceProvider();
            byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(pass));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }

            label4.Text = builder.ToString();
            pass = null;
        }
    }
}
