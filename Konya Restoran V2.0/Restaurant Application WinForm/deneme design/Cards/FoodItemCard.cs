using deneme_design.Model;
using deneme_design.RestClient;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace deneme_design.Cards
{
    class FoodItemCard : Guna2GradientPanel
    {
        public Guna2GradientPanel lblPrice;
        public Guna2GradientPanel lblQuantity;
        public Guna2GradientPanel lblFoddName;
        public Guna2Button btnAdd;
        public Guna2PictureBox pictureBox;
        private ItemsForm itemsForm;
        private JsonService jsonService;
        public List<FoodItem_Portion> foodItem_PortionList;

        public  FoodItemCard(List<FoodItem_Portion> foodItem_PortionList, ItemsForm itemsForm)
        {
            this.itemsForm = itemsForm;
            
            this.foodItem_PortionList = foodItem_PortionList;
            
            jsonService = new JsonService();
            FoodItemCardProperties();

            this.lblFoddName = FoodNamePnlProperties();
            this.lblPrice = PnlPirceProperties();
            this.lblQuantity = PnlQuantityProperties();
            this.btnAdd = BtnAddProperties();

            if (foodItem_PortionList[0].foodItem.quantity <= 0)
                this.btnAdd.Enabled = false;

            getImage();
            this.Controls.Add(lblFoddName);
            this.Controls.Add(lblQuantity);
            this.Controls.Add(lblPrice);
            this.Controls.Add(btnAdd);
            this.Controls.Add(pictureBox);
        }
        private void getImage()
        {
            this.pictureBox =  PictureBoxProperties();
        }
        private void FoodItemCardProperties()
        {
            this.BackColor = Color.FromArgb(31, 28, 47);
            this.BorderRadius = 10;
            this.BorderColor = Color.White;
            this.BorderThickness = 2;
            this.Margin = new Padding(10, 10, 10, 10);
            this.Size = new Size(267, 118);
            this.FillColor = Color.Transparent;
            this.FillColor2 = Color.Transparent;
        }

        private Guna2GradientPanel FoodNamePnlProperties()
        {
            Guna2GradientPanel pnl = new Guna2GradientPanel();

            pnl.BackColor = Color.Transparent;
            pnl.BorderRadius = 15;
            pnl.FillColor = Color.FromArgb(254, 84, 113);
            pnl.FillColor2 = Color.FromArgb(208, 42, 126);
            pnl.Location = new Point(113, 47);
            pnl.Margin = new Padding(3, 3, 3, 3);
            pnl.Size = new Size(140, 27);
            pnl.TabIndex = 4;
            pnl.CustomizableEdges.BottomRight = false;
            pnl.CustomizableEdges.TopLeft = false;
            pnl.Padding = new Padding(0,0, 0, 12);
           
            Label lbl = new Label();
            lbl.Text = this.foodItem_PortionList[0].foodItem.itemName;
            lbl.ForeColor = Color.White;
            lbl.Size = new Size(140, 24);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Verdana", 13);
            pnl.Controls.Add(lbl);

            return pnl;
        }
        private Guna2GradientPanel PnlPirceProperties()
        {
            Guna2GradientPanel pnl = new Guna2GradientPanel();

            pnl.BackColor = Color.Transparent;
            pnl.BorderRadius = 15;
            pnl.FillColor = Color.FromArgb(254, 84, 113);
            pnl.FillColor2 = Color.FromArgb(208, 42, 126);
            pnl.Location = new Point(113, 12);
            pnl.Margin = new Padding(3, 3, 3, 3);
            pnl.Size = new Size(65, 24);
            pnl.TabIndex = 4;
            pnl.CustomizableEdges.BottomRight = false;
            pnl.CustomizableEdges.TopLeft = false;

            Label lbl = new Label();
            lbl.Size = new Size(65, 24);
            lbl.ForeColor = Color.White;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Verdana", 11);
            lbl.Text = this.foodItem_PortionList[0].unitPrice + " tl";
            pnl.Controls.Add(lbl);

            return pnl;
        }

        private Guna2GradientPanel PnlQuantityProperties()
        {
            Guna2GradientPanel pnl = new Guna2GradientPanel();

            pnl.BackColor = Color.Transparent;
            pnl.BorderRadius = 15;
            pnl.FillColor = Color.FromArgb(254, 84, 113);
            pnl.FillColor2 = Color.FromArgb(208, 42, 126);
            pnl.Location = new Point(191, 12);
            pnl.Margin = new Padding(3, 3, 3, 3);
            pnl.Size = new Size(62, 24);
            pnl.TabIndex = 4;
            pnl.CustomizableEdges.BottomRight = false;
            pnl.CustomizableEdges.TopLeft = false;

            Label lbl = new Label();
            lbl.Text = (this.foodItem_PortionList[0].foodItem.quantity / this.foodItem_PortionList[0].portion.calculate). ToString();
            lbl.Size = new Size(62, 24);
            lbl.ForeColor = Color.White;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Verdana", 11);
            pnl.Controls.Add(lbl);
            if(float.Parse(lbl.Text) <= 10.0f)
            {
                pnl.FillColor = Color.Red;
                pnl.FillColor2 = Color.Red;
            }
            return pnl;
        }

        private Guna2Button BtnAddProperties()
        {
            Guna2Button btn = new Guna2Button();
            btn.FillColor = Color.FromArgb(254, 84, 113);
            btn.BorderRadius = 8;
            btn.ForeColor = Color.White;
            btn.Location = new Point(161, 87);
            btn.Size = new Size(101, 26);
            btn.TabIndex = 6;
            btn.Text = "EKLE";
            btn.Animated = true;
            btn.MouseClick += Btn_MouseClick;
            
            return btn;
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (itemsForm.order == null)
            {
                DialogResult dialogResult = MessageBox.Show("Fatura Numarasını OLUŞTURMADINIZ..\n Fatura Numarasını oluşturmak istyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DialogResult.Yes.Equals(dialogResult))
                {
                    itemsForm.order = jsonService.OpenOrder(itemsForm.table.id);

                    if(itemsForm.order != null)
                    {
                        itemsForm.table._status = true;
                        
                        itemsForm.lblOrderNo.Text = itemsForm.order.id.ToString();
                        itemsForm.itemsFlowLayoutPanel.Controls.Clear();
                        itemsForm.ItemForm_Load(itemsForm, null);
                    }     
                }
            }
            else
            {
                BillCard billCard = new BillCard(this.foodItem_PortionList, itemsForm);
                itemsForm.billCardList.Add(billCard);
                itemsForm.billsFlowLayoutPanel.Controls.Add(billCard);
                itemsForm.billsFlowLayoutPanel.Controls.SetChildIndex(billCard, 0);
                itemsForm.lblTotalPrice.Text = string.Format("{0:0.00}", float.Parse(itemsForm.lblTotalPrice.Text) + float.Parse((billCard.label.Text.Split(' '))[0]));
            }
        }

        private  Guna2PictureBox PictureBoxProperties()
        {
            Guna2PictureBox pic = new Guna2PictureBox();

            pic.BorderRadius = 10;
            pic.Size = new Size(104, 112);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Location = new Point(3, 3);
            pic.BackColor = Color.Transparent;
            pic.FillColor = Color.FromArgb(31, 28, 47);
            if(this.foodItem_PortionList[0].foodItem.itemImages != null)
            pic.Image = jsonService.DownloadImage(this.foodItem_PortionList[0].foodItem.itemImages.id);
            
            return pic;
        }
    }
}
