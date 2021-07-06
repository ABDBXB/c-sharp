using deneme_design.Context;
using deneme_design.Model;
using deneme_design.RestClient;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace deneme_design.Cards
{
    public class BillCard : Guna2GroupBox
    {
        public Guna2ComboBox comboBox;
        public Guna2NumericUpDown numericUpDown;
        public Label label;
        public Guna2Button deleteButton;
        public Guna2Button updateButton;
        public Guna2Button confirmUpdateButton;
        public Guna2Button cancelUpdateButton;
        public List<FoodItem_Portion> foodItem_PortionList;
        private JsonService jsonService;
        public FoodItem_Portion foodItem_Portion;
        private ItemsForm itemsForm;
        public long foodItem_OrderId;
        public float qunatity;
        public float price;
        public BillCard(List<FoodItem_Portion> foodItem_PortionList, ItemsForm itemsForm)
        {
           
            jsonService = new JsonService();
            this.foodItem_PortionList = foodItem_PortionList;
            this.foodItem_Portion = this.foodItem_PortionList[0];
            this.itemsForm = itemsForm;

            BillCardProperties();

            comboBox = ComboBoxProperties();
            comboBox.SelectedIndexChanged += Cb_SelectedIndexChanged;

            numericUpDown = NumericUpDownProperties();
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;

            label = LabelProperties();
            label.Text = foodItem_PortionList[0].unitPrice + " TL";

            deleteButton = DeleteButtonProperties();

            updateButton = UpdateButtonProperties();
            updateButton.Enabled = false;

            Controls.Add(comboBox);
            Controls.Add(numericUpDown);
            Controls.Add(label);
            Controls.Add(deleteButton);
            Controls.Add(updateButton); 
        }

        public BillCard(FoodItem_Portion foodItem_Portion, float price, float qunatity, string portion, string employeeName, ItemsForm itemsForm, long foodItem_OrderId)
        {
            this.qunatity = qunatity;
            this.price = price;
            this.foodItem_OrderId = foodItem_OrderId;
            this.itemsForm = itemsForm;
            this.foodItem_Portion = foodItem_Portion;
            jsonService = new JsonService();

            BillCardProperties();
            Text = this.foodItem_Portion.foodItem.itemName + " _ " + employeeName;

            comboBox = ComboBoxProperties(portion);
            comboBox.Enabled = false;

            numericUpDown = NumericUpDownProperties();
            numericUpDown.Maximum = Convert.ToDecimal(qunatity); 
            numericUpDown.Value = Convert.ToDecimal(qunatity);
            numericUpDown.Enabled = false;
   
            label = LabelProperties();
            label.Text = string.Format("{0:00.0}", price + " TL");

            deleteButton = DeleteButtonProperties();
            updateButton = UpdateButtonProperties();

            confirmUpdateButton = ConfirmUpdateButtonProperties();
            cancelUpdateButton = CancelUpdateButtonProperties();

            Controls.Add(comboBox);
            Controls.Add(numericUpDown);
            Controls.Add(label);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(confirmUpdateButton);
            Controls.Add(cancelUpdateButton);
        }

        private void BillCardProperties()
        {
            BackColor = Color.Transparent;
            FillColor = Color.Transparent;
            BorderRadius = 6;

            Text = this.foodItem_Portion.foodItem.itemName + " _ " + ApiClient.employeeProfile.firstName + " " +       ApiClient.employeeProfile.lastName;

            TextAlign = HorizontalAlignment.Center;
            BorderThickness = 2;
            CustomBorderColor = Color.FromArgb(31, 28, 47);
            BorderColor = Color.FromArgb(31, 28, 47);
            Size = new Size(402, 105);
            TabIndex = 22;
            Font = new Font("Segoe UI", 14, FontStyle.Bold);
            ForeColor = Color.White;
        }

        private Guna2ComboBox ComboBoxProperties(string poriton)
        {
            Guna2ComboBox cb = new Guna2ComboBox();

            cb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            cb.ForeColor = Color.White;
            cb.TabIndex = 18;
            cb.AutoRoundedCorners = true;
            cb.Animated = true;
            cb.FillColor = Color.Black;
            cb.BorderThickness = 1;
            cb.BorderColor = Color.White;
            cb.HoverState.FillColor = Color.FromArgb(38, 38, 38);
            cb.HoverState.ForeColor = Color.White;
            cb.Items.Add(poriton);
            cb.TextAlign = HorizontalAlignment.Center;
            cb.StartIndex = 0;
            cb.Location = new Point(10, 55);
            cb.Size = new Size(109, 36);
            cb.SelectedIndexChanged += Cb_SelectedIndexChanged;

            return cb;
        }
        private Guna2ComboBox ComboBoxProperties()
        {
            Guna2ComboBox cb = new Guna2ComboBox();

            cb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            cb.ForeColor = Color.White;
            cb.TabIndex = 18;
            cb.AutoRoundedCorners = true;
            cb.Animated = true;
            cb.FillColor = Color.Black;
            cb.BorderThickness = 1;
            cb.BorderColor = Color.White;
            cb.HoverState.FillColor = Color.FromArgb(38, 38, 38);
            cb.HoverState.ForeColor = Color.White;
            foodItem_PortionList.ForEach(x => cb.Items.Add(x.portion.name));
            cb.TextAlign = HorizontalAlignment.Center;
            cb.StartIndex = 0;
            cb.Location = new Point(10, 55);
            cb.Size = new Size(109, 36);
            cb.SelectedIndexChanged += Cb_SelectedIndexChanged;

            return cb;
        }

        // Portion'a göre Fiyat hesapla
        private void Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.foodItem_Portion = foodItem_PortionList.Find( foodItem_Portion => 
                        foodItem_Portion.portion.name.Equals(((Guna2ComboBox)sender).Text));

            this.label.Text = foodItem_Portion.unitPrice * float.Parse(this.numericUpDown.Value.ToString()) + " TL";
            float toplam = 0.0f;
            itemsForm.billCardList
                .ForEach(b => toplam += float.Parse(b.label.Text.Split(' ')[0]));
            itemsForm.lblTotalPrice.Text = toplam.ToString();

            
            this.numericUpDown.Maximum = Convert.ToInt32(Math.Floor(foodItem_Portion.foodItem.quantity / foodItem_Portion.portion.calculate));
        }
       
        // Adede göre fiyat hesaplama
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
            Guna2NumericUpDown n = (Guna2NumericUpDown)sender;   
            this.label.Text = (this.foodItem_Portion.unitPrice * float.Parse(n.Value.ToString())).ToString() + " TL";
            float toplam = 0.0f;
            itemsForm.billCardList
                .ForEach(b => toplam += float.Parse(b.label.Text.Split(' ')[0]));
            itemsForm.lblTotalPrice.Text = toplam.ToString();

        }

 
        private Guna2NumericUpDown NumericUpDownProperties()
        {
            Guna2NumericUpDown numeric = new Guna2NumericUpDown();

            numeric.FillColor = Color.Black;
            numeric.ForeColor = Color.White;
            numeric.UpDownButtonFillColor = Color.Black;
            numeric.UpDownButtonForeColor = Color.White;
            numeric.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            numeric.BorderRadius = 4;
            numeric.Minimum = 1;
            numeric.Maximum = Convert.ToInt32(foodItem_Portion.foodItem.quantity / foodItem_Portion.portion.calculate);
            numeric.DecimalPlaces = 1;
            numeric.Location = new Point(144, 56);
            numeric.Size = new Size(68, 34);
            
            return numeric;
        }


        private Label LabelProperties()
        {
            Label lbl = new Label();

            lbl.Font = new Font("Virdana", 11);
            lbl.ForeColor = Color.White; 
            lbl.Location = new Point(225, 65);
            lbl.Size = new Size(80, 18);
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            return lbl;
        }

        

        private Guna2Button DeleteButtonProperties()
        {
            Guna2Button btn = new Guna2Button();

            btn.Animated = true;
            btn.BackColor = Color.Transparent;
            btn.FillColor = Color.Transparent;
            btn.BorderRadius = 6;
            btn.Text = "";
            btn.Size = new Size(45, 40);
            btn.ImageSize = new Size(40, 40);
            btn.Location = new Point(350, 53);
            btn.Image = Properties.Resources.delete_before;
            btn.HoverState.Image = Properties.Resources.delete_after;
            btn.HoverState.FillColor = Color.FromArgb(252, 100, 126);
            btn.MouseClick += DeleteButton_MouseClick;

            return btn;
        }
        private void DeleteButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox.Enabled == true)
            {
                float price = float.Parse(itemsForm.lblTotalPrice.Text);
                float deleted = float.Parse(this.label.Text.Split(' ')[0]);

                itemsForm.billsFlowLayoutPanel.Controls.Remove(this);
                itemsForm.billCardList.Remove(this);
                itemsForm.lblTotalPrice.Text = string.Format("{0:0.00}", price - deleted);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istiyor musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes.Equals(dialogResult))
                {
                    long result = jsonService.DeleteFoodItemOrder(this.foodItem_OrderId);

                    if (result != -1)
                    {
                        float price = float.Parse(itemsForm.lblTotalPrice.Text);
                        float deleted = float.Parse(this.label.Text.Split(' ')[0]);
                        itemsForm.billsFlowLayoutPanel.Controls.Remove(this);
                        itemsForm.billCardList.Remove(this);
                        itemsForm.lblTotalPrice.Text = string.Format("{0:0.00}", price - deleted);

                        itemsForm.GetFoodItemList();
                    }
                    else
                        MessageBox.Show("Bir Hata oluştu !!" + result);
                }
                return;
            }

        }
        private Guna2Button UpdateButtonProperties()
        {
            Guna2Button updateButton = new Guna2Button();

            updateButton.Animated = true;
            updateButton.BackColor = Color.Transparent;
            updateButton.FillColor = Color.Transparent;
            updateButton.BorderRadius = 6;
            updateButton.Text = "";
            updateButton.Size = new Size(45, 40);
            updateButton.Location = new Point(304, 53);
            updateButton.ImageSize = new Size(30, 30);
            updateButton.Image = Properties.Resources.update_before;
            updateButton.HoverState.Image = Properties.Resources.update_after;
            updateButton.HoverState.FillColor = Color.FromArgb(252, 100, 126);
            updateButton.MouseClick += UpdateButton_MouseClick; ;

            return updateButton;
        }

        private void UpdateButton_MouseClick(object sender, MouseEventArgs e)
        {
            updateButton.Visible = false;
            deleteButton.Enabled = false;
            confirmUpdateButton.Visible = true;
            cancelUpdateButton.Visible = true;

            foodItem_PortionList =  jsonService.GetPortionListByFoodItemId(foodItem_Portion.foodItem.id);

            comboBox.Enabled = true;

            string portion = comboBox.Text;

            comboBox.Items.Clear(); 

            foodItem_PortionList.ForEach(foodItmePortion => comboBox.Items.Add(foodItmePortion.portion.name));

            comboBox.StartIndex = foodItem_PortionList.FindIndex(foodITemPortion => foodITemPortion.portion.name.Equals(portion));

            this.foodItem_Portion = foodItem_PortionList[comboBox.StartIndex];
            comboBox.SelectedValueChanged += Cb_SelectedIndexChanged;
            
            numericUpDown.Enabled = true;       
            this.numericUpDown.Maximum = Convert.ToInt32(this.qunatity) + Convert.ToInt32(foodItem_Portion.foodItem.quantity); ;
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;

        }


        private Guna2Button ConfirmUpdateButtonProperties()
        {
            Guna2Button confirm = new Guna2Button();

            confirm.Animated = true;
            confirm.BackColor = Color.Transparent;
            confirm.FillColor = Color.Transparent;
            confirm.BorderRadius = 6;
            confirm.Text = "";
            confirm.Size = new Size(30, 30);
            confirm.Visible = false;
            confirm.Location = new Point(312, 42);
            confirm.ImageSize = new Size(25, 25);
            confirm.ImageAlign = HorizontalAlignment.Center;
            confirm.Image = Properties.Resources.confirm_before;
            confirm.HoverState.Image = Properties.Resources.confirm_after;
            confirm.HoverState.FillColor = Color.Transparent;
            confirm.MouseClick += Confirm_MouseClick;

            return confirm;
        }

        private void Confirm_MouseClick(object sender, MouseEventArgs e)
        {
            FoodOrderContext foodOrderContext = new FoodOrderContext(
                this.foodItem_Portion.id,
                float.Parse(label.Text.Split(' ')[0]),
                float.Parse(this.numericUpDown.Value.ToString())
                );

            long result = jsonService.UpdateFoodItemOrder(foodOrderContext, this.foodItem_OrderId);

            if (result.Equals(foodItem_OrderId))
            {
                this.qunatity = float.Parse(this.numericUpDown.Value.ToString());
                MessageBox.Show("Güncelleme işlemi tamamlandı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox.Enabled = false;
                numericUpDown.Enabled = false;
                confirmUpdateButton.Visible = false;
                cancelUpdateButton.Visible = false;
                updateButton.Visible = true;
                deleteButton.Enabled = true;
                itemsForm.GetFoodItemList();
            }
            else
                MessageBox.Show("Hata Oluştu");
        }

        private Guna2Button CancelUpdateButtonProperties()
        {
            Guna2Button cancel = new Guna2Button();

            cancel.Animated = true;
            cancel.BackColor = Color.Transparent;
            cancel.FillColor = Color.Transparent;
            cancel.BorderRadius = 6;
            cancel.Text = "";
            cancel.Size = new Size(30, 30);
            cancel.Visible = false;
            cancel.Location = new Point(312, 72);
            cancel.ImageSize = new Size(25, 25);
            cancel.ImageAlign = HorizontalAlignment.Center;
            cancel.Image = Properties.Resources.cancel_before;
            cancel.HoverState.Image = Properties.Resources.cancel_after;
            cancel.HoverState.FillColor = Color.Transparent;
            cancel.MouseClick += Cancel_MouseClick;

            return cancel;
        }

        private void Cancel_MouseClick(object sender, MouseEventArgs e)
        {
            confirmUpdateButton.Visible = false;
            cancelUpdateButton.Visible = false;
            updateButton.Visible = true;
            comboBox.Text = foodItem_Portion.portion.name;
            numericUpDown.Value = Convert.ToInt32(this.qunatity);
            label.Text = price + " TL";
            comboBox.Enabled = false;
            numericUpDown.Enabled = false;
            deleteButton.Enabled = true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BillCard
            // 
            this.ShadowDecoration.Parent = this;
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.ResumeLayout(false);

        }
    }
}
