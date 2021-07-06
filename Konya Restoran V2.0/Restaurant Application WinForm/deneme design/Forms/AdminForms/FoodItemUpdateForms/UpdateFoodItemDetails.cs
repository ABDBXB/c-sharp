using deneme_design.Context;
using deneme_design.Model;
using deneme_design.RestClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms.FoodItemUpdateForms
{
    public partial class UpdateFoodItemDetails : Form
    {
        FoodItem foodItem = null;
        JsonService jsonService = null;
        List<CategoryContext> categoryContextList = null;

        public UpdateFoodItemDetails(FoodItem foodItem)
        {
            InitializeComponent();
            this.foodItem = foodItem;
            jsonService = new JsonService();
        }

        private void UpdateFoodItemDetails_Load(object sender, EventArgs e)
        {
            txtItemName.Text = foodItem.itemName;
            categoryContextList = jsonService.GetCategoryContexts();
            categoryContextList.ForEach(c => cbCategory.Items.Add(c.name));
            cbCategory.Text = jsonService.GetCategoryByItemId(foodItem.id);
        }

        private void btnSaveNewItem_Click(object sender, EventArgs e)
        {
            ItemContext itemContext = new ItemContext();
            itemContext.id = foodItem.id;
            itemContext.categoryId = categoryContextList.Find(c => c.name == cbCategory.Text).id;
            itemContext.itemName = txtItemName.Text;

            long id = jsonService.UpdateFoodItemDetails(itemContext);
            if (id == itemContext.id)
            {
                MessageBox.Show("Güncelleme işlemi tamamlandı");
            }
        }
    }
}
