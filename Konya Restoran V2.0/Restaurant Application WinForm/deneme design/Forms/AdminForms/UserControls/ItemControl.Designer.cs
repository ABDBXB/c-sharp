namespace deneme_design.Controls
{
    partial class ItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemControl));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pbItemImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnUpdateItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteItem = new Guna.UI2.WinForms.Guna2Button();
            this.lblQuantityItem = new System.Windows.Forms.Label();
            this.lblPriceItem = new System.Windows.Forms.Label();
            this.lblitemName = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.guna2GradientPanel1.BorderRadius = 13;
            this.guna2GradientPanel1.BorderThickness = 2;
            this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2GradientPanel1.Controls.Add(this.btnUpdateItem);
            this.guna2GradientPanel1.Controls.Add(this.btnDeleteItem);
            this.guna2GradientPanel1.Controls.Add(this.lblQuantityItem);
            this.guna2GradientPanel1.Controls.Add(this.lblPriceItem);
            this.guna2GradientPanel1.Controls.Add(this.lblitemName);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 7);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.BorderRadius = 13;
            this.guna2GradientPanel1.ShadowDecoration.Depth = 35;
            this.guna2GradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 8);
            this.guna2GradientPanel1.Size = new System.Drawing.Size(187, 76);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 10;
            this.guna2GradientPanel2.Controls.Add(this.pbItemImage);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(68, 70);
            this.guna2GradientPanel2.TabIndex = 10;
            // 
            // pbItemImage
            // 
            this.pbItemImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbItemImage.Image = ((System.Drawing.Image)(resources.GetObject("pbItemImage.Image")));
            this.pbItemImage.Location = new System.Drawing.Point(0, 0);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.ShadowDecoration.Parent = this.pbItemImage;
            this.pbItemImage.Size = new System.Drawing.Size(68, 70);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItemImage.TabIndex = 1;
            this.pbItemImage.TabStop = false;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Animated = true;
            this.btnUpdateItem.AutoRoundedCorners = true;
            this.btnUpdateItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.btnUpdateItem.BorderRadius = 8;
            this.btnUpdateItem.BorderThickness = 1;
            this.btnUpdateItem.CheckedState.Parent = this.btnUpdateItem;
            this.btnUpdateItem.CustomImages.Parent = this.btnUpdateItem;
            this.btnUpdateItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnUpdateItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateItem.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.btnUpdateItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.btnUpdateItem.HoverState.Parent = this.btnUpdateItem;
            this.btnUpdateItem.Location = new System.Drawing.Point(76, 53);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.ShadowDecoration.Parent = this.btnUpdateItem;
            this.btnUpdateItem.Size = new System.Drawing.Size(63, 19);
            this.btnUpdateItem.TabIndex = 9;
            this.btnUpdateItem.Text = "Güncelle";
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Animated = true;
            this.btnDeleteItem.AutoRoundedCorners = true;
            this.btnDeleteItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.btnDeleteItem.BorderRadius = 8;
            this.btnDeleteItem.BorderThickness = 1;
            this.btnDeleteItem.CheckedState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.CustomImages.Parent = this.btnDeleteItem;
            this.btnDeleteItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.btnDeleteItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.btnDeleteItem.HoverState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Location = new System.Drawing.Point(142, 53);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.ShadowDecoration.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Size = new System.Drawing.Size(38, 19);
            this.btnDeleteItem.TabIndex = 8;
            this.btnDeleteItem.Text = "Sil";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblQuantityItem
            // 
            this.lblQuantityItem.AutoSize = true;
            this.lblQuantityItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantityItem.Location = new System.Drawing.Point(148, 30);
            this.lblQuantityItem.Name = "lblQuantityItem";
            this.lblQuantityItem.Size = new System.Drawing.Size(24, 16);
            this.lblQuantityItem.TabIndex = 7;
            this.lblQuantityItem.Text = "98";
            // 
            // lblPriceItem
            // 
            this.lblPriceItem.AutoSize = true;
            this.lblPriceItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPriceItem.Location = new System.Drawing.Point(76, 30);
            this.lblPriceItem.Name = "lblPriceItem";
            this.lblPriceItem.Size = new System.Drawing.Size(66, 16);
            this.lblPriceItem.TabIndex = 6;
            this.lblPriceItem.Text = "12.12 TL";
            // 
            // lblitemName
            // 
            this.lblitemName.AutoSize = true;
            this.lblitemName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblitemName.Location = new System.Drawing.Point(76, 6);
            this.lblitemName.Name = "lblitemName";
            this.lblitemName.Size = new System.Drawing.Size(41, 16);
            this.lblitemName.TabIndex = 5;
            this.lblitemName.Text = "Pizza";
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(201, 98);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnUpdateItem;
        private Guna.UI2.WinForms.Guna2Button btnDeleteItem;
        private System.Windows.Forms.Label lblQuantityItem;
        private System.Windows.Forms.Label lblPriceItem;
        private System.Windows.Forms.Label lblitemName;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox pbItemImage;
    }
}
