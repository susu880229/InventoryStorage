namespace ProjectCSIS3540
{
    partial class CheckSpace
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSBack = new System.Windows.Forms.Button();
            this.btnSExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(29, 230);
            this.dgv.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(3000, 954);
            this.dgv.TabIndex = 36;
            // 
            // btnSBack
            // 
            this.btnSBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSBack.Location = new System.Drawing.Point(29, 1295);
            this.btnSBack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSBack.Name = "btnSBack";
            this.btnSBack.Size = new System.Drawing.Size(259, 74);
            this.btnSBack.TabIndex = 38;
            this.btnSBack.Text = "Back";
            this.btnSBack.UseVisualStyleBackColor = true;
            this.btnSBack.Click += new System.EventHandler(this.btnSBack_Click);
            // 
            // btnSExit
            // 
            this.btnSExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSExit.Location = new System.Drawing.Point(392, 1295);
            this.btnSExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSExit.Name = "btnSExit";
            this.btnSExit.Size = new System.Drawing.Size(259, 74);
            this.btnSExit.TabIndex = 37;
            this.btnSExit.Text = "Exit";
            this.btnSExit.UseVisualStyleBackColor = true;
            this.btnSExit.Click += new System.EventHandler(this.btnSExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Storage Space Information";
            // 
            // CheckSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3046, 1728);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSBack);
            this.Controls.Add(this.btnSExit);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CheckSpace";
            this.Text = "CheckSpace";
            this.Load += new System.EventHandler(this.CheckSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSBack;
        private System.Windows.Forms.Button btnSExit;
        private System.Windows.Forms.Label label1;
    }
}