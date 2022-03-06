
namespace BrandonGarciaFinalProject
{
    partial class frmShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShoppingCart));
            this.btnContinueShopping = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemoveItm = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.lblTaxAmt = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lbxTitle = new System.Windows.Forms.ListBox();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblTitle5 = new System.Windows.Forms.Label();
            this.lblTitle6 = new System.Windows.Forms.Label();
            this.lblTitle7 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxPrice = new System.Windows.Forms.ListBox();
            this.lbxQuantity = new System.Windows.Forms.ListBox();
            this.lbxTotal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnContinueShopping
            // 
            this.btnContinueShopping.Location = new System.Drawing.Point(868, 256);
            this.btnContinueShopping.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinueShopping.Name = "btnContinueShopping";
            this.btnContinueShopping.Size = new System.Drawing.Size(134, 28);
            this.btnContinueShopping.TabIndex = 0;
            this.btnContinueShopping.Text = "C&ontinue Shopping";
            this.btnContinueShopping.UseVisualStyleBackColor = true;
            this.btnContinueShopping.Click += new System.EventHandler(this.btnContinueShopping_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(532, 160);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(156, 28);
            this.btnClearCart.TabIndex = 1;
            this.btnClearCart.Text = "C&lear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnRemoveItm
            // 
            this.btnRemoveItm.Location = new System.Drawing.Point(23, 160);
            this.btnRemoveItm.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItm.Name = "btnRemoveItm";
            this.btnRemoveItm.Size = new System.Drawing.Size(156, 28);
            this.btnRemoveItm.TabIndex = 2;
            this.btnRemoveItm.Text = "R&emove Selected Item";
            this.btnRemoveItm.UseVisualStyleBackColor = true;
            this.btnRemoveItm.Click += new System.EventHandler(this.btnRemoveItm_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(868, 307);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(134, 28);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "C&heck Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.Location = new System.Drawing.Point(197, 235);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(106, 21);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.Text = "Subtotal: ";
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(197, 273);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(106, 21);
            this.lblTitle2.TabIndex = 5;
            this.lblTitle2.Text = "Tax Amount:";
            // 
            // lblTitle3
            // 
            this.lblTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.Location = new System.Drawing.Point(197, 307);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(106, 21);
            this.lblTitle3.TabIndex = 6;
            this.lblTitle3.Text = "NetTotal: ";
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetTotal.Location = new System.Drawing.Point(320, 307);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(179, 21);
            this.lblNetTotal.TabIndex = 9;
            // 
            // lblTaxAmt
            // 
            this.lblTaxAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmt.Location = new System.Drawing.Point(320, 273);
            this.lblTaxAmt.Name = "lblTaxAmt";
            this.lblTaxAmt.Size = new System.Drawing.Size(179, 21);
            this.lblTaxAmt.TabIndex = 8;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(320, 235);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(179, 21);
            this.lblSubTotal.TabIndex = 7;
            // 
            // lbxTitle
            // 
            this.lbxTitle.BackColor = System.Drawing.Color.AliceBlue;
            this.lbxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTitle.FormattingEnabled = true;
            this.lbxTitle.ItemHeight = 16;
            this.lbxTitle.Location = new System.Drawing.Point(23, 53);
            this.lbxTitle.Name = "lbxTitle";
            this.lbxTitle.Size = new System.Drawing.Size(280, 80);
            this.lbxTitle.TabIndex = 10;
            // 
            // lblTitle4
            // 
            this.lblTitle4.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTitle4.Location = new System.Drawing.Point(23, 20);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(199, 30);
            this.lblTitle4.TabIndex = 11;
            this.lblTitle4.Text = "Title";
            this.lblTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle5
            // 
            this.lblTitle5.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTitle5.Location = new System.Drawing.Point(221, 20);
            this.lblTitle5.Name = "lblTitle5";
            this.lblTitle5.Size = new System.Drawing.Size(202, 30);
            this.lblTitle5.TabIndex = 12;
            this.lblTitle5.Text = "Price";
            this.lblTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle6
            // 
            this.lblTitle6.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTitle6.Location = new System.Drawing.Point(419, 20);
            this.lblTitle6.Name = "lblTitle6";
            this.lblTitle6.Size = new System.Drawing.Size(143, 30);
            this.lblTitle6.TabIndex = 13;
            this.lblTitle6.Text = "Quantity";
            this.lblTitle6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle7
            // 
            this.lblTitle7.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTitle7.Location = new System.Drawing.Point(560, 20);
            this.lblTitle7.Name = "lblTitle7";
            this.lblTitle7.Size = new System.Drawing.Size(128, 30);
            this.lblTitle7.TabIndex = 14;
            this.lblTitle7.Text = "Line Total";
            this.lblTitle7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(824, 58);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(178, 22);
            this.tbxFirstName.TabIndex = 15;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(824, 95);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(178, 22);
            this.tbxLastName.TabIndex = 16;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(824, 131);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(178, 22);
            this.tbxAddress.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(723, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(723, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(723, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Address :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(794, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fill Out Customer Info";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxPrice
            // 
            this.lbxPrice.BackColor = System.Drawing.Color.AliceBlue;
            this.lbxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPrice.FormatString = "C2";
            this.lbxPrice.FormattingEnabled = true;
            this.lbxPrice.ItemHeight = 16;
            this.lbxPrice.Location = new System.Drawing.Point(301, 53);
            this.lbxPrice.Name = "lbxPrice";
            this.lbxPrice.Size = new System.Drawing.Size(178, 80);
            this.lbxPrice.TabIndex = 22;
            // 
            // lbxQuantity
            // 
            this.lbxQuantity.BackColor = System.Drawing.Color.AliceBlue;
            this.lbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxQuantity.FormattingEnabled = true;
            this.lbxQuantity.ItemHeight = 16;
            this.lbxQuantity.Location = new System.Drawing.Point(475, 53);
            this.lbxQuantity.Name = "lbxQuantity";
            this.lbxQuantity.Size = new System.Drawing.Size(124, 80);
            this.lbxQuantity.TabIndex = 23;
            // 
            // lbxTotal
            // 
            this.lbxTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.lbxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTotal.FormatString = "C2";
            this.lbxTotal.FormattingEnabled = true;
            this.lbxTotal.ItemHeight = 16;
            this.lbxTotal.Location = new System.Drawing.Point(598, 53);
            this.lbxTotal.Name = "lbxTotal";
            this.lbxTotal.Size = new System.Drawing.Size(90, 80);
            this.lbxTotal.TabIndex = 24;
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrandonGarciaFinalProject.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 349);
            this.Controls.Add(this.lbxTotal);
            this.Controls.Add(this.lbxQuantity);
            this.Controls.Add(this.lbxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblTitle7);
            this.Controls.Add(this.lblTitle6);
            this.Controls.Add(this.lblTitle5);
            this.Controls.Add(this.lblTitle4);
            this.Controls.Add(this.lbxTitle);
            this.Controls.Add(this.lblNetTotal);
            this.Controls.Add(this.lblTaxAmt);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnRemoveItm);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnContinueShopping);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.frmShoppingCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinueShopping;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemoveItm;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.Label lblTaxAmt;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.ListBox lbxTitle;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label lblTitle5;
        private System.Windows.Forms.Label lblTitle6;
        private System.Windows.Forms.Label lblTitle7;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxPrice;
        private System.Windows.Forms.ListBox lbxQuantity;
        private System.Windows.Forms.ListBox lbxTotal;
    }
}