using System;
using System.Collections.Generic;
using System.Windows.Forms;
using deneme_design.Model;
using deneme_design.Forms.AdminForms;
using deneme_design.RestClient;

namespace deneme_design.Controls
{
    public partial class ItemControl : UserControl
    {
        List<FoodItem_Portion> foodItem_PortionsList = null;
        FoodItemsPanel foodItemsPanel = null;
        FoodItem foodItem = null;
        AdminForm adminForm = null;
        JsonService jsonService = null;

        public ItemControl()
        {
            InitializeComponent();
        }
        public ItemControl(AdminForm adminForm, FoodItemsPanel foodItemsPanel, FoodItem foodItem)
        {
            InitializeComponent();
            this.foodItemsPanel = foodItemsPanel;
            this.foodItem = foodItem;
            this.adminForm = adminForm;
            jsonService = new JsonService();
            lblitemName.Text = foodItem.itemName;
            lblPriceItem.Text =  " TL";
            lblQuantityItem.Text = foodItem.quantity.ToString();
        }

        public ItemControl(AdminForm adminForm, FoodItemsPanel foodItemsPanel, List<FoodItem_Portion> foodItem_Portions)
        {
            InitializeComponent();
            this.foodItemsPanel = foodItemsPanel;
            this.adminForm = adminForm;
            this.foodItem_PortionsList = foodItem_Portions;
            jsonService = new JsonService();
            lblitemName.Text = foodItem_PortionsList[0].foodItem.itemName;
            lblPriceItem.Text = foodItem_PortionsList[0].unitPrice.ToString() + " TL";
            lblQuantityItem.Text = foodItem_PortionsList[0].foodItem.quantity.ToString();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if(foodItem == null)
                adminForm.openChildForm(new FoodItemUpdate(adminForm, this.foodItem_PortionsList));
            else
                adminForm.openChildForm(new FoodItemUpdate(adminForm, this.foodItem));
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string itemName = string.Empty;
            if (this.foodItem != null)
                itemName = foodItem.itemName;
            else
                itemName = foodItem_PortionsList[0].foodItem.itemName;


            DialogResult result = MessageBox.Show("\"" + itemName + "\" ürüne ait tüm bilgileri silenecek\nDevam Etmek istiyormusunuz?",
                "Uyari", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes.Equals(result))
            {
                long id;
                if (foodItem == null)
                    id = foodItem_PortionsList[0].foodItem.id;
                else
                    id = foodItem.id;

                long deletedId = jsonService.DeleteFoodItem(id);

                if (deletedId == id)
                { 
                    foodItemsPanel.flowLayoutPanel.Controls.Remove(this);
                    MessageBox.Show("Silme İşlemi tamamlandı");
                }
            } 
        }
    }
}
