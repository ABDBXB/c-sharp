using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using deneme_design.Model;
using deneme_design.Cards;
using deneme_design.Context;
using deneme_design.RestClient;

namespace deneme_design
{
    public partial class BillForm : Form
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

        List<ItemContext> itemList = new List<ItemContext>();
        public BillForm()
        {
            InitializeComponent();
            jsonService = new JsonService();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private ItemsForm itemsForm { get; set; }

        private JsonService jsonService = null;
        private long orderId { get; set; }
        public BillForm(string totalPrice, long orderId, ItemsForm itemsForm)
        {
            InitializeComponent();
            this.itemsForm = itemsForm;
            this.orderId = orderId;  
            label37.Text = totalPrice;
            jsonService = new JsonService();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        bool move;
        int mouse_x;
        int mouse_y;

        // Form Settings
        private void guna2GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void guna2GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }
        private void guna2GradientPanel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            foreach (var billCard in this.itemsForm.billCardList)
            {
                SaveCard card = new SaveCard();

                string[] s = billCard.Text.Split('_');
                card.lbl.Text = s[0].Trim();
                card.lbl1.Text = billCard.comboBox.Text;
                card.lbl2.Text = billCard.numericUpDown.Value.ToString();
                card.lbl3.Text = billCard.label.Text;
                card.lbl4.Text = s[1].Trim();

                flowLayoutPanel1.Controls.Add(card);
                if (billCard.comboBox.Enabled)
                {
                    flowLayoutPanel1.Controls.SetChildIndex(card, 0); 
                    card.pnl.BackColor = Color.Green;
                    ItemContext item = new ItemContext(billCard.foodItem_Portion.id,
                        float.Parse(billCard.label.Text.Split(' ')[0]),
                        float.Parse(billCard.numericUpDown.Value.ToString()));

                    itemList.Add(item);
                }  
            }
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            if (itemList.Count == 0)
            {
                DialogResult dialogResult =  MessageBox.Show("Yeni bir sipariş eklemediniz ...!","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialogResult.Equals(DialogResult.OK))
                {
                    this.Close();
                    return;
                }
            }

            long result = jsonService.SaveOrder(itemList, this.orderId);

            if (result == this.orderId)
            {
                MessageBox.Show("Başarılı bir şekilde kaydedildi...");
                itemsForm.ItemForm_Load(itemsForm, null);
                this.Close();
            }
            else
                MessageBox.Show("Bir Hata Oluştu","Hata", MessageBoxButtons.OK,MessageBoxIcon.Error); 
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
