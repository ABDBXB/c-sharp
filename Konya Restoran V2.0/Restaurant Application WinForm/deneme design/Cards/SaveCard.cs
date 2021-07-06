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
    class SaveCard : Guna2Panel
    {
        public Label lbl;
        public Label lbl1;
        public Label lbl2;
        public Label lbl3;
        public Label lbl4;
        public Panel pnl;
        public SaveCard()
        {
            PanelProperties();
            this.lbl = LabelProperties();
            
            this.Controls.Add(this.lbl);

            this.lbl1 = LabelProperties();
            lbl1.Location = new Point(161, 18);
            lbl1.Size = new Size(58, 15);
            this.Controls.Add(this.lbl1);

            this.lbl2 = LabelProperties();
            lbl2.Location = new Point(233, 18);
            lbl2.Size = new Size(25, 15);
            this.Controls.Add(this.lbl2);

            this.lbl3 = LabelProperties();
            lbl3.Location = new Point(286, 18);
            lbl3.Size = new Size(56, 15);
            this.Controls.Add(this.lbl3);

            this.lbl4 = LabelProperties();
            lbl4.Location = new Point(365, 18);
            lbl4.Size = new Size(140, 15);
            this.Controls.Add(this.lbl4);

            this.pnl = Panel1Properties();
            this.Controls.Add(pnl);
        }

        private void PanelProperties()
        {
            this.FillColor = Color.White;
            this.CustomBorderThickness = new Padding(2, 2, 2, 2);
            this.CustomBorderColor = Color.Black;
            this.Size = new Size(513, 49);
            this.Font = new Font("Segoe UI Symbol", 9);
        }

        private Panel Panel1Properties()
        {
            Panel pnl = new Panel();
            pnl.Location = new Point(2, 2);
            pnl.Size = new Size(8, 45);
            pnl.BackColor = Color.Transparent;
            return pnl;
        }
        private Label LabelProperties()
        {
            Label lbl = new Label();
            lbl.ForeColor = Color.Black;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Location = new Point(13, 18);
            lbl.Size = new Size(135, 15);
            return lbl;
        }
    }
}
