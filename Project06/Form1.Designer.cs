namespace Project06
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblShipMethod = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboShipMethod = new System.Windows.Forms.ComboBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.groupSurcharge = new System.Windows.Forms.GroupBox();
            this.txtNumItems = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.lblShippingTotal = new System.Windows.Forms.Label();
            this.lblNumItems = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupSurcharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About....";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(157, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Red Fern On-Line Electronics";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Location = new System.Drawing.Point(182, 62);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(130, 17);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Shipping Calculator";
            // 
            // lblShipMethod
            // 
            this.lblShipMethod.AutoSize = true;
            this.lblShipMethod.Location = new System.Drawing.Point(34, 102);
            this.lblShipMethod.Name = "lblShipMethod";
            this.lblShipMethod.Size = new System.Drawing.Size(114, 17);
            this.lblShipMethod.TabIndex = 3;
            this.lblShipMethod.Text = "Shipping Method";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(360, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(96, 17);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Shipping rate:";
            // 
            // comboShipMethod
            // 
            this.comboShipMethod.FormattingEnabled = true;
            this.comboShipMethod.Items.AddRange(new object[] {
            "Standard",
            "Express",
            "Same Day"});
            this.comboShipMethod.Location = new System.Drawing.Point(37, 123);
            this.comboShipMethod.Name = "comboShipMethod";
            this.comboShipMethod.Size = new System.Drawing.Size(121, 24);
            this.comboShipMethod.TabIndex = 6;
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Item",
            "Pound"});
            this.comboCategory.Location = new System.Drawing.Point(346, 120);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(121, 24);
            this.comboCategory.TabIndex = 7;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(6, 37);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(53, 21);
            this.radioBtnYes.TabIndex = 8;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Yes";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Location = new System.Drawing.Point(6, 64);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(47, 21);
            this.radioBtnNo.TabIndex = 9;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "No";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // groupSurcharge
            // 
            this.groupSurcharge.Controls.Add(this.radioBtnYes);
            this.groupSurcharge.Controls.Add(this.radioBtnNo);
            this.groupSurcharge.Location = new System.Drawing.Point(309, 173);
            this.groupSurcharge.Name = "groupSurcharge";
            this.groupSurcharge.Size = new System.Drawing.Size(200, 100);
            this.groupSurcharge.TabIndex = 10;
            this.groupSurcharge.TabStop = false;
            this.groupSurcharge.Text = "Surcharge (HA or AK)";
            // 
            // txtNumItems
            // 
            this.txtNumItems.Location = new System.Drawing.Point(37, 194);
            this.txtNumItems.Name = "txtNumItems";
            this.txtNumItems.Size = new System.Drawing.Size(100, 22);
            this.txtNumItems.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(19, 282);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 54);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate Shipping";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCost.Location = new System.Drawing.Point(346, 309);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(100, 15);
            this.txtTotalCost.TabIndex = 13;
            // 
            // lblShippingTotal
            // 
            this.lblShippingTotal.AutoSize = true;
            this.lblShippingTotal.Location = new System.Drawing.Point(343, 289);
            this.lblShippingTotal.Name = "lblShippingTotal";
            this.lblShippingTotal.Size = new System.Drawing.Size(129, 17);
            this.lblShippingTotal.TabIndex = 14;
            this.lblShippingTotal.Text = "Your Shipping Cost";
            // 
            // lblNumItems
            // 
            this.lblNumItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNumItems.Location = new System.Drawing.Point(19, 173);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.ReadOnly = true;
            this.lblNumItems.Size = new System.Drawing.Size(180, 15);
            this.lblNumItems.TabIndex = 15;
            this.lblNumItems.Text = "(Please choose shipping rate)";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 414);
            this.Controls.Add(this.lblNumItems);
            this.Controls.Add(this.lblShippingTotal);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumItems);
            this.Controls.Add(this.groupSurcharge);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.comboShipMethod);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblShipMethod);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Shipping Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupSurcharge.ResumeLayout(false);
            this.groupSurcharge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblShipMethod;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboShipMethod;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.GroupBox groupSurcharge;
        private System.Windows.Forms.TextBox txtNumItems;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label lblShippingTotal;
        private System.Windows.Forms.TextBox lblNumItems;
    }
}

