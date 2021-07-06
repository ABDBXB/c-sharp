using deneme_design.Context;
using deneme_design.Forms.AdminForms.UserControls;
using deneme_design.Model;
using deneme_design.RestClient;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms.FoodItemUpdateForms
{
    public partial class UpdatePortions : Form
    {
        List<FoodItem_Portion> foodItem_PortionList = null;
        List<FoodItem_PortionContext> updatedPortionList = null;
        FoodItem foodItem = null;
        JsonService jsonService = null;
        public List<PortionDetailsControl> PortionDetails = null;
        public FlowLayoutPanel flowLayoutPanel = null;

        public UpdatePortions(List<FoodItem_Portion> foodItem_PortionList)
        {
            InitializeComponent();
            this.foodItem_PortionList = foodItem_PortionList;
            jsonService = new JsonService();
            updatedPortionList = new List<FoodItem_PortionContext>();
            PortionDetails = new List<PortionDetailsControl>();
            this.flowLayoutPanel = flowLayoutPanel1;
        }

        public UpdatePortions(FoodItem foodItem)
        {
            InitializeComponent();
            this.foodItem = foodItem;
            jsonService = new JsonService();
            updatedPortionList = new List<FoodItem_PortionContext>();
            PortionDetails = new List<PortionDetailsControl>();
            this.flowLayoutPanel = flowLayoutPanel1;
        }

        private  void UpdatePortions_Load(object sender, EventArgs e)
        {
             GetPortionDetails();  
        }
        
        private void GetPortionDetails()
        { 
            if(foodItem_PortionList != null)
            {
                txtQuantity.Text = Math.Floor(foodItem_PortionList[0].foodItem.quantity).ToString();
                for (int i = 0; i < foodItem_PortionList.Count; i++)
                {
                    PortionDetailsControl k = new PortionDetailsControl(foodItem_PortionList[i], this);
                    PortionDetails.Add(k);
                    flowLayoutPanel1.Controls.Add(k);

                }
            } 
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQuantity.Text != "")
                PortionDetails.ForEach(p => p.lblQuantity.Text = txtQuantity.Text);
            else
                lblEmptyQunatityWarnin.Visible = true;
        }

        private void btnSaveNewItem_Click(object sender, EventArgs e)
        {
            updatedPortionList.Clear();
            PortionDetails.ForEach(portionDetail =>
            {
                if(portionDetail.txtPortion.Text.Length <= 0 ||
                     portionDetail.txtRatio.Text.Length <= 0 ||
                     portionDetail.txtCustomQuantity.Text.Length <= 0 ||
                     portionDetail.txtPrice.Text.Length <= 0 ||
                     txtQuantity.Text.Length <= 0)
                {
                    MessageBox.Show("Eksik bilig");
                    return;
                }
            });

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                FoodItem_PortionContext context = new FoodItem_PortionContext();

                if(foodItem_PortionList != null)
                {
                    if (i < foodItem_PortionList.Count)
                    {
                        context.id = foodItem_PortionList[i].id;
                        context.foodItemId = foodItem_PortionList[i].foodItem.id;
                        context.portionId = foodItem_PortionList[i].portion.id;
                    }
                    else
                    {
                        context.id = 0;
                        context.foodItemId = foodItem_PortionList[0].foodItem.id;
                        context.portionId = foodItem_PortionList[0].portion.id;
                    }
                    context.portionName = PortionDetails[i].txtPortion.Text;
                    context.quantity = float.Parse(txtQuantity.Text);
                    context.ratio = PortionDetails[i].ratio;
                    context.price = float.Parse(PortionDetails[i].txtPrice.Text);

                    updatedPortionList.Add(context);
                }
                else
                {
                    context.id = 0;
                    context.foodItemId = foodItem.id;
                    context.portionId = 0;
                    context.portionName = PortionDetails[i].txtPortion.Text;
                    context.quantity = float.Parse(txtQuantity.Text);
                    context.ratio = PortionDetails[i].ratio;
                    context.price = float.Parse(PortionDetails[i].txtPrice.Text);

                    updatedPortionList.Add(context);
                }
            }

            List<long> idList = jsonService.UpdateFoodItemPortions(updatedPortionList);

            if (idList.Count == updatedPortionList.Count)
                MessageBox.Show("Guncelleme tamalandi");
            else
                MessageBox.Show("HATA"); 
        }

        private void btnAddNewPortion_Click(object sender, EventArgs e)
        {
            PortionDetailsControl control = new PortionDetailsControl(this);
            try
            {
                control.lblQuantity.Text = Math.Floor(foodItem_PortionList[0].foodItem.quantity).ToString();
            }
            catch (Exception)
            { }

            PortionDetails.Add(control);
            flowLayoutPanel1.Controls.Add(control);
        }
    }
}
