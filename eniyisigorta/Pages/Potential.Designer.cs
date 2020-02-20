namespace Pages
{
    partial class Potential
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.radioBtnAnadoluSigorta = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnImport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.pnlTitle.Location = new System.Drawing.Point(39, 61);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1031, 5);
            this.pnlTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(35, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 24);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Potansiyel";
            // 
            // radioBtnAnadoluSigorta
            // 
            this.radioBtnAnadoluSigorta.AutoSize = true;
            this.radioBtnAnadoluSigorta.Depth = 0;
            this.radioBtnAnadoluSigorta.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioBtnAnadoluSigorta.Location = new System.Drawing.Point(39, 92);
            this.radioBtnAnadoluSigorta.Margin = new System.Windows.Forms.Padding(0);
            this.radioBtnAnadoluSigorta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioBtnAnadoluSigorta.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioBtnAnadoluSigorta.Name = "radioBtnAnadoluSigorta";
            this.radioBtnAnadoluSigorta.Ripple = true;
            this.radioBtnAnadoluSigorta.Size = new System.Drawing.Size(128, 30);
            this.radioBtnAnadoluSigorta.TabIndex = 0;
            this.radioBtnAnadoluSigorta.TabStop = true;
            this.radioBtnAnadoluSigorta.Text = "Anadolu Sigorta";
            this.radioBtnAnadoluSigorta.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.Depth = 0;
            this.btnImport.Icon = null;
            this.btnImport.Location = new System.Drawing.Point(39, 141);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.Primary = true;
            this.btnImport.Size = new System.Drawing.Size(89, 36);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "İçe Aktar";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dataGridView.Location = new System.Drawing.Point(39, 206);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1031, 598);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.Depth = 0;
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(134, 141);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "btnExport";
            this.btnExport.Primary = true;
            this.btnExport.Size = new System.Drawing.Size(98, 36);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Dışa Aktar";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "(Sadece .xlsx dosya türünü destekler.)";
            // 
            // Potential
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.radioBtnAnadoluSigorta);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Potential";
            this.Size = new System.Drawing.Size(1113, 837);
            this.Load += new System.EventHandler(this.Potential_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnAnadoluSigorta;
        private MaterialSkin.Controls.MaterialRaisedButton btnImport;
        private System.Windows.Forms.DataGridView dataGridView;
        private MaterialSkin.Controls.MaterialRaisedButton btnExport;
        private System.Windows.Forms.Label label1;
    }
}
