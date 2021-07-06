namespace deneme_design.Forms.AdminForms.FoodItemUpdateForms
{
    partial class UpdateImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateImage));
            this.btnRemoveImage = new Guna.UI2.WinForms.Guna2Button();
            this.pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.pbFoodItemImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnImageAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveNewItem = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveImage.Animated = true;
            this.btnRemoveImage.AutoRoundedCorners = true;
            this.btnRemoveImage.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveImage.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemoveImage.BorderRadius = 16;
            this.btnRemoveImage.CheckedState.Parent = this.btnRemoveImage;
            this.btnRemoveImage.CustomImages.Parent = this.btnRemoveImage;
            this.btnRemoveImage.FillColor = System.Drawing.Color.Transparent;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.HoverState.Image = global::deneme_design.Properties.Resources.delete_after;
            this.btnRemoveImage.HoverState.Parent = this.btnRemoveImage;
            this.btnRemoveImage.Image = global::deneme_design.Properties.Resources.delete_before;
            this.btnRemoveImage.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRemoveImage.Location = new System.Drawing.Point(592, 316);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.ShadowDecoration.Parent = this.btnRemoveImage;
            this.btnRemoveImage.Size = new System.Drawing.Size(35, 38);
            this.btnRemoveImage.TabIndex = 61;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // pnl
            // 
            this.pnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.pnl.BorderRadius = 10;
            this.pnl.BorderThickness = 2;
            this.pnl.Controls.Add(this.pbFoodItemImage);
            this.pnl.Controls.Add(this.btnImageAdd);
            this.pnl.Location = new System.Drawing.Point(505, 102);
            this.pnl.Name = "pnl";
            this.pnl.Padding = new System.Windows.Forms.Padding(5);
            this.pnl.ShadowDecoration.Parent = this.pnl;
            this.pnl.Size = new System.Drawing.Size(207, 205);
            this.pnl.TabIndex = 60;
            // 
            // pbFoodItemImage
            // 
            this.pbFoodItemImage.BackColor = System.Drawing.Color.Transparent;
            this.pbFoodItemImage.BorderRadius = 5;
            this.pbFoodItemImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbFoodItemImage.FillColor = System.Drawing.Color.Transparent;
            this.pbFoodItemImage.Image = ((System.Drawing.Image)(resources.GetObject("pbFoodItemImage.Image")));
            this.pbFoodItemImage.Location = new System.Drawing.Point(5, 5);
            this.pbFoodItemImage.Name = "pbFoodItemImage";
            this.pbFoodItemImage.ShadowDecoration.Parent = this.pbFoodItemImage;
            this.pbFoodItemImage.Size = new System.Drawing.Size(197, 148);
            this.pbFoodItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodItemImage.TabIndex = 12;
            this.pbFoodItemImage.TabStop = false;
            // 
            // btnImageAdd
            // 
            this.btnImageAdd.Animated = true;
            this.btnImageAdd.BorderRadius = 6;
            this.btnImageAdd.CheckedState.Parent = this.btnImageAdd;
            this.btnImageAdd.CustomImages.Parent = this.btnImageAdd;
            this.btnImageAdd.CustomizableEdges.TopLeft = false;
            this.btnImageAdd.CustomizableEdges.TopRight = false;
            this.btnImageAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnImageAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.btnImageAdd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageAdd.ForeColor = System.Drawing.Color.White;
            this.btnImageAdd.HoverState.Parent = this.btnImageAdd;
            this.btnImageAdd.Location = new System.Drawing.Point(5, 159);
            this.btnImageAdd.Name = "btnImageAdd";
            this.btnImageAdd.ShadowDecoration.Parent = this.btnImageAdd;
            this.btnImageAdd.Size = new System.Drawing.Size(197, 41);
            this.btnImageAdd.TabIndex = 4;
            this.btnImageAdd.Text = "Resim Ekle";
            this.btnImageAdd.Click += new System.EventHandler(this.btnImageAdd_Click);
            // 
            // btnSaveNewItem
            // 
            this.btnSaveNewItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveNewItem.Animated = true;
            this.btnSaveNewItem.AutoRoundedCorners = true;
            this.btnSaveNewItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.btnSaveNewItem.BorderRadius = 19;
            this.btnSaveNewItem.BorderThickness = 2;
            this.btnSaveNewItem.CheckedState.Parent = this.btnSaveNewItem;
            this.btnSaveNewItem.CustomImages.Parent = this.btnSaveNewItem;
            this.btnSaveNewItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.btnSaveNewItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewItem.ForeColor = System.Drawing.Color.White;
            this.btnSaveNewItem.HoverState.Parent = this.btnSaveNewItem;
            this.btnSaveNewItem.Location = new System.Drawing.Point(535, 362);
            this.btnSaveNewItem.Name = "btnSaveNewItem";
            this.btnSaveNewItem.ShadowDecoration.Parent = this.btnSaveNewItem;
            this.btnSaveNewItem.Size = new System.Drawing.Size(148, 41);
            this.btnSaveNewItem.TabIndex = 62;
            this.btnSaveNewItem.Text = "Kaydet";
            this.btnSaveNewItem.Click += new System.EventHandler(this.btnSaveNewItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"JPEG|*.jpg;*.jpeg;*.png;*.gif;*.tif;\"";
            // 
            // UpdateImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1255, 471);
            this.Controls.Add(this.btnSaveNewItem);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.pnl);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateImage";
            this.Text = "UpdateImage";
            this.Load += new System.EventHandler(this.UpdateImage_Load);
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRemoveImage;
        private Guna.UI2.WinForms.Guna2Panel pnl;
        private Guna.UI2.WinForms.Guna2PictureBox pbFoodItemImage;
        private Guna.UI2.WinForms.Guna2Button btnImageAdd;
        private Guna.UI2.WinForms.Guna2Button btnSaveNewItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}