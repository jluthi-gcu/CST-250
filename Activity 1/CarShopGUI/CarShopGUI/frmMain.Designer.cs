namespace CarShopGUI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheckout = new System.Windows.Forms.Button();
            this.gbCreateCar = new System.Windows.Forms.GroupBox();
            this.btnCreateCar = new System.Windows.Forms.Button();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.gbCarInventory = new System.Windows.Forms.GroupBox();
            this.lbCarInventory = new System.Windows.Forms.ListBox();
            this.gbShoppingCart = new System.Windows.Forms.GroupBox();
            this.lbShoppingCart = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalCostOuput = new System.Windows.Forms.Label();
            this.gbCreateCar.SuspendLayout();
            this.gbCarInventory.SuspendLayout();
            this.gbShoppingCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(816, 430);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(100, 32);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // gbCreateCar
            // 
            this.gbCreateCar.Controls.Add(this.btnCreateCar);
            this.gbCreateCar.Controls.Add(this.txtMiles);
            this.gbCreateCar.Controls.Add(this.txtColor);
            this.gbCreateCar.Controls.Add(this.txtPrice);
            this.gbCreateCar.Controls.Add(this.txtModel);
            this.gbCreateCar.Controls.Add(this.label5);
            this.gbCreateCar.Controls.Add(this.label4);
            this.gbCreateCar.Controls.Add(this.label3);
            this.gbCreateCar.Controls.Add(this.lblModel);
            this.gbCreateCar.Controls.Add(this.txtMake);
            this.gbCreateCar.Controls.Add(this.lblMake);
            this.gbCreateCar.Location = new System.Drawing.Point(33, 31);
            this.gbCreateCar.Name = "gbCreateCar";
            this.gbCreateCar.Size = new System.Drawing.Size(233, 366);
            this.gbCreateCar.TabIndex = 0;
            this.gbCreateCar.TabStop = false;
            this.gbCreateCar.Text = "Create a Car:";
            // 
            // btnCreateCar
            // 
            this.btnCreateCar.Location = new System.Drawing.Point(82, 197);
            this.btnCreateCar.Name = "btnCreateCar";
            this.btnCreateCar.Size = new System.Drawing.Size(100, 32);
            this.btnCreateCar.TabIndex = 10;
            this.btnCreateCar.Text = "Create Car";
            this.btnCreateCar.UseVisualStyleBackColor = true;
            this.btnCreateCar.Click += new System.EventHandler(this.btnCreateCar_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(67, 168);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(149, 23);
            this.txtMiles.TabIndex = 9;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(67, 139);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(149, 23);
            this.txtColor.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(67, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(149, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(67, 81);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(149, 23);
            this.txtModel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Miles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(17, 84);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(44, 15);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(67, 52);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(149, 23);
            this.txtMake.TabIndex = 1;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(22, 55);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(39, 15);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make:";
            // 
            // gbCarInventory
            // 
            this.gbCarInventory.Controls.Add(this.lbCarInventory);
            this.gbCarInventory.Location = new System.Drawing.Point(292, 31);
            this.gbCarInventory.Name = "gbCarInventory";
            this.gbCarInventory.Size = new System.Drawing.Size(233, 366);
            this.gbCarInventory.TabIndex = 1;
            this.gbCarInventory.TabStop = false;
            this.gbCarInventory.Text = "Car Inventory:";
            // 
            // lbCarInventory
            // 
            this.lbCarInventory.FormattingEnabled = true;
            this.lbCarInventory.ItemHeight = 15;
            this.lbCarInventory.Location = new System.Drawing.Point(6, 17);
            this.lbCarInventory.Name = "lbCarInventory";
            this.lbCarInventory.Size = new System.Drawing.Size(221, 334);
            this.lbCarInventory.TabIndex = 0;
            // 
            // gbShoppingCart
            // 
            this.gbShoppingCart.Controls.Add(this.lbShoppingCart);
            this.gbShoppingCart.Location = new System.Drawing.Point(683, 31);
            this.gbShoppingCart.Name = "gbShoppingCart";
            this.gbShoppingCart.Size = new System.Drawing.Size(233, 366);
            this.gbShoppingCart.TabIndex = 3;
            this.gbShoppingCart.TabStop = false;
            this.gbShoppingCart.Text = "Shopping Cart:";
            // 
            // lbShoppingCart
            // 
            this.lbShoppingCart.FormattingEnabled = true;
            this.lbShoppingCart.ItemHeight = 15;
            this.lbShoppingCart.Location = new System.Drawing.Point(6, 17);
            this.lbShoppingCart.Name = "lbShoppingCart";
            this.lbShoppingCart.Size = new System.Drawing.Size(221, 334);
            this.lbShoppingCart.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(555, 193);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(100, 32);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add to Cart ->";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(721, 403);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(62, 15);
            this.lblTotalCost.TabIndex = 4;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblTotalCostOuput
            // 
            this.lblTotalCostOuput.AutoSize = true;
            this.lblTotalCostOuput.Location = new System.Drawing.Point(789, 403);
            this.lblTotalCostOuput.Name = "lblTotalCostOuput";
            this.lblTotalCostOuput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalCostOuput.Size = new System.Drawing.Size(13, 15);
            this.lblTotalCostOuput.TabIndex = 5;
            this.lblTotalCostOuput.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 488);
            this.Controls.Add(this.lblTotalCostOuput);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.gbShoppingCart);
            this.Controls.Add(this.gbCarInventory);
            this.Controls.Add(this.gbCreateCar);
            this.Controls.Add(this.btnCheckout);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car Shop GUI";
            this.gbCreateCar.ResumeLayout(false);
            this.gbCreateCar.PerformLayout();
            this.gbCarInventory.ResumeLayout(false);
            this.gbShoppingCart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCheckout;
        private GroupBox gbCreateCar;
        private GroupBox gbCarInventory;
        private GroupBox gbShoppingCart;
        private Button btnAddToCart;
        private TextBox txtMiles;
        private TextBox txtColor;
        private TextBox txtPrice;
        private TextBox txtModel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblModel;
        private TextBox txtMake;
        private Label lblMake;
        private Button btnCreateCar;
        private Label lblTotalCost;
        private Label lblTotalCostOuput;
        private ListBox lbCarInventory;
        private ListBox lbShoppingCart;
    }
}