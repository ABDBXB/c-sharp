using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using deneme_design.Model;
using deneme_design.Forms.AdminForms.FoodItemUpdateForms;
using deneme_design.RestClient;

namespace deneme_design.Forms.AdminForms.UserControls
{
    public partial class PortionDetailsControl : UserControl
    {
        public Guna2TextBox txtPrice { get; set; }
        public Guna2TextBox txtRatio { get; set; }
        public Guna2TextBox txtCustomQuantity { get; set; }
        public Label lblQuantity { get; set; }
        public Guna2TextBox txtPortion { get; set; }
        public float ratio;
        JsonService jsonService = null;
        UpdatePortions updatePortionsForm;

        FoodItem_Portion foodItem_Portion;
        public PortionDetailsControl(FoodItem_Portion foodItem_Portion, UpdatePortions updatePortions)
        {
            InitializeComponent();
            this.foodItem_Portion = foodItem_Portion;
            this.updatePortionsForm = updatePortions;
            lblQuantity = lblQuantity1;
            jsonService = new JsonService();
            getDetails();
            TextBoxEvent_Intializer();
        }

        public PortionDetailsControl()
        {
            InitializeComponent();
            txtPrice = txtPrice1;
            txtPortion = txtPortion1;
            txtCustomQuantity = txtCustomQuantity1;
            txtRatio = txtRatio1;
            lblQuantity = lblQuantity1;
        }

        public PortionDetailsControl(UpdatePortions updatePortions)
        {
            InitializeComponent();

            this.updatePortionsForm = updatePortions;
            txtPrice = txtPrice1;
            txtPortion = txtPortion1;
            txtCustomQuantity = txtCustomQuantity1;
            txtRatio = txtRatio1;
            lblQuantity = lblQuantity1;
            TextBoxEvent_Intializer();
        }

        private void getDetails()
        {
            txtPortion1.Text = foodItem_Portion.portion.name;
            ratio = foodItem_Portion.portion.calculate;
            txtRatio1.Text = string.Format("{0:0.00}",foodItem_Portion.portion.calculate);
            lblQuantity1.Text = Math.Floor(foodItem_Portion.foodItem.quantity).ToString();
            txtPrice1.Text = foodItem_Portion.unitPrice.ToString();
            txtCustomQuantity1.Text = Math.Floor(foodItem_Portion.foodItem.quantity / foodItem_Portion.portion.calculate).ToString();
            txtPrice = txtPrice1;
            txtPortion = txtPortion1;
            txtCustomQuantity = txtCustomQuantity1;
            txtRatio = txtRatio1;
            lblQuantity = lblQuantity1;
        }
        private void TextBoxEvent_Intializer()
        {
            for (int i = 0; i < 3; i++)
            {
                txtCustomQuantity1.KeyUp += CalculateRatio;
                txtRatio1.KeyUp += CalculateCustomQuantity;
                txtRatio1.KeyPress += ApplyNumbersMask;
                txtCustomQuantity1.KeyPress += ApplyNumbersMask;
                txtPrice1.KeyPress += ApplyNumbersMask;
            }
        }
        private void CalculateRatio(object sender, KeyEventArgs e)
        { 
            if (txtCustomQuantity1.Text != "" && txtCustomQuantity1.Text != "0")
            {
                string customQuantity = txtCustomQuantity1.Text.Replace('.', ',');
                ratio = float.Parse(lblQuantity.Text) / float.Parse(customQuantity);
                txtRatio1.Text = string.Format("{0:0.0}", ratio);
            }
        }
        private void CalculateCustomQuantity(object sender, KeyEventArgs e)
        {
            CalculateQuantity();
        }
        private void CalculateQuantity()
        {
            if (txtRatio1.Text != "" && txtRatio1.Text != "0")
            {
                string ratio = txtRatio1.Text.Replace('.', ',');
                txtCustomQuantity1.Text = string.Format("{0:0.0}", float.Parse(lblQuantity.Text) / float.Parse(ratio));
            }
        }
        private void ApplyNumbersMask(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }
            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as Guna2TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
        private void lblQuantity1_TextChanged(object sender, EventArgs e)
        {
            CalculateQuantity();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(foodItem_Portion != null)
            {
                long id = jsonService.DeleteFoodItemPortion(this.foodItem_Portion.id);

                if (id == this.foodItem_Portion.id)
                {
                    MessageBox.Show("Deleted Successfully");
                }
            }
            updatePortionsForm.flowLayoutPanel.Controls.Remove(this);
            updatePortionsForm.PortionDetails.Remove(this);
        }
    }
}
