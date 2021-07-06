using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;
using deneme_design.Cards;
using deneme_design.Model;
using deneme_design.RestClient;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Helpers;

namespace deneme_design
{
    public partial class MainForm : Form
    {

        List<Guna2Button> buttonList = null;
        List<Table> tableList = null;

        private JsonService jsonService = new JsonService();
        public MainForm()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            PanelScrollHelper billListScroll = new PanelScrollHelper(flowLayoutPanel1, guna2VScrollBar1, true);
            billListScroll.UpdateScrollBar();
            this.tableList = jsonService.getTableList();
            GetButtonList();

        }
        private void GetButtonList()
        {
            buttonList = new List<Guna2Button>();
            buttonList.Add(btnAllTables);
            buttonList.Add(btnEmptyTables);
            buttonList.Add(btnBusyTables);
        }

        // Form Resize
        private const int cGrip = 16;
        private const int cCaptoin = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaptoin)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void GetTables(List<Table> tables)
        {
            flowLayoutPanel1.Controls.Clear();
            tables.ForEach(table =>
            {
                TableCard tableCard = new TableCard(table, this);
                flowLayoutPanel1.Controls.Add(tableCard);
            });
  
        }

        private  void MainForm_Load(object sender, EventArgs e)
        {

            btnLogout.Text = ApiClient.employeeProfile.firstName + " " + ApiClient.employeeProfile.lastName;
            GetTableStatistics(tableList);
            GetTables(tableList);
            buttonList.ForEach(btn => btn.Click += Btn_Click);
        }
        private void GetTableStatistics(List<Table> tables)
        {
            float empty = 0, busy = 0;
            tables.ForEach(table => { if (table._status) busy++; else empty++;});
            lblAvailableTables.Text = "Boş Masalar: " + empty;
            lblBusyTables.Text = "Dolu Masalar: " + busy;
            lblBusyTableRatio.Text = string.Format("Doluluk Oranı: {0:0.0}%", (busy / tableList.Count) * 100);
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            buttonList.ForEach( button => {
                if (button == btn)
                {
                    btn.FillColor = Color.FromArgb(31, 28, 47);
                }
                else
                {
                    button.FillColor = Color.Transparent;
                }
            });
            

            tableList = jsonService.getTableList();
            pnlVertical.Top = btn.Top;
            if (btn == buttonList[0])
                GetTables(tableList);       
            else if(btn == buttonList[1]) 
                GetTables(tableList.FindAll(table => table._status == false));
            else
                GetTables(tableList.FindAll(table => table._status == true));

            GetTableStatistics(tableList);
        }
        
        private void btnMinimize_Maximize_Click(object sender, EventArgs e)
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


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTableNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTableNo_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
              
            if(txtTableNo.Text == "")
            {
                GetTables(tableList);
                return;
            }
            else
            {
                Table table = jsonService.GetTableById(long.Parse(txtTableNo.Text));
                if (table == null)
                    return;

                TableCard tableCard = new TableCard(table, this);
                flowLayoutPanel1.Controls.Add(tableCard);
            } 
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
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
