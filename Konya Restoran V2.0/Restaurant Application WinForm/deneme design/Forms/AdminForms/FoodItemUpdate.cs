using deneme_design.Forms.AdminForms.FoodItemUpdateForms;
using deneme_design.Forms.AdminForms.UserControls;
using deneme_design.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms
{
    public partial class FoodItemUpdate : Form
    {
        AdminForm adminForm = null;
        List<FoodItem_Portion> foodItem_PortionList = null;
        Form activeForm = null;
        FoodItem foodItem = null;
        Label lblHeader = null;

        public FoodItemUpdate(AdminForm adminForm, List<FoodItem_Portion> foodItem_PortionList)
        {
            InitializeComponent();
            this.foodItem_PortionList = foodItem_PortionList;
            this.adminForm = adminForm;
            lblHeader = lblHead;
            lblHeader.Text = foodItem_PortionList[0].foodItem.itemName;
        }

        public FoodItemUpdate(AdminForm adminForm, FoodItem foodItem)
        {
            InitializeComponent();
            this.foodItem = foodItem;
            this.adminForm = adminForm;
            lblHeader = lblHead;
            lblHeader.Text = foodItem.itemName;
        }

        public  void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            UpdateChildFormPanel.Controls.Add(childForm);
            UpdateChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private  void btnUpdateImage_Click(object sender, EventArgs e)
        {
            getFoodItemImageDetailsDetails();
        }

        private  void btnUpdateFoodItemDetails_Click(object sender, EventArgs e)
        {
            
            if (foodItem_PortionList != null)
                openChildForm(new UpdateFoodItemDetails(foodItem_PortionList[0].foodItem));
            else
                openChildForm(new UpdateFoodItemDetails(foodItem));
        }

        private  void guna2Button3_Click(object sender, EventArgs e)
        {
            if (foodItem_PortionList != null)
                openChildForm(new UpdatePortions(foodItem_PortionList));
            else
                openChildForm(new UpdatePortions(foodItem));

        }

        private void FoodItemUpdate_Load(object sender, EventArgs e)
        {
            getFoodItemImageDetailsDetails();
        }

        private void getFoodItemImageDetailsDetails()
        {
            if (foodItem_PortionList != null)
                openChildForm(new UpdateImage(foodItem_PortionList[0].foodItem));
            else
                openChildForm(new UpdateImage(foodItem));
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            adminForm.openChildForm(new FoodItemsPanel(adminForm));
            this.Close();
        }
    }
}
