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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPSExit = new System.Windows.Forms.Button();
            this.btnPSBack = new System.Windows.Forms.Button();
            this.dgvPS = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPSSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbPSCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "CS Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "By Product ID";
            // 
            // btnPSExit
            // 
            this.btnPSExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSExit.Location = new System.Drawing.Point(456, 406);
            this.btnPSExit.Name = "btnPSExit";
            this.btnPSExit.Size = new System.Drawing.Size(97, 31);
            this.btnPSExit.TabIndex = 20;
            this.btnPSExit.Text = "Exit";
            this.btnPSExit.UseVisualStyleBackColor = true;
            this.btnPSExit.Click += new System.EventHandler(this.btnPSExit_Click);
            // 
            // btnPSBack
            // 
            this.btnPSBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSBack.Location = new System.Drawing.Point(353, 406);
            this.btnPSBack.Name = "btnPSBack";
            this.btnPSBack.Size = new System.Drawing.Size(97, 31);
            this.btnPSBack.TabIndex = 21;
            this.btnPSBack.Text = "Back";
            this.btnPSBack.UseVisualStyleBackColor = true;
            this.btnPSBack.Click += new System.EventHandler(this.btnPSBack_Click);
            // 
            // dgvPS
            // 
            this.dgvPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPS.Location = new System.Drawing.Point(43, 156);
            this.dgvPS.Name = "dgvPS";
            this.dgvPS.Size = new System.Drawing.Size(510, 244);
            this.dgvPS.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPSSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 98);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txbPSSearch
            // 
            this.txbPSSearch.Location = new System.Drawing.Point(65, 42);
            this.txbPSSearch.Name = "txbPSSearch";
            this.txbPSSearch.Size = new System.Drawing.Size(126, 20);
            this.txbPSSearch.TabIndex = 26;
            this.txbPSSearch.TextChanged += new System.EventHandler(this.txbPSSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbPSCat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(303, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 98);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // cbbPSCat
            // 
            this.cbbPSCat.FormattingEnabled = true;
            this.cbbPSCat.Location = new System.Drawing.Point(52, 43);
            this.cbbPSCat.Name = "cbbPSCat";
            this.cbbPSCat.Size = new System.Drawing.Size(141, 21);
            this.cbbPSCat.TabIndex = 11;
            this.cbbPSCat.SelectedIndexChanged += new System.EventHandler(this.cbbPSCat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "By Category";
            // 
            // ProductsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPS);
            this.Controls.Add(this.btnPSBack);
            this.Controls.Add(this.btnPSExit);
            this.Controls.Add(this.label1);
            this.Name = "ProductsSearch";
            this.Text = "ProductsSearch";
            this.Load += new System.EventHandler(this.ProductsSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPSExit;
        private System.Windows.Forms.Button btnPSBack;
        private System.Windows.Forms.DataGridView dgvPS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbPSSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbPSCat;
        private System.Windows.Forms.Label label3;
    }
}