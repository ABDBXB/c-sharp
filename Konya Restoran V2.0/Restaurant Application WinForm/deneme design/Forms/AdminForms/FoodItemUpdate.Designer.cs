namespace deneme_design.Forms.AdminForms
{
    partial class FoodItemUpdate
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStok = new Guna.UI2.WinForms.Guna2Button();
            this.btnFood = new Guna.UI2.WinForms.Guna2Button();
            this.btnImage = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateChildFormPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnX = new Guna.UI2.WinForms.Guna2Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"JPEG|*.jpg;*.jpeg;*.png;*.gif;*.tif;\"";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Maroon;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 582);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1255, 18);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.guna2Panel3.Controls.Add(this.btnStok);
            this.guna2Panel3.Controls.Add(this.btnFood);
            this.guna2Panel3.Controls.Add(this.btnImage);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 62);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1255, 49);
            this.guna2Panel3.TabIndex = 2;
            // 
            // btnStok
            // 
            this.btnStok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStok.Animated = true;
            this.btnStok.CheckedState.Parent = this.btnStok;
            this.btnStok.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnStok.CustomImages.Parent = this.btnStok;
            this.btnStok.FillColor = System.Drawing.Color.Transparent;
            this.btnStok.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStok.ForeColor = System.Drawing.Color.White;
            this.btnStok.HoverState.Parent = this.btnStok;
            this.btnStok.Location = new System.Drawing.Point(712, 7);
            this.btnStok.Name = "btnStok";
            this.btnStok.ShadowDecoration.Parent = this.btnStok;
            this.btnStok.Size = new System.Drawing.Size(135, 35);
            this.btnStok.TabIndex = 2;
            this.btnStok.Text = "Stok ve Fiyat";
            this.btnStok.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnFood
            // 
            this.btnFood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFood.Animated = true;
            this.btnFood.CheckedState.Parent = this.btnFood;
            this.btnFood.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnFood.CustomImages.Parent = this.btnFood;
            this.btnFood.FillColor = System.Drawing.Color.Transparent;
            this.btnFood.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.HoverState.Parent = this.btnFood;
            this.btnFood.Location = new System.Drawing.Point(550, 7);
            this.btnFood.Name = "btnFood";
            this.btnFood.ShadowDecoration.Parent = this.btnFood;
            this.btnFood.Size = new System.Drawing.Size(135, 35);
            this.btnFood.TabIndex = 1;
            this.btnFood.Text = "Yemek";
            this.btnFood.Click += new System.EventHandler(this.btnUpdateFoodItemDetails_Click);
            // 
            // btnImage
            // 
            this.btnImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImage.Animated = true;
            this.btnImage.CheckedState.Parent = this.btnImage;
            this.btnImage.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnImage.CustomImages.Parent = this.btnImage;
            this.btnImage.FillColor = System.Drawing.Color.Transparent;
            this.btnImage.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.HoverState.Parent = this.btnImage;
            this.btnImage.Location = new System.Drawing.Point(388, 7);
            this.btnImage.Name = "btnImage";
            this.btnImage.ShadowDecoration.Parent = this.btnImage;
            this.btnImage.Size = new System.Drawing.Size(135, 35);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Resim";
            this.btnImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // UpdateChildFormPanel
            // 
            this.UpdateChildFormPanel.CustomizableEdges.TopLeft = false;
            this.UpdateChildFormPanel.CustomizableEdges.TopRight = false;
            this.UpdateChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateChildFormPanel.Location = new System.Drawing.Point(0, 111);
            this.UpdateChildFormPanel.Name = "UpdateChildFormPanel";
            this.UpdateChildFormPanel.ShadowDecoration.Parent = this.UpdateChildFormPanel;
            this.UpdateChildFormPanel.Size = new System.Drawing.Size(1255, 471);
            this.UpdateChildFormPanel.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::deneme_design.Properties.Resources.Header_background;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.btnX);
            this.guna2Panel1.Controls.Add(this.lblHead);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1255, 62);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnX
            // 
            this.btnX.Animated = true;
            this.btnX.AutoRoundedCorners = true;
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BorderColor = System.Drawing.Color.Transparent;
            this.btnX.BorderRadius = 14;
            this.btnX.BorderThickness = 2;
            this.btnX.CheckedState.Parent = this.btnX;
            this.btnX.CustomImages.Parent = this.btnX;
            this.btnX.FillColor = System.Drawing.Color.Transparent;
            this.btnX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(152)))), ((int)(((byte)(254)))));
            this.btnX.HoverState.Image = global::deneme_design.Properties.Resources.back_after;
            this.btnX.HoverState.Parent = this.btnX;
            this.btnX.Image = global::deneme_design.Properties.Resources.back_before;
            this.btnX.Location = new System.Drawing.Point(7, 14);
            this.btnX.Name = "btnX";
            this.btnX.ShadowDecoration.Parent = this.btnX;
            this.btnX.Size = new System.Drawing.Size(36, 30);
            this.btnX.TabIndex = 20;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHead.AutoSize = true;
            this.lblHead.BackColor = System.Drawing.Color.Transparent;
            this.lblHead.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.lblHead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHead.Location = new System.Drawing.Point(583, 15);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(208, 29);
            this.lblHead.TabIndex = 19;
            this.lblHead.Text = "Update FoodItem";
            this.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoodItemUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1255, 600);
            this.Controls.Add(this.UpdateChildFormPanel);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoodItemUpdate";
            this.Text = "UpdateFoodItem";
            this.Load += new System.EventHandler(this.FoodItemUpdate_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblHead;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnStok;
        private Guna.UI2.WinForms.Guna2Button btnFood;
        private Guna.UI2.WinForms.Guna2Button btnImage;
        private Guna.UI2.WinForms.Guna2Panel UpdateChildFormPanel;
        private Guna.UI2.WinForms.Guna2Button btnX;
    }
}