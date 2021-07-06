namespace deneme_design.Forms.AdminForms
{
    partial class PdfReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfReader));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnX = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBillNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BackgroundImage = global::deneme_design.Properties.Resources.Header_background;
            this.guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2GradientPanel1.Controls.Add(this.btnX);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.txtBillNo);
            this.guna2GradientPanel1.Controls.Add(this.guna2Button4);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.BorderRadius = 10;
            this.guna2GradientPanel1.ShadowDecoration.Color = System.Drawing.Color.DarkRed;
            this.guna2GradientPanel1.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.guna2GradientPanel1.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.guna2GradientPanel1.ShadowDecoration.Enabled = true;
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(800, 62);
            this.guna2GradientPanel1.TabIndex = 2;
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
            this.btnX.Location = new System.Drawing.Point(7, 13);
            this.btnX.Name = "btnX";
            this.btnX.ShadowDecoration.Parent = this.btnX;
            this.btnX.Size = new System.Drawing.Size(36, 30);
            this.btnX.TabIndex = 35;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(65, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Faturalar";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fatura No:";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBillNo.Animated = true;
            this.txtBillNo.AutoRoundedCorners = true;
            this.txtBillNo.BackColor = System.Drawing.Color.Transparent;
            this.txtBillNo.BorderRadius = 12;
            this.txtBillNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBillNo.DefaultText = "";
            this.txtBillNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBillNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBillNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillNo.DisabledState.Parent = this.txtBillNo;
            this.txtBillNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBillNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtBillNo.FocusedState.Parent = this.txtBillNo;
            this.txtBillNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBillNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(0)))), ((int)(((byte)(23)))));
            this.txtBillNo.HoverState.Parent = this.txtBillNo;
            this.txtBillNo.Location = new System.Drawing.Point(369, 15);
            this.txtBillNo.MaxLength = 20;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.PasswordChar = '\0';
            this.txtBillNo.PlaceholderText = "";
            this.txtBillNo.SelectedText = "";
            this.txtBillNo.ShadowDecoration.Parent = this.txtBillNo;
            this.txtBillNo.Size = new System.Drawing.Size(79, 26);
            this.txtBillNo.TabIndex = 28;
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button4.Animated = true;
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 12;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.guna2Button4.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(457, 15);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(56, 26);
            this.guna2Button4.TabIndex = 27;
            this.guna2Button4.Text = "Ara";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 62);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(800, 538);
            this.axAcroPDF1.TabIndex = 3;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(0, 582);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(800, 18);
            this.guna2GradientPanel2.TabIndex = 4;
            // 
            // PdfReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PdfReader";
            this.Text = "PdfReader";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btnX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBillNo;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
    }
}