namespace ProjectCSIS3540
{
    partial class MainPage
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
            this.btnPSearch = new System.Windows.Forms.Button();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.btnMainDC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCO = new System.Windows.Forms.Button();
            this.btnCI = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMainCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "CS Warehouse";
            // 
            // btnPSearch
            // 
            this.btnPSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSearch.Location = new System.Drawing.Point(69, 69);
            this.btnPSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPSearch.Name = "btnPSearch";
            this.btnPSearch.Size = new System.Drawing.Size(339, 74);
            this.btnPSearch.TabIndex = 14;
            this.btnPSearch.Text = "View";
            this.btnPSearch.UseVisualStyleBackColor = true;
            this.btnPSearch.Click += new System.EventHandler(this.btnPSearch_Click);
            // 
            // btnMainExit
            // 
            this.btnMainExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainExit.Location = new System.Drawing.Point(434, 842);
            this.btnMainExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(259, 74);
            this.btnMainExit.TabIndex = 19;
            this.btnMainExit.Text = "Exit";
            this.btnMainExit.UseVisualStyleBackColor = true;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // btnMainDC
            // 
            this.btnMainDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDC.Location = new System.Drawing.Point(61, 842);
            this.btnMainDC.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMainDC.Name = "btnMainDC";
            this.btnMainDC.Size = new System.Drawing.Size(264, 74);
            this.btnMainDC.TabIndex = 20;
            this.btnMainDC.Text = "Disconnect";
            this.btnMainDC.UseVisualStyleBackColor = true;
            this.btnMainDC.Click += new System.EventHandler(this.btnMainDC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCO);
            this.groupBox1.Controls.Add(this.btnCI);
            this.groupBox1.Controls.Add(this.btnPSearch);
            this.groupBox1.Location = new System.Drawing.Point(85, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1066, 472);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // btnCO
            // 
            this.btnCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCO.Location = new System.Drawing.Point(71, 341);
            this.btnCO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(339, 74);
            this.btnCO.TabIndex = 16;
            this.btnCO.Text = "Check Out";
            this.btnCO.UseVisualStyleBackColor = true;
            this.btnCO.Click += new System.EventHandler(this.btnCO_Click);
            // 
            // btnCI
            // 
            this.btnCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCI.Location = new System.Drawing.Point(69, 210);
            this.btnCI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCI.Name = "btnCI";
            this.btnCI.Size = new System.Drawing.Size(339, 74);
            this.btnCI.TabIndex = 15;
            this.btnCI.Text = "Check In";
            this.btnCI.UseVisualStyleBackColor = true;
            this.btnCI.Click += new System.EventHandler(this.btnCI_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(1376, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox2.Size = new System.Drawing.Size(1066, 184);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customers";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(69, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 74);
            this.button1.TabIndex = 23;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMainCheck);
            this.groupBox3.Location = new System.Drawing.Point(1376, 395);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Size = new System.Drawing.Size(1057, 184);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Storage Space";
            // 
            // btnMainCheck
            // 
            this.btnMainCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCheck.Location = new System.Drawing.Point(69, 74);
            this.btnMainCheck.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnMainCheck.Name = "btnMainCheck";
            this.btnMainCheck.Size = new System.Drawing.Size(339, 74);
            this.btnMainCheck.TabIndex = 22;
            this.btnMainCheck.Text = "Check Space";
            this.btnMainCheck.UseVisualStyleBackColor = true;
            this.btnMainCheck.Click += new System.EventHandler(this.btnMainCheck_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3037, 1227);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMainDC);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPSearch;
        private System.Windows.Forms.Button btnMainExit;
        private System.Windows.Forms.Button btnMainDC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMainCheck;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnCO;
        public System.Windows.Forms.Button btnCI;
    }
}