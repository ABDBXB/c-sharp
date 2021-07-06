using deneme_design.Context;
using deneme_design.Model;
using deneme_design.RestClient;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms
{
    public partial class FoodItemAdd : Form
    {
        AdminForm adminForm;
        JsonService jsonService;
        List<Portion> allPoritonsList;
        List<Category> categoryList;
        List<PortionContext> portionContextList;
        List<FoodItem_Portion> foodItem_PortionList;

        List<Guna2Panel> pnlList;
        List<Guna2TextBox> txtPriceList;
        List<Guna2TextBox> txtRatioList;
        List<Guna2TextBox> txtCustomQuantityList;
        List<Label> lblQuantityList;
        List<Label> lblTotalList;
        List<Guna2TextBox> txtPortionList;
        List<Guna2ToggleSwitch> switcheList;
        List<Guna2RadioButton> radioButtonList;
        long categoryId { get; set; }
        
        public FoodItemAdd(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            jsonService = new JsonService();
            portionContextList = new List<PortionContext>();
            Initialize();
        }

        public FoodItemAdd(AdminForm adminForm, List<FoodItem_Portion> foodItem_PortionList)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            this.foodItem_PortionList = foodItem_PortionList;
            jsonService = new JsonService();
            portionContextList = new List<PortionContext>();
            Initialize();
            GetFoodItem_PortionsDetails();   
        }

        private void GetFoodItem_PortionsDetails()
        {
            txtItemName.Text = foodItem_PortionList[0].foodItem.itemName;
            txtQuantity.Text = foodItem_PortionList[0].foodItem.quantity.ToString();
            try
            {
                MemoryStream ms = new MemoryStream(foodItem_PortionList[0].foodItem.itemImages.picture);
                Image.FromStream(ms);
                pbFoodItemImage.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                pbFoodItemImage.Image = Properties.Resources.food;
            }

            radioButtonList.ForEach(rb => rb.Visible = false);
            rbCustom.Visible = true;
            rbCustom.Checked = true;
            //btnUpdate.Visible = true;
            btnSaveCustomPortions.Visible = false;
            btnClearPanels.Visible = false;
            btnSaveNewItem.Visible = false;

            for (int i = 0; i < foodItem_PortionList.Count; i++)
            {

                txtPortionList[i].Text = foodItem_PortionList[i].portion.name;
                lblQuantityList[i].Text = txtQuantity.Text;
                txtRatioList[i].Text = foodItem_PortionList[i].portion.calculate.ToString();
                txtPriceList[i].Text = foodItem_PortionList[i].unitPrice.ToString();
                txtCustomQuantityList[i].Text =  
                    Math.Floor(float.Parse(txtQuantity.Text) / foodItem_PortionList[i].portion.calculate).ToString();
            }
        }

        private void Initialize()
        {
            txtPortionList = new List<Guna2TextBox>();
            txtPortionList.Add(txtPortion1);
            txtPortionList.Add(txtPortion2);
            txtPortionList.Add(txtPortion3);

            txtRatioList = new List<Guna2TextBox>();
            txtRatioList.Add(txtRatio1);
            txtRatioList.Add(txtRatio2);
            txtRatioList.Add(txtRatio3);

            txtPriceList = new List<Guna2TextBox>();
            txtPriceList.Add(txtPrice1);
            txtPriceList.Add(txtPrice2);
            txtPriceList.Add(txtPrice3);

            pnlList = new List<Guna2Panel>();
            pnlList.Add(pnlPortion1);
            pnlList.Add(pnlPortion2);
            pnlList.Add(pnlPortion3);
            pnlList.Add(pnlHeaders);

            lblQuantityList = new List<Label>();
            lblQuantityList.Add(lblQuantity1);
            lblQuantityList.Add(lblQuantity2);
            lblQuantityList.Add(lblQuantity3);

            lblTotalList = new List<Label>();
            lblTotalList.Add(lblTotal1);
            lblTotalList.Add(lblTotal2);
            lblTotalList.Add(lblTotal3);

            switcheList = new List<Guna2ToggleSwitch>();
            switcheList.Add(toggleSwitch1);
            switcheList.Add(toggleSwitch2);
            switcheList.Add(toggleSwitch3);

            txtCustomQuantityList = new List<Guna2TextBox>();
            txtCustomQuantityList.Add(txtCustumQuantity1);
            txtCustomQuantityList.Add(txtCustumQuantity2);
            txtCustomQuantityList.Add(txtCustumQuantity3);

            radioButtonList = new List<Guna2RadioButton>();
            radioButtonList.Add(rbBir);
            radioButtonList.Add(rbYBB);
            radioButtonList.Add(rbKOB);
            radioButtonList.Add(rbCustom);

            allPoritonsList = new List<Portion>();
            allPoritonsList = jsonService.GetPortionList();

        }
        private void rbBir_CheckedChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals(""))
            {
                rbBir.Checked = false;
                lblEmptyQunatityWarnin.Visible = true;
                return;
            }    
            Clear();
            
            pnlHeaders.Visible = true;
            pnlPortion1.Visible = true;
            txtPrice1.Visible = true;
            txtPrice1.Enabled = true;
            txtRatio1.Enabled = false;
            lblTotal1.Visible = true;
            lblQuantity1.Text = txtQuantity.Text;
            lblTotal1.Text = txtQuantity.Text;
            txtPortion1.Text = "Bir";
            txtRatio1.Text = "1";

            long portionId;
            try
            {
                portionId = allPoritonsList.Find(portion =>
                portion.Equals(new Portion(txtPortion1.Text, float.Parse(txtRatio1.Text)))).id;
            }
            catch (Exception)
            {
                MessageBox.Show("Bu seçenek Aktif değil\nYENİ EKLE Kısmından ekleyebilirsiniz :)" );
                return;
            }

            PortionContext portionContext = new PortionContext(
                portionId, 
                txtPortion1.Text,
                float.Parse(txtRatio1.Text), 
                float.Parse(txtPrice1.Text)
                );
            portionContextList.Add(portionContext);
        }

        private void rbYBB_CheckedChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals(""))
            {
                rbYBB.Checked = false;
                lblEmptyQunatityWarnin.Visible = true;
                return;
            }
            Clear();

            txtPortion1.Text = (rbKOB.Checked) ? "Küçük" : "Yarım";
            txtPortion2.Text = (rbKOB.Checked) ? "Orta" : "Bir";
            txtPortion3.Text = (rbKOB.Checked) ? "Büyük" : "Bir Buçuk";

            txtRatio1.Text = "0,5";
            txtRatio2.Text = "1,0";
            txtRatio3.Text = "1,5";
            
            for (int i = 0; i < pnlList.Count; i++)
            {
                if(i == 3)
                {
                    pnlList[i].Visible = true;
                    break;
                }
                pnlList[i].Visible = true;
                txtRatioList[i].Enabled = false;
                txtPriceList[i].Visible = true;
                lblQuantityList[i].Text = txtQuantity.Text;
                txtPriceList[i].Enabled = true;
                lblTotalList[i].Visible = true;
            }

            lblTotal1.Text = Math.Floor(float.Parse(txtQuantity.Text) / 0.5f).ToString();
            lblTotal2.Text = Math.Floor(float.Parse(txtQuantity.Text) / 1.0f).ToString();
            lblTotal3.Text = Math.Floor(float.Parse(txtQuantity.Text) / 1.5f).ToString();

            PortionContext[] portions = new PortionContext[3];

            for (int i = 0; i < portions.Length; i++)
            {
                long portionId = 0;
                try
                {
                    portionId = allPoritonsList.Find(portion =>
                            portion.Equals(new Portion(txtPortionList[i].Text, float.Parse(txtRatioList[i].Text)))).id;
                }
                catch (Exception) {}

                portions[i] = new PortionContext(
                    portionId,
                    txtPortionList[i].Text,
                    float.Parse(txtRatioList[i].Text),
                    float.Parse(txtPriceList[i].Text)
                    );
                portionContextList.Add(portions[i]);
            }
        }

        
        private void rbKOB_CheckedChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals(""))
            {
                rbKOB.Checked = false;
                lblEmptyQunatityWarnin.Visible = true;
                return;
            }
            Clear();
            rbYBB_CheckedChanged(rbKOB, null);
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Equals(""))
            {
                rbCustom.Checked = false;
                lblEmptyQunatityWarnin.Visible = true;
                return;
            }

            Clear();
            for (int i = 0; i < pnlList.Count; i++)
            {
                if(i == 3)
                {
                    pnlList[i].Visible = true;
                    break;
                }
                pnlList[i].Visible = true;
                txtPriceList[i].Visible = true;
                switcheList[i].Visible = true;
                lblQuantityList[i].Text = (!txtQuantity.Text.Equals("")) ? txtQuantity.Text : "Girmediniz";
                txtCustomQuantityList[i].Visible = true;
                btnSaveCustomPortions.Visible = true;
            }
        }
        
        private void Clear()
        {
            portionContextList.Clear();
            for (int i = 0; i < pnlList.Count; i++)
            {
                if(i == 3)
                {
                    pnlList[i].Visible = false;
                    pnlList[i].Enabled = false;
                    break;
                }
                pnlList[i].Visible = false;
                pnlList[i].Enabled = false;

                txtPortionList[i].Text = "";
                txtPortionList[i].Enabled = false;

                txtPriceList[i].Visible = false;
                txtPriceList[i].Enabled = false;

                switcheList[i].Visible = false;

                if (switcheList[i].Checked)
                    switcheList[i].Checked = false;
                lblQuantityList[i].Text = "";

                txtRatioList[i].Text = "";
                lblTotalList[i].Text = "0";

                txtCustomQuantityList[i].Visible = false;
                txtCustomQuantityList[i].Enabled = false;
                lblTotalList[i].Visible = false;

            }
            btnSaveCustomPortions.Visible = false;
        }

        private void toggleSwitchs_CheckedChanged(object sender, EventArgs e)
        {
            int i = switcheList.IndexOf((sender as Guna2ToggleSwitch));
            pnlList[i].Enabled = !txtPriceList[i].Enabled;
            txtPriceList[i].Enabled = pnlList[i].Enabled;
            txtPortionList[i].Enabled = true;
            txtRatioList[i].Enabled = true;
            txtCustomQuantityList[i].Enabled = true;
            if(txtQuantity.Text.Length == 0)
                txtCustomQuantityList[i].Text = txtQuantity.Text;
            lblQuantityList[i].Text = (!txtQuantity.Text.Equals("")) ? txtQuantity.Text : "Girmediniz";
            if(txtRatioList[i].Text.Length == 0)
                txtRatioList[i].Text = "1";
        }

        private void AddCategoriesToComboBox()
        {
            categoryList =  jsonService.GetCategoriesList();
            categoryList.ForEach(x => cbCategory.Items.Add(x.name));
            cbCategory.Text = cbCategory.Items[0].ToString();
            categoryId = categoryList[0].id;
        }


        private async void btnSaveNewItem_Click(object sender, EventArgs e)
        {
            bool emptyPrice = false;
            if (!rbCustom.Checked)
            {
                try
                {
                    portionContextList.ForEach(portion =>
                portion.unitPrice = float.Parse(txtPriceList[portionContextList.IndexOf(portion)].Text));
                }
                catch (Exception)
                {
                    emptyPrice = true;
                } 
            }
            
            bool ready = (txtItemName.Text.Length > 0 
                && txtQuantity.Text.Length > 0 
                && portionContextList.Count > 0 && !emptyPrice);

            if (!ready )
            {
                MessageBox.Show("Girdiğiniz Bilgiler eksik, bazı yerleri boş bıraktınız !! \nkontrol edin sonra tekrar deneyiniz");
                return;
            }

            long imageId = await jsonService.UploadImage(pbFoodItemImage.Image, txtItemName.Text);
            FoodItemContext foodItemContext = new FoodItemContext();

            foodItemContext.itemName = txtItemName.Text;
            foodItemContext.quantity = float.Parse(txtQuantity.Text);
            foodItemContext.categoryId = categoryId;
            foodItemContext.portionContextList = portionContextList;
            foodItemContext.imageId = imageId;

            string result = jsonService.saveFoodItems(foodItemContext);
            if(result != null)
            {
                MessageBox.Show("Ekleme İşlemi tamamlandı\n" + result, "Sonuc", MessageBoxButtons.OK);
                this.Close();
            }
            else
                MessageBox.Show("Bir Hata Oluştu" + result, "Sonuc", MessageBoxButtons.OK);
        }

        private string CheckIfThereIsEmptyTextBox()
        {
            string newPortions = string.Empty;
            List<int> checkedSwitch = new List<int>();

            switcheList.ForEach(toggle => {
                if (toggle.Checked)
                    checkedSwitch.Add(switcheList.IndexOf(toggle));
            });

            foreach (int i in checkedSwitch)
            {
                newPortions += txtPortionList[i].Text + 
                    ", Oran: " + txtRatioList[i].Text + 
                    ", Adet: " + txtCustomQuantityList[i].Text + 
                    ", Fiyat: " + txtPriceList[i].Text + "\n";

                if (txtPortionList[i].Text.Length <= 0 ||
                    txtRatioList[i].Text.Length <= 0 ||
                    txtCustomQuantityList[i].Text.Length <= 0 ||
                    txtPriceList[i].Text.Length <= 0)
                {  
                    newPortions = string.Empty;
                    break;
                }
            }
            return newPortions;
        }

        // save new Portion
        private void SaveAddedCustomPortionButton_Click(object sender, EventArgs e)
        {   
            string customPortions = CheckIfThereIsEmptyTextBox();
            if (customPortions.Equals(string.Empty))
            {
                MessageBox.Show("Girdiğin yemek bilgileri eksik !! \nTekrar kontrol edininz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show(customPortions, "Yeni Ürün", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            List<int> activeToggleSwitchs = new List<int>();

            for (int i = 0; i < switcheList.Count; i++)
            {
                if (switcheList[i].Checked)
                {
                    Portion portion = new Portion(txtPortionList[i].Text, float.Parse(txtRatioList[i].Text.Replace('.',',')));
                    long id = 0;          
                    try
                    {
                        id = allPoritonsList.Find(p => portion.Equals(p)).id;                       
                    }
                    catch (Exception) { }

                    PortionContext portionContext = new PortionContext(
                        id,
                        portion.name,
                        portion.calculate,
                        float.Parse(txtPriceList[i].Text)
                        ) ;
                    portionContextList.Add(portionContext);
                }
            } 
        }
        private void AddFoodItem_Load(object sender, EventArgs e)
        { 
            TextBoxEvent_Intializer();
            AddCategoriesToComboBox();
            if(foodItem_PortionList != null)
                cbCategory.Text = jsonService.GetCategoryByItemId(foodItem_PortionList[0].foodItem.id);

        }
        private void TextBoxEvent_Intializer()
        {
            for (int i = 0; i < 3; i++)
            {
                switcheList[i].CheckedChanged += toggleSwitchs_CheckedChanged;
                txtCustomQuantityList[i].KeyUp += CalculateRatio;
                txtRatioList[i].KeyUp += CalculateCustomQuantity;
                txtRatioList[i].KeyPress += ApplyNumbersMask;
                txtCustomQuantityList[i].KeyPress += ApplyNumbersMask;
                txtPriceList[i].KeyPress += ApplyNumbersMask;
            }
            txtQuantity.KeyPress += ApplyNumbersMask;
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

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            string imageName =string.Empty;
            long imageSize = 0;
            do
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imageName = openFileDialog1.FileName;
                    imageSize = new FileInfo(openFileDialog1.FileName).Length;
                    if(imageSize > 1048576)
                        MessageBox.Show("Seçilen resim 1 mb geçmemeli");  
                }
                else
                    return;
                    
            } while (imageSize > 1048576);

            pbFoodItemImage.Image = Image.FromFile(imageName);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategory.SelectedItem != null)
           categoryId = categoryList.Find(category => category.name.Equals(cbCategory.SelectedItem.ToString())).id;
        }
     
        private void QuantityTextBoxOn_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                lblEmptyQunatityWarnin.Visible = false;

                for (int i = 0; i < lblQuantityList.Count; i++)
                {
                    lblQuantityList[i].Text = txtQuantity.Text;
                    CalculateCustomQuantity(txtRatioList[i],null);
                    lblTotalList[i].Text = txtCustomQuantityList[i].Text;
                }
            }
            else
                lblEmptyQunatityWarnin.Visible = true;
        }
        private void CalculateRatio(object sender, KeyEventArgs e)
        {
            int i = txtCustomQuantityList.IndexOf(sender as Guna2TextBox);
            if (txtCustomQuantityList[i].Text != "" && txtCustomQuantityList[i].Text != "0")
            {
                string customQuantity = txtCustomQuantityList[i].Text.Replace('.', ',');
                txtRatioList[i].Text = string.Format("{0:0.00}", float.Parse(txtQuantity.Text) / float.Parse(customQuantity));
            }
        }
        private void CalculateCustomQuantity(object sender, KeyEventArgs e)
        {
            int i = txtRatioList.IndexOf(sender as Guna2TextBox);
            if (txtRatioList[i].Text != "" && txtRatioList[i].Text != "0")
            {
                string ratio = txtRatioList[i].Text.Replace('.', ',');
                txtCustomQuantityList[i].Text = string.Format("{0:0.0}", float.Parse(txtQuantity.Text) / float.Parse(ratio));
            }
        }

        private void RemoveImageButton_Click(object sender, EventArgs e)
        {
            if(pbFoodItemImage.Image != null)
                pbFoodItemImage.Image = Properties.Resources.DefalutFoodImage;
        }

        private void txtItemName_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtItemName.Text.Length == 0)
                lblEmptyNameWarning.Visible = true;         
            else
                lblEmptyNameWarning.Visible = false;
        }

        private void btnClearPanels_Click(object sender, EventArgs e)
        {
            Clear();
            txtItemName.Text = "";
            txtQuantity.Text = "";
            radioButtonList.ForEach(rb => { if (rb.Checked) rb.Checked = false; });
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            adminForm.openChildForm(new FoodItemsPanel(adminForm));
        }
    }
}
