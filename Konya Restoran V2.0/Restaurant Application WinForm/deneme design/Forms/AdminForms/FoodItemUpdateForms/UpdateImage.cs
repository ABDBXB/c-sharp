using deneme_design.Context;
using deneme_design.Model;
using deneme_design.RestClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_design.Forms.AdminForms.FoodItemUpdateForms
{
    public partial class UpdateImage : Form
    {
        FoodItem foodItem = null;
        JsonService jsonService = null;
        public UpdateImage(FoodItem foodItem)
        {
            InitializeComponent();
            this.foodItem = foodItem;
            jsonService = new JsonService();
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            string imageName = string.Empty;
            long imageSize = 0;

            do
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imageName = openFileDialog1.FileName;
                    imageSize = new FileInfo(openFileDialog1.FileName).Length;
                    if (imageSize > 1048576)
                        MessageBox.Show("Seçilen resim 1 mb geçmemeli");
                }
                else
                    return;

            } while (imageSize > 1048576);

            pbFoodItemImage.Image = Image.FromFile(imageName);
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            if (pbFoodItemImage.Image != null)
                pbFoodItemImage.Image = Properties.Resources.DefalutFoodImage; 
        }

        private async void btnSaveNewItem_Click(object sender, EventArgs e)
        {
            ItemContext itemContext = new ItemContext();
            itemContext.id = this.foodItem.id;
            itemContext.imageId = await jsonService.UploadImage(pbFoodItemImage.Image, this.foodItem.itemName);

            long id = jsonService.UpdateFoodItemDetails(itemContext);
            if (id == itemContext.id)
                MessageBox.Show("Güncelleme işlemi tamamlandı");  
        }

        private void UpdateImage_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(this.foodItem.itemImages.picture);
            pbFoodItemImage.Image = Image.FromStream(ms);
        }
    }
}
