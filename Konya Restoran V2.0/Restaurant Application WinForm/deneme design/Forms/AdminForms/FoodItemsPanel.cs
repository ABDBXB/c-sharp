using deneme_design.Controls;
using deneme_design.Model;
using deneme_design.RestClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms
{
    public partial class FoodItemsPanel : Form
    {
        AdminForm adminForm = null;
        JsonService jsonService = null;
        public FlowLayoutPanel flowLayoutPanel = null;
        public FoodItemsPanel(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            jsonService = new JsonService();
            flowLayoutPanel = flowLayoutPanel1;
        }
        
        private void MenuUpdate_Load(object sender, EventArgs e)
        {
            GetAllFoodItems();
        }
        private void GetAllFoodItems()
        {
            flowLayoutPanel1.Controls.Clear();
            jsonService.GetItemList().ForEach(food =>
            {
                List<FoodItem_Portion> foodItem_PortionsList = jsonService.GetPortionListByFoodItemId(food.id);

                ItemControl itemControl = null;
                if (foodItem_PortionsList.Count > 0)
                    itemControl = new ItemControl(adminForm, this, foodItem_PortionsList);
                else
                    itemControl = new ItemControl(adminForm, this, food);
                flowLayoutPanel1.Controls.Add(itemControl);
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            adminForm.openChildForm(new FoodItemAdd(adminForm));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if(txtItemName.Text.Length == 0)
            {
                GetAllFoodItems();
                return;
            }
            List<FoodItem> foodItemList = jsonService.GetItemListByName(txtItemName.Text);
            if (foodItemList == null)
            {
                flowLayoutPanel1.Controls.Clear();
                return;
            }
            foodItemList.ForEach(food =>
            {
                List<FoodItem_Portion> foodItem_PortionsList = jsonService.GetPortionListByFoodItemId(food.id);

                ItemControl itemControl = null;
                if (foodItem_PortionsList.Count > 0)
                    itemControl = new ItemControl(adminForm, this, foodItem_PortionsList);
                else
                    itemControl = new ItemControl(adminForm, this, food);

                flowLayoutPanel1.Controls.Add(itemControl);
            });
        }
    }
}
