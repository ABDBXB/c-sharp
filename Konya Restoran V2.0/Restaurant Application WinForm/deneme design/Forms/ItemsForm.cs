using deneme_design.Cards;
using deneme_design.Model;
using deneme_design.RestClient;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Helpers;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace deneme_design
{

    public partial class ItemsForm : Form
    {
        public Table table { get; set; }
        public Order order { get; set; }
        public FlowLayoutPanel itemsFlowLayoutPanel;
        public FlowLayoutPanel billsFlowLayoutPanel;
        public Label lblTotalPrice;
        public Label lblOrderNo;
        public Guna2Button btnCreateOrderNo;
        public List<BillCard> billCardList = null;
        JsonService jsonService = null;

        public ItemsForm(Table table)
        {
            InitializeComponent();
            jsonService = new JsonService();
            billCardList = new List<BillCard>();
            PanelScrollHelper panelScrollHelper = new PanelScrollHelper(flowLayoutPanel1, guna2VScrollBar1, true);
            PanelScrollHelper billListScroll = new PanelScrollHelper(flowLayoutPanel2, guna2VScrollBar2, true);
            billListScroll.UpdateScrollBar();
            panelScrollHelper.UpdateScrollBar();

            this.table = table;
            this.itemsFlowLayoutPanel = flowLayoutPanel1;
            this.billsFlowLayoutPanel = flowLayoutPanel2;
            this.lblTotalPrice = label3;
           
            this.lblOrderNo = lblBillNo;
        }

        private void GetOrderList(Order order)
        {
            float totalPrice = 0;
            flowLayoutPanel2.Controls.Clear();

            order.FoodOrderList.ForEach(foodOrder =>
            {
                BillCard billCard = new BillCard(
                    foodOrder.foodItem_portion,
                    foodOrder.price,
                    foodOrder.quantity,
                    foodOrder.foodItem_portion.portion.name,
                    foodOrder.employee.firstName + " " + foodOrder.employee.lastName,
                    this,
                    foodOrder.id );

                totalPrice += float.Parse((billCard.label.Text.Split(' '))[0]);

                flowLayoutPanel2.Controls.Add(billCard);
                flowLayoutPanel2.Controls.SetChildIndex(billCard, 0);

                billCardList.Add(billCard);
            });

            label3.Text = string.Format("{0:0.00}", totalPrice);
        }

        public  void ItemForm_Load(object sender, EventArgs e)
        {
            billCardList.Clear();

            if (this.table._status)
            {
                this.order = jsonService.getOrderById(this.table.id);
                GetOrderList(this.order);
                lblBillNo.Text = this.order.id.ToString();
                guna2CircleButton1.FillColor = Color.Red;
                
            }
            label5.Text = this.table.id.ToString();
            label6.Text = ApiClient.employeeProfile.firstName + " " + ApiClient.employeeProfile.lastName;

             GetFoodItemList();
        }

        // GetFoodItem From Server
        public  void GetFoodItemList()
        {
            flowLayoutPanel1.Controls.Clear();
            jsonService.GetItemList().ForEach( food =>
            {
                List<FoodItem_Portion> foodItem_PortionsList =   jsonService.GetPortionListByFoodItemId(food.id);
                FoodItemCard foodCard = new FoodItemCard(foodItem_PortionsList, this);
                flowLayoutPanel1.Controls.Add(foodCard);
            });
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            List<BillCard> list = billCardList.FindAll(x => x.comboBox.Enabled == true);
            bool test = false;
            string itemName = string.Empty, qunatity = string.Empty;
            list.ForEach(card =>
            {
                list.ForEach(anotherCard =>
                {
                    if (card.Text.Equals(anotherCard.Text) && card != anotherCard)
                    {
                        int sumQunatity = Convert.ToInt32(card.numericUpDown.Value + anotherCard.numericUpDown.Value);
                        if (sumQunatity > card.foodItem_Portion.foodItem.quantity)
                        {
                            itemName = card.foodItem_Portion.foodItem.itemName;
                            qunatity = (card.foodItem_Portion.foodItem.quantity * card.foodItem_Portion.portion.calculate) .ToString();
                            test = true;
                        }
                    }  
                });
            });
            if (test)
            {
                MessageBox.Show( itemName + "'dan sadece" + qunatity + " adet bulunmaktadır\nSiparişi tekrar düzenleyiniz");
                return;
            }
           
            BillForm bill = new BillForm(label3.Text, this.order.id, this);
            bill.Show();
        }

        private void Yemekler_Click(object sender, EventArgs e)
        {
            GetItemListByCategory(2);
        }
        
        private void icecekler_Click(object sender, EventArgs e)
        {
            GetItemListByCategory(1);
        }

        private void tatlilar_Click(object sender, EventArgs e)
        {
            GetItemListByCategory(3);
        }

        private  void GetItemListByCategory(long categoryId)
        {
            flowLayoutPanel1.Controls.Clear();
            jsonService.GetItemListByCategoryId(categoryId).ForEach(item =>
            {
                List<FoodItem_Portion> foodItem_PortionsList =  jsonService.GetPortionListByFoodItemId(item.id);
                FoodItemCard foodCard = new FoodItemCard(foodItem_PortionsList, this);
                flowLayoutPanel1.Controls.Add(foodCard);
            });
        }

        // Back Button ( << )
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
      
        // Open Order
        
  
        private bool checkIfBillCardSaved()
        {
            foreach (var bill in billCardList)
            {
                if (bill.comboBox.Enabled == true)
                    return false;
            } 
            return true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel2.Controls.Count == 0)
            {
                DialogResult result1 =  MessageBox.Show("Siparış eklemediniz! Oturumu kapatmak isyormusunuz?", "Eksi Bilgi", MessageBoxButtons.YesNo);

                if (result1.Equals(DialogResult.Yes))
                {

                    long id = jsonService.CloseOrder(this.order.id);
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                    return;
                }
                return;
            }
            if (!checkIfBillCardSaved())
            {
                MessageBox.Show("Ekldiğiniz siparişleri kaydetmediniz ", "Eksi Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }




            DialogResult result =  MessageBox.Show("Ödeme işlemi yapılacak devam etmek istiyor musunuz? ", "Ödeme Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult.Yes == result)
            {
                PdfWrit();

                long id = jsonService.CloseOrder(this.order.id);
                if (id == this.order.id)
                {
                     result = MessageBox.Show("Ödeme işlemi tamamlandı\nFaturayı yazdırmak istiyor musunuz?", "Ödeme Tamamlandı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (DialogResult.Yes.Equals(result))
                        Process.Start(Path.GetFullPath("bills/" + this.order.id + ".pdf"));
                    
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                }
            }
        }

        private void PdfWrit()
        {
            // türkçe Karakter desteklemek için
            BaseFont STF_Helvetica_Turkish = 
                BaseFont.CreateFont("Helvetica", "CP1254", BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

            var header = new PdfPTable(new[] { .15f })
            {
                HorizontalAlignment = 1,
                WidthPercentage = 50,
                DefaultCell = { MinimumHeight = 22f, Border = 2, HorizontalAlignment = 1 }
            };
            header.AddCell(new Phrase("Konya Restaurant", new iTextSharp.text.Font(STF_Helvetica_Turkish, 14, iTextSharp.text.Font.BOLD)));

            var headerTable = new PdfPTable(new[] { .15f, .02f, .5f })
            {
                HorizontalAlignment = 1,
                WidthPercentage = 50,
                DefaultCell = { MinimumHeight = 22f, Border = 0 }
            };

            headerTable.AddCell("Fatura No");
            headerTable.AddCell(":");
            headerTable.AddCell(this.order.id.ToString());
            headerTable.AddCell(new Phrase("Giriş Tarihi", fontNormal));
            headerTable.AddCell(":");
            headerTable.AddCell(this.order.startingDate.ToString());
            headerTable.AddCell(new Phrase("Çıkış Tarihi", fontNormal));
            headerTable.AddCell(":");
            headerTable.AddCell(DateTime.Now.ToString());
            var cell1 = new PdfPCell(new Phrase("-----------------------------------------------------"));
            cell1.Colspan = 5;
            cell1.Border = 0;
            cell1.HorizontalAlignment = Element.ALIGN_CENTER;
            headerTable.AddCell(cell1);

            var headerTable1 = new PdfPTable(new[] { .12f, .1f, .06f, .07f, .15f })
            {
                HorizontalAlignment = 1,
                WidthPercentage = 80,
                DefaultCell = { MinimumHeight = 22f, Border = 0, HorizontalAlignment = 1 }
            };
            foreach (var x in billCardList)
            {
                    headerTable1.AddCell((x.Text.Split('_'))[0]);
                    headerTable1.AddCell(x.comboBox.Text);
                    headerTable1.AddCell(x.numericUpDown.Value.ToString());
                    headerTable1.AddCell(x.label.Text);
                    headerTable1.AddCell((x.Text.Split('_'))[1]);
 
            }
            var cell = new PdfPCell(new Phrase("-----------------------------------------------------"));
            cell.Colspan = 5;
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            headerTable1.AddCell(cell);

            var toplam = new PdfPTable(new[] { .5f, .2f })
            {
                HorizontalAlignment = 1,
                WidthPercentage = 50,
                DefaultCell = { MinimumHeight = 22f, Border = 2, HorizontalAlignment = 1 }
            };

            cell = new PdfPCell(new Phrase("Toplam Fiyat:"));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            toplam.AddCell(cell);

            cell = new PdfPCell(new Phrase(label3.Text + " TL"));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            toplam.AddCell(cell);

            var space = new Paragraph("")
            {
                SpacingBefore = 15f,
                SpacingAfter = 15f
            };

            Document doc = new Document(PageSize.A4.Rotate());
            PdfWriter.GetInstance(doc, new FileStream("bills/" + this.order.id + ".pdf", FileMode.Create));
            doc.Open();
            doc.Add(header);
            doc.Add(space);
            doc.Add(headerTable);
            doc.Add(space);
            doc.Add(headerTable1);
            doc.Add(space);
            doc.Add(toplam);
            doc.Close();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            List<FoodItem> foodItemList = jsonService.GetItemListByName(txtItemName.Text);
            if (foodItemList == null)
            {
                flowLayoutPanel1.Controls.Clear();
                return;
            }

            foodItemList.ForEach(food =>
            {
                List<FoodItem_Portion> foodItem_PortionsList = jsonService.GetPortionListByFoodItemId(food.id);
                FoodItemCard foodCard = new FoodItemCard(foodItem_PortionsList, this);
                flowLayoutPanel1.Controls.Add(foodCard);
            });
        }
    }
}
