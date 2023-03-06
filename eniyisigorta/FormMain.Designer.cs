namespace eniyisigorta
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnPotential = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnOffer = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContainer.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pnlSidebar);
            this.pnlContainer.Location = new System.Drawing.Point(0, 63);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1200, 1030);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pnlContent.Location = new System.Drawing.Point(298, 63);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(902, 639);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.pnlMenu);
            this.pnlSidebar.Controls.Add(this.pictureBox1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(300, 1030);
            this.pnlSidebar.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.lblCopyright);
            this.pnlMenu.Controls.Add(this.btnPotential);
            this.pnlMenu.Controls.Add(this.btnTransfer);
            this.pnlMenu.Controls.Add(this.btnOffer);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Location = new System.Drawing.Point(0, 145);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(341, 494);
            this.pnlMenu.TabIndex = 3;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCopyright.Location = new System.Drawing.Point(16, 864);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(207, 19);
            this.lblCopyright.TabIndex = 8;
            this.lblCopyright.Text = "© Copyright 2020 eniyisigorta";
            // 
            // btnPotential
            // 
            this.btnPotential.BackColor = System.Drawing.Color.White;
            this.btnPotential.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotential.FlatAppearance.BorderSize = 0;
            this.btnPotential.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotential.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnPotential.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPotential.Image = global::eniyisigorta.Properties.Resources.potential;
            this.btnPotential.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotential.Location = new System.Drawing.Point(0, 258);
            this.btnPotential.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPotential.Name = "btnPotential";
            this.btnPotential.Size = new System.Drawing.Size(300, 74);
            this.btnPotential.TabIndex = 3;
            this.btnPotential.Text = "                Potansiyel";
            this.btnPotential.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPotential.UseVisualStyleBackColor = false;
            this.btnPotential.Click += new System.EventHandler(this.btnPotential_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.White;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTransfer.Image = global::eniyisigorta.Properties.Resources.transfer;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(0, 172);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(300, 74);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "                Transfer";
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnOffer
            // 
            this.btnOffer.BackColor = System.Drawing.Color.White;
            this.btnOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOffer.FlatAppearance.BorderSize = 0;
            this.btnOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffer.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnOffer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOffer.Image = ((System.Drawing.Image)(resources.GetObject("btnOffer.Image")));
            this.btnOffer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffer.Location = new System.Drawing.Point(0, 86);
            this.btnOffer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOffer.Name = "btnOffer";
            this.btnOffer.Size = new System.Drawing.Size(300, 74);
            this.btnOffer.TabIndex = 1;
            this.btnOffer.Text = "                Teklif Al";
            this.btnOffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOffer.UseVisualStyleBackColor = false;
            this.btnOffer.Click += new System.EventHandler(this.btnOffer_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Image = global::eniyisigorta.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(300, 74);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "                Anasayfa";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eniyisigorta.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eniyisigorta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPotential;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnOffer;
        private System.Windows.Forms.Label lblCopyright;
    }
}