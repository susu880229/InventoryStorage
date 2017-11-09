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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(717, 252);
            this.dgv.TabIndex = 36;
            // 
            // btnSBack
            // 
            this.btnSBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSBack.Location = new System.Drawing.Point(529, 270);
            this.btnSBack.Name = "btnSBack";
            this.btnSBack.Size = new System.Drawing.Size(97, 31);
            this.btnSBack.TabIndex = 38;
            this.btnSBack.Text = "Back";
            this.btnSBack.UseVisualStyleBackColor = true;
            this.btnSBack.Click += new System.EventHandler(this.btnSBack_Click);
            // 
            // btnSExit
            // 
            this.btnSExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSExit.Location = new System.Drawing.Point(632, 270);
            this.btnSExit.Name = "btnSExit";
            this.btnSExit.Size = new System.Drawing.Size(97, 31);
            this.btnSExit.TabIndex = 37;
            this.btnSExit.Text = "Exit";
            this.btnSExit.UseVisualStyleBackColor = true;
            this.btnSExit.Click += new System.EventHandler(this.btnSExit_Click);
            // 
            // CheckSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 308);
            this.Controls.Add(this.btnSBack);
            this.Controls.Add(this.btnSExit);
            this.Controls.Add(this.dgv);
            this.Name = "CheckSpace";
            this.Text = "CheckSpace";
            this.Load += new System.EventHandler(this.CheckSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSBack;
        private System.Windows.Forms.Button btnSExit;
    }
}