
namespace BrandonGarciaFinalProject
{
    partial class frmShopNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShopNow));
            this.dgvGameViewer = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pbxGameDisplay = new System.Windows.Forms.PictureBox();
            this.lblSelecedGame = new System.Windows.Forms.Label();
            this.cbxQunatity = new System.Windows.Forms.ComboBox();
            this.lblQuntity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGameViewer
            // 
            this.dgvGameViewer.AllowUserToAddRows = false;
            this.dgvGameViewer.AllowUserToDeleteRows = false;
            this.dgvGameViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGameViewer.Location = new System.Drawing.Point(12, 12);
            this.dgvGameViewer.Name = "dgvGameViewer";
            this.dgvGameViewer.ReadOnly = true;
            this.dgvGameViewer.Size = new System.Drawing.Size(978, 122);
            this.dgvGameViewer.TabIndex = 0;
            this.dgvGameViewer.TabStop = false;
            this.dgvGameViewer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGameViewer_CellMouseClick);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(889, 286);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(101, 29);
            this.btnAddToCart.TabIndex = 1;
            this.btnAddToCart.Text = "A&dd To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoppingCart.Location = new System.Drawing.Point(889, 332);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(101, 29);
            this.btnShoppingCart.TabIndex = 2;
            this.btnShoppingCart.Text = "S&hopping Cart";
            this.btnShoppingCart.UseVisualStyleBackColor = true;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(889, 380);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(101, 29);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "H&ome";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pbxGameDisplay
            // 
            this.pbxGameDisplay.Location = new System.Drawing.Point(12, 211);
            this.pbxGameDisplay.Name = "pbxGameDisplay";
            this.pbxGameDisplay.Size = new System.Drawing.Size(174, 188);
            this.pbxGameDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGameDisplay.TabIndex = 4;
            this.pbxGameDisplay.TabStop = false;
            // 
            // lblSelecedGame
            // 
            this.lblSelecedGame.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblSelecedGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecedGame.Location = new System.Drawing.Point(12, 172);
            this.lblSelecedGame.Name = "lblSelecedGame";
            this.lblSelecedGame.Size = new System.Drawing.Size(174, 23);
            this.lblSelecedGame.TabIndex = 5;
            this.lblSelecedGame.Text = "Selected Game";
            this.lblSelecedGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxQunatity
            // 
            this.cbxQunatity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQunatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQunatity.FormattingEnabled = true;
            this.cbxQunatity.Location = new System.Drawing.Point(263, 211);
            this.cbxQunatity.Name = "cbxQunatity";
            this.cbxQunatity.Size = new System.Drawing.Size(121, 24);
            this.cbxQunatity.TabIndex = 6;
            this.cbxQunatity.TabStop = false;
            // 
            // lblQuntity
            // 
            this.lblQuntity.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblQuntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuntity.Location = new System.Drawing.Point(263, 172);
            this.lblQuntity.Name = "lblQuntity";
            this.lblQuntity.Size = new System.Drawing.Size(121, 35);
            this.lblQuntity.TabIndex = 7;
            this.lblQuntity.Text = "Quantity";
            this.lblQuntity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShopNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BrandonGarciaFinalProject.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 421);
            this.Controls.Add(this.lblQuntity);
            this.Controls.Add(this.cbxQunatity);
            this.Controls.Add(this.lblSelecedGame);
            this.Controls.Add(this.pbxGameDisplay);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnShoppingCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dgvGameViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShopNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Now";
            this.Activated += new System.EventHandler(this.frmShopNow_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShopNow_FormClosing);
            this.Load += new System.EventHandler(this.frmShopNow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox pbxGameDisplay;
        private System.Windows.Forms.Label lblSelecedGame;
        private System.Windows.Forms.ComboBox cbxQunatity;
        private System.Windows.Forms.Label lblQuntity;
        public System.Windows.Forms.DataGridView dgvGameViewer;
    }
}