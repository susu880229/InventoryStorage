﻿namespace ProjectCSIS3540
{
    partial class Customers
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
            this.dgvPS = new System.Windows.Forms.DataGridView();
            this.btnCBack = new System.Windows.Forms.Button();
            this.btnCExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPSSearch = new System.Windows.Forms.TextBox();
            this.btnPSSearch = new System.Windows.Forms.Button();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.txbNameSe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPS
            // 
            this.dgvPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPS.Location = new System.Drawing.Point(101, 310);
            this.dgvPS.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPS.Name = "dgvPS";
            this.dgvPS.Size = new System.Drawing.Size(1360, 582);
            this.dgvPS.TabIndex = 33;
            
            // 
            // btnCBack
            // 
            this.btnCBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCBack.Location = new System.Drawing.Point(928, 906);
            this.btnCBack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCBack.Name = "btnCBack";
            this.btnCBack.Size = new System.Drawing.Size(259, 74);
            this.btnCBack.TabIndex = 30;
            this.btnCBack.Text = "Back";
            this.btnCBack.UseVisualStyleBackColor = true;
            this.btnCBack.Click += new System.EventHandler(this.btnCBack_Click);
            // 
            // btnCExit
            // 
            this.btnCExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCExit.Location = new System.Drawing.Point(1203, 906);
            this.btnCExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCExit.Name = "btnCExit";
            this.btnCExit.Size = new System.Drawing.Size(259, 74);
            this.btnCExit.TabIndex = 29;
            this.btnCExit.Text = "Exit";
            this.btnCExit.UseVisualStyleBackColor = true;
            this.btnCExit.Click += new System.EventHandler(this.btnCExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 55);
            this.label1.TabIndex = 28;
            this.label1.Text = "CS Warehouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "By Customer ID";
            // 
            // txbPSSearch
            // 
            this.txbPSSearch.Location = new System.Drawing.Point(64, 114);
            this.txbPSSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txbPSSearch.Name = "txbPSSearch";
            this.txbPSSearch.Size = new System.Drawing.Size(260, 38);
            this.txbPSSearch.TabIndex = 26;
            // 
            // btnPSSearch
            // 
            this.btnPSSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSSearch.Location = new System.Drawing.Point(347, 98);
            this.btnPSSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPSSearch.Name = "btnPSSearch";
            this.btnPSSearch.Size = new System.Drawing.Size(259, 74);
            this.btnPSSearch.TabIndex = 26;
            this.btnPSSearch.Text = "Search";
            this.btnPSSearch.UseVisualStyleBackColor = true;
            this.btnPSSearch.Click += new System.EventHandler(this.btnPSSearch_Click);
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameSearch.Location = new System.Drawing.Point(341, 98);
            this.btnNameSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(259, 74);
            this.btnNameSearch.TabIndex = 39;
            this.btnNameSearch.Text = "Search";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click);
            // 
            // txbNameSe
            // 
            this.txbNameSe.Location = new System.Drawing.Point(59, 114);
            this.txbNameSe.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txbNameSe.Name = "txbNameSe";
            this.txbNameSe.Size = new System.Drawing.Size(260, 38);
            this.txbNameSe.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 46);
            this.label3.TabIndex = 37;
            this.label3.Text = "By Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPSSearch);
            this.groupBox1.Controls.Add(this.txbPSSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(101, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(693, 186);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNameSearch);
            this.groupBox2.Controls.Add(this.txbNameSe);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(811, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(651, 186);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 1021);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPS);
            this.Controls.Add(this.btnCBack);
            this.Controls.Add(this.btnCExit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPS;
        private System.Windows.Forms.Button btnCBack;
        private System.Windows.Forms.Button btnCExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPSSearch;
        private System.Windows.Forms.Button btnPSSearch;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.TextBox txbNameSe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}