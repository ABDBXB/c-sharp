namespace deneme_design.Forms.AdminForms.UserControls
{
    partial class PortionDetailsControl
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
            this.pnlPortion1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomQuantity1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRatio1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPortion1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuantity1 = new System.Windows.Forms.Label();
            this.txtPrice1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlPortion1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPortion1
            // 
            this.pnlPortion1.Controls.Add(this.guna2Button1);
            this.pnlPortion1.Controls.Add(this.label1);
            this.pnlPortion1.Controls.Add(this.txtCustomQuantity1);
            this.pnlPortion1.Controls.Add(this.txtRatio1);
            this.pnlPortion1.Controls.Add(this.txtPortion1);
            this.pnlPortion1.Controls.Add(this.lblQuantity1);
            this.pnlPortion1.Controls.Add(this.txtPrice1);
            this.pnlPortion1.Location = new System.Drawing.Point(0, 0);
            this.pnlPortion1.Name = "pnlPortion1";
            this.pnlPortion1.ShadowDecoration.Parent = this.pnlPortion1;
            this.pnlPortion1.Size = new System.Drawing.Size(255, 20);
            this.pnlPortion1.TabIndex = 53;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2Button1.HoverState.Image = global::deneme_design.Properties.Resources.delete_after;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::deneme_design.Properties.Resources.delete_before;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(15, 15);
            this.guna2Button1.TabIndex = 45;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(236, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "TL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomQuantity1
            // 
            this.txtCustomQuantity1.Animated = true;
            this.txtCustomQuantity1.AutoRoundedCorners = true;
            this.txtCustomQuantity1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtCustomQuantity1.BorderRadius = 6;
            this.txtCustomQuantity1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomQuantity1.DefaultText = "";
            this.txtCustomQuantity1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomQuantity1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomQuantity1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomQuantity1.DisabledState.Parent = this.txtCustomQuantity1;
            this.txtCustomQuantity1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomQuantity1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtCustomQuantity1.FocusedState.Parent = this.txtCustomQuantity1;
            this.txtCustomQuantity1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtCustomQuantity1.ForeColor = System.Drawing.Color.Black;
            this.txtCustomQuantity1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtCustomQuantity1.HoverState.Parent = this.txtCustomQuantity1;
            this.txtCustomQuantity1.Location = new System.Drawing.Point(150, 2);
            this.txtCustomQuantity1.Name = "txtCustomQuantity1";
            this.txtCustomQuantity1.PasswordChar = '\0';
            this.txtCustomQuantity1.PlaceholderText = "";
            this.txtCustomQuantity1.SelectedText = "";
            this.txtCustomQuantity1.ShadowDecoration.Parent = this.txtCustomQuantity1;
            this.txtCustomQuantity1.Size = new System.Drawing.Size(39, 15);
            this.txtCustomQuantity1.TabIndex = 12;
            this.txtCustomQuantity1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRatio1
            // 
            this.txtRatio1.Animated = true;
            this.txtRatio1.AutoRoundedCorners = true;
            this.txtRatio1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtRatio1.BorderRadius = 6;
            this.txtRatio1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRatio1.DefaultText = "";
            this.txtRatio1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRatio1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRatio1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRatio1.DisabledState.Parent = this.txtRatio1;
            this.txtRatio1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRatio1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtRatio1.FocusedState.Parent = this.txtRatio1;
            this.txtRatio1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtRatio1.ForeColor = System.Drawing.Color.Black;
            this.txtRatio1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtRatio1.HoverState.Parent = this.txtRatio1;
            this.txtRatio1.Location = new System.Drawing.Point(109, 2);
            this.txtRatio1.Name = "txtRatio1";
            this.txtRatio1.PasswordChar = '\0';
            this.txtRatio1.PlaceholderText = "";
            this.txtRatio1.SelectedText = "";
            this.txtRatio1.ShadowDecoration.Parent = this.txtRatio1;
            this.txtRatio1.Size = new System.Drawing.Size(35, 15);
            this.txtRatio1.TabIndex = 11;
            this.txtRatio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPortion1
            // 
            this.txtPortion1.Animated = true;
            this.txtPortion1.AutoRoundedCorners = true;
            this.txtPortion1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPortion1.BorderRadius = 6;
            this.txtPortion1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPortion1.DefaultText = "";
            this.txtPortion1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPortion1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPortion1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPortion1.DisabledState.Parent = this.txtPortion1;
            this.txtPortion1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPortion1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtPortion1.FocusedState.Parent = this.txtPortion1;
            this.txtPortion1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtPortion1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPortion1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtPortion1.HoverState.Parent = this.txtPortion1;
            this.txtPortion1.Location = new System.Drawing.Point(21, 2);
            this.txtPortion1.Name = "txtPortion1";
            this.txtPortion1.PasswordChar = '\0';
            this.txtPortion1.PlaceholderText = "";
            this.txtPortion1.SelectedText = "";
            this.txtPortion1.ShadowDecoration.Parent = this.txtPortion1;
            this.txtPortion1.Size = new System.Drawing.Size(55, 15);
            this.txtPortion1.TabIndex = 10;
            this.txtPortion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity1
            // 
            this.lblQuantity1.AutoSize = true;
            this.lblQuantity1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantity1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuantity1.Location = new System.Drawing.Point(84, 4);
            this.lblQuantity1.Name = "lblQuantity1";
            this.lblQuantity1.Size = new System.Drawing.Size(14, 13);
            this.lblQuantity1.TabIndex = 43;
            this.lblQuantity1.Text = "0";
            this.lblQuantity1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuantity1.TextChanged += new System.EventHandler(this.lblQuantity1_TextChanged);
            // 
            // txtPrice1
            // 
            this.txtPrice1.Animated = true;
            this.txtPrice1.AutoRoundedCorners = true;
            this.txtPrice1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPrice1.BorderRadius = 6;
            this.txtPrice1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice1.DefaultText = "";
            this.txtPrice1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice1.DisabledState.Parent = this.txtPrice1;
            this.txtPrice1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtPrice1.FocusedState.Parent = this.txtPrice1;
            this.txtPrice1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtPrice1.ForeColor = System.Drawing.Color.Black;
            this.txtPrice1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtPrice1.HoverState.Parent = this.txtPrice1;
            this.txtPrice1.Location = new System.Drawing.Point(197, 2);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.PasswordChar = '\0';
            this.txtPrice1.PlaceholderText = "";
            this.txtPrice1.SelectedText = "";
            this.txtPrice1.ShadowDecoration.Parent = this.txtPrice1;
            this.txtPrice1.Size = new System.Drawing.Size(39, 15);
            this.txtPrice1.TabIndex = 17;
            this.txtPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortionDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPortion1);
            this.Name = "PortionDetailsControl";
            this.Size = new System.Drawing.Size(255, 20);
            this.pnlPortion1.ResumeLayout(false);
            this.pnlPortion1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPortion1;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomQuantity1;
        private Guna.UI2.WinForms.Guna2TextBox txtRatio1;
        private Guna.UI2.WinForms.Guna2TextBox txtPortion1;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
