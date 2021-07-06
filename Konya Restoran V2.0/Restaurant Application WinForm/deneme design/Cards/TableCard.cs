using deneme_design.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_design.Cards
{
    class TableCard : Guna2GradientPanel
    {
        public Table table { get; set; }
        public Guna2Button btn;
        public Guna2CircleButton btnStatus;
        private MainForm mainForm;

        public TableCard(Table table, MainForm mainForm)
        {
            this.mainForm = mainForm;
            this.table = table;
            this.btnStatus = CircleButtonProperties();
            this.btn = ButtonProperties();

            PanelProperties();
            this.Controls.Add(PictureBoxProperties());
            this.Controls.Add(LabelProperties());
            this.Controls.Add(LinePanel());
            this.Controls.Add(btn);
            this.Controls.Add(btnStatus);
        }

        private void PanelProperties()
        {  
            this.BackColor = Color.Transparent;
            this.BorderRadius = 7;
            this.FillColor = Color.FromArgb(52, 60, 94);
            this.FillColor2 = Color.FromArgb(28, 35, 67);
            this.ForeColor = Color.FromArgb(62, 120, 138);
            this.Margin = new Padding(10, 10, 10, 10);
            this.ShadowDecoration.BorderRadius = 7;
            this.ShadowDecoration.Depth = 20;
            this.ShadowDecoration.Shadow = new Padding(0, 0, 8, 8);
            this.Size = new Size(167, 171);
            this.TabIndex = 5; 
            this.MouseClick += TableCard_MouseClick;
        }
        private PictureBox PictureBoxProperties()
        {
            PictureBox pb = new PictureBox();

            pb.BackColor = Color.Transparent;
            pb.Location = new Point(52, 30);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(60, 39);
            if (this.table._status)
                pb.Image = Properties.Resources.busy_table2;
            else
                pb.Image = Properties.Resources.empty_table2;


            pb.MouseClick += TableCard_MouseClick;

            return pb;
        }

        private Label LabelProperties()
        {
            Label lbl = new Label();

            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Cascadia Code", 14);
            lbl.Text = "~ " +this.table.id + " ~";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(39, 83);
            lbl.Size = new Size(87, 24);
            lbl.TabIndex = 7;
            lbl.MouseClick += TableCard_MouseClick;

            return lbl;
        }
        private Panel LinePanel()
        {
            Panel pnl = new Panel();
            pnl.BackColor = Color.FromArgb(10, 141, 255);
            pnl.Location = new Point(21, 110);
            pnl.Size = new Size(125, 1);
            pnl.MouseClick += TableCard_MouseClick;
            return pnl;
        }

        private Guna2Button ButtonProperties()
        {
            Guna2Button btn = new Guna2Button();

            btn.Animated = true;
            btn.BackColor = Color.Transparent;
            btn.Name = this.table.id.ToString();
            btn.BorderRadius = 4;
            btn.FillColor = Color.FromArgb(10, 141, 255);
            btn.Font = new Font("verdana", 14);
            btn.Location = new Point(25, 117);
            btn.Size = new Size(115, 31);
            btn.Text = "Git";
            btn.TabIndex = 9;
            btn.MouseEnter += Btn_MouseEnter;
            btn.MouseLeave += Btn_MouseLeave;
            btn.MouseClick += TableCard_MouseClick;

            return btn;
        }

        private void TableCard_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.Hide();
            ItemsForm teleport = new ItemsForm(this.table);
            teleport.Show();
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            this.ShadowDecoration.Enabled = false;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            this.ShadowDecoration.Enabled = true;
        }

        private Guna2CircleButton CircleButtonProperties()
        {
            Guna2CircleButton circle = new Guna2CircleButton();

            circle.BackColor = Color.Transparent;
            circle.FillColor = this.table._status.Equals(true) ? Color.Red :  Color.Green;
            circle.Location = new Point(8, 8);
            circle.Size = new Size(15, 15);

            return circle;
        }
    }
}
