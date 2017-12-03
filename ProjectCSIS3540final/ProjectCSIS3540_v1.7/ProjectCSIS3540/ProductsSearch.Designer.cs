namespace ProjectCSIS3540
{
    partial class ProductsSearch
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
            this.btnPSExit = new System.Windows.Forms.Button();
            this.btnPSBack = new System.Windows.Forms.Button();
            this.dgvPS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPSSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbPSCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPSExit
            // 
            this.btnPSExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSExit.Location = new System.Drawing.Point(461, 1420);
            this.btnPSExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPSExit.Name = "btnPSExit";
            this.btnPSExit.Size = new System.Drawing.Size(259, 74);
            this.btnPSExit.TabIndex = 20;
            this.btnPSExit.Text = "Exit";
            this.btnPSExit.UseVisualStyleBackColor = true;
            this.btnPSExit.Click += new System.EventHandler(this.btnPSExit_Click);
            // 
            // btnPSBack
            // 
            this.btnPSBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSBack.Location = new System.Drawing.Point(115, 1420);
            this.btnPSBack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPSBack.Name = "btnPSBack";
            this.btnPSBack.Size = new System.Drawing.Size(259, 74);
            this.btnPSBack.TabIndex = 21;
            this.btnPSBack.Text = "Back";
            this.btnPSBack.UseVisualStyleBackColor = true;
            this.btnPSBack.Click += new System.EventHandler(this.btnPSBack_Click);
            // 
            // dgvPS
            // 
            this.dgvPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPS.Location = new System.Drawing.Point(115, 435);
            this.dgvPS.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPS.Name = "dgvPS";
            this.dgvPS.Size = new System.Drawing.Size(3040, 925);
            this.dgvPS.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPSSearch);
            this.groupBox1.Location = new System.Drawing.Point(115, 157);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(677, 234);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "By Product ID";
            // 
            // txbPSSearch
            // 
            this.txbPSSearch.Location = new System.Drawing.Point(173, 100);
            this.txbPSSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txbPSSearch.Name = "txbPSSearch";
            this.txbPSSearch.Size = new System.Drawing.Size(329, 38);
            this.txbPSSearch.TabIndex = 26;
            this.txbPSSearch.TextChanged += new System.EventHandler(this.txbPSSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbPSCat);
            this.groupBox2.Location = new System.Drawing.Point(1081, 157);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(667, 234);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By Category";
            // 
            // cbbPSCat
            // 
            this.cbbPSCat.FormattingEnabled = true;
            this.cbbPSCat.Location = new System.Drawing.Point(139, 103);
            this.cbbPSCat.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbbPSCat.Name = "cbbPSCat";
            this.cbbPSCat.Size = new System.Drawing.Size(369, 39);
            this.cbbPSCat.TabIndex = 11;
            this.cbbPSCat.SelectedIndexChanged += new System.EventHandler(this.cbbPSCat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Product Information";
            // 
            // ProductsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3184, 1728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPS);
            this.Controls.Add(this.btnPSBack);
            this.Controls.Add(this.btnPSExit);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ProductsSearch";
            this.Text = "ProductsSearch";
            this.Load += new System.EventHandler(this.ProductsSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPSExit;
        private System.Windows.Forms.Button btnPSBack;
        private System.Windows.Forms.DataGridView dgvPS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbPSSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbPSCat;
        private System.Windows.Forms.Label label1;
    }
}