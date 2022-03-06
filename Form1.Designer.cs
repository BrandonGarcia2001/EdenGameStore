
namespace BrandonGarciaFinalProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMainStrip = new System.Windows.Forms.MenuStrip();
            this.mnuMainItmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainItmShopVideoGames = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxPSN = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.hlpHelp = new System.Windows.Forms.HelpProvider();
            this.mnuMainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainStrip
            // 
            this.mnuMainStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainItmExit,
            this.mnuMainItmHelp,
            this.mnuMainItmAbout,
            this.mnuMainItmShopVideoGames});
            this.mnuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainStrip.Name = "mnuMainStrip";
            this.mnuMainStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainStrip.Size = new System.Drawing.Size(554, 28);
            this.mnuMainStrip.TabIndex = 1;
            this.mnuMainStrip.Text = "menuStrip1";
            // 
            // mnuMainItmExit
            // 
            this.mnuMainItmExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuMainItmExit.Name = "mnuMainItmExit";
            this.mnuMainItmExit.Size = new System.Drawing.Size(45, 24);
            this.mnuMainItmExit.Text = "E&xit";
            this.mnuMainItmExit.Click += new System.EventHandler(this.mnuMainItmExit_Click);
            // 
            // mnuMainItmHelp
            // 
            this.mnuMainItmHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuMainItmHelp.Name = "mnuMainItmHelp";
            this.mnuMainItmHelp.Size = new System.Drawing.Size(53, 24);
            this.mnuMainItmHelp.Text = "H&elp";
            this.mnuMainItmHelp.Click += new System.EventHandler(this.mnuMainItmHelp_Click);
            // 
            // mnuMainItmAbout
            // 
            this.mnuMainItmAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuMainItmAbout.Name = "mnuMainItmAbout";
            this.mnuMainItmAbout.Size = new System.Drawing.Size(62, 24);
            this.mnuMainItmAbout.Text = "A&bout";
            this.mnuMainItmAbout.Click += new System.EventHandler(this.mnuMainItmAbout_Click);
            // 
            // mnuMainItmShopVideoGames
            // 
            this.mnuMainItmShopVideoGames.Name = "mnuMainItmShopVideoGames";
            this.mnuMainItmShopVideoGames.Size = new System.Drawing.Size(147, 24);
            this.mnuMainItmShopVideoGames.Text = "S&hop Video Games";
            this.mnuMainItmShopVideoGames.Click += new System.EventHandler(this.mnuMainItmShopVideoGames_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BrandonGarciaFinalProject.Properties.Resources.XboxLogo;
            this.pictureBox2.Location = new System.Drawing.Point(464, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BrandonGarciaFinalProject.Properties.Resources.SwitchLogo;
            this.pictureBox1.Location = new System.Drawing.Point(238, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbxPSN
            // 
            this.pbxPSN.Image = global::BrandonGarciaFinalProject.Properties.Resources.PlaystationLogo;
            this.pbxPSN.Location = new System.Drawing.Point(12, 213);
            this.pbxPSN.Name = "pbxPSN";
            this.pbxPSN.Size = new System.Drawing.Size(78, 70);
            this.pbxPSN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPSN.TabIndex = 2;
            this.pbxPSN.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BrandonGarciaFinalProject.Properties.Resources.EdenGameStoreV3;
            this.pictureBox3.Location = new System.Drawing.Point(166, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BrandonGarciaFinalProject.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 295);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxPSN);
            this.Controls.Add(this.mnuMainStrip);
            this.hlpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainStrip;
            this.Name = "frmMain";
            this.hlpHelp.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eden Game Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMainStrip.ResumeLayout(false);
            this.mnuMainStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMainStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuMainItmShopVideoGames;
        private System.Windows.Forms.PictureBox pbxPSN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.HelpProvider hlpHelp;
    }
}

