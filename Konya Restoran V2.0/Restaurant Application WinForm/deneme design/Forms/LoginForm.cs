﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using deneme_design.Model;
using System.Security.Cryptography;

namespace deneme_design
{
    public partial class LoginForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private string PasswordEncoder(string pass)
        {
            SHA256 sHA256 = new SHA256CryptoServiceProvider();
            byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(pass));
            StringBuilder builder = new StringBuilder();

            foreach (var item in bytes)
                builder.Append(item.ToString("x2"));
            
            return builder.ToString();
        }

        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            ApiClient client = new ApiClient(new Employee(textBox1.Text, PasswordEncoder(textBox2.Text)));
            DialogResult dialogResult = DialogResult.None;
            LoginStatus status;
            
            do
            {
                Task<LoginStatus> task = new Task<LoginStatus>(client.login);
                task.Start();
                status = await task;

                if (LoginStatus.SUCCESS.Equals(status))
                {
                    if (client.employee.role.name.Equals("waiter"))
                    {
                        
                        MainForm teleport = new MainForm();
                        teleport.Show();
                        this.Hide();
                    }

                    else if (client.employee.role.name.Equals("admin"))
                    {  
                        AdminForm teleport = new AdminForm();
                        teleport.Show();
                        this.Hide();
                    }
                }
                else if (LoginStatus.FAIL.Equals(status))
                    dialogResult = MessageBox.Show("Sonucuya bağlanamıyor", "Uyarı", MessageBoxButtons.RetryCancel);
                else
                    label2.Text = "Kullanıcı adı veya şifre Hatalı";
            
            } while (dialogResult.Equals(DialogResult.Retry) && LoginStatus.FAIL.Equals(status));

        }

        
        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            panel1.Width = 200;
        }

        // UserNameTextBox OnLeave
        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel1.Width = 150;
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı Adı";
                textBox1.ForeColor = Color.LightGray;
            }
        }
        // UserNameTextBox OnTextChanged
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
        // PasswordTextBox OnMouseClick
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
            panel2.Width = 200;
        }
        // PasswordTextBox OnLeave
        private void textBox2_Leave(object sender, EventArgs e)
        {
            panel2.Width = 150;
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.LightGray;
            }
        }
        // PasswordTextBox TextChanged
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }


        // X (exit) Button OnMouseClick
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        // Form Settings
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
