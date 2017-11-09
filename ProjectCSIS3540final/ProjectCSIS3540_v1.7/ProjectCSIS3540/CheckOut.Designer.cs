namespace ProjectCSIS3540
{
    partial class CheckOut
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
            this.txtRw = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comOrder = new System.Windows.Forms.ComboBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLo = new System.Windows.Forms.TextBox();
            this.txtCO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtNa = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEp = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLe = new System.Windows.Forms.TextBox();
            this.txtWi = new System.Windows.Forms.TextBox();
            this.txtWe = new System.Windows.Forms.TextBox();
            this.txtHe = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRw
            // 
            this.txtRw.Location = new System.Drawing.Point(1808, 615);
            this.txtRw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRw.Name = "txtRw";
            this.txtRw.Size = new System.Drawing.Size(279, 38);
            this.txtRw.TabIndex = 121;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1552, 622);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(233, 32);
            this.label19.TabIndex = 120;
            this.label19.Text = "Reduced Weight:";
            // 
            // comOrder
            // 
            this.comOrder.FormattingEnabled = true;
            this.comOrder.Items.AddRange(new object[] {
            "CHECK IN DATE ",
            "EXPIRATION DATE "});
            this.comOrder.Location = new System.Drawing.Point(577, 615);
            this.comOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comOrder.Name = "comOrder";
            this.comOrder.Size = new System.Drawing.Size(273, 39);
            this.comOrder.TabIndex = 119;
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(267, 615);
            this.txtPN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(273, 38);
            this.txtPN.TabIndex = 118;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 613);
            this.label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(203, 32);
            this.label18.TabIndex = 117;
            this.label18.Text = "Product Name:";
            // 
            // txtLo
            // 
            this.txtLo.Enabled = false;
            this.txtLo.Location = new System.Drawing.Point(1808, 525);
            this.txtLo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLo.Name = "txtLo";
            this.txtLo.Size = new System.Drawing.Size(279, 38);
            this.txtLo.TabIndex = 116;
            // 
            // txtCO
            // 
            this.txtCO.Location = new System.Drawing.Point(1131, 525);
            this.txtCO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCO.Name = "txtCO";
            this.txtCO.Size = new System.Drawing.Size(279, 38);
            this.txtCO.TabIndex = 115;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1552, 525);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 32);
            this.label17.TabIndex = 114;
            this.label17.Text = "Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(880, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 32);
            this.label6.TabIndex = 113;
            this.label6.Text = "Check out";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1209, 613);
            this.btnUp.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(268, 91);
            this.btnUp.TabIndex = 112;
            this.btnUp.Text = "Check Out Partial";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(501, 405);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(260, 38);
            this.txtTotal.TabIndex = 111;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(501, 285);
            this.txtTax.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(260, 38);
            this.txtTax.TabIndex = 110;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(501, 184);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(260, 38);
            this.txtPrice.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 408);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 108;
            this.label5.Text = "total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 107;
            this.label4.Text = "tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 106;
            this.label3.Text = "price:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(886, 613);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(277, 91);
            this.btnCheckOut.TabIndex = 105;
            this.btnCheckOut.Text = "Check Out All";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(1131, 112);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(279, 38);
            this.txtDesc.TabIndex = 104;
            // 
            // txtUnit
            // 
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(1808, 193);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(279, 38);
            this.txtUnit.TabIndex = 103;
            // 
            // txtNa
            // 
            this.txtNa.Enabled = false;
            this.txtNa.Location = new System.Drawing.Point(1808, 112);
            this.txtNa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNa.Name = "txtNa";
            this.txtNa.Size = new System.Drawing.Size(279, 38);
            this.txtNa.TabIndex = 102;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1552, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 32);
            this.label20.TabIndex = 101;
            this.label20.Text = "Name:";
            // 
            // txtCI
            // 
            this.txtCI.Enabled = false;
            this.txtCI.Location = new System.Drawing.Point(1808, 439);
            this.txtCI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(279, 38);
            this.txtCI.TabIndex = 100;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1552, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 32);
            this.label16.TabIndex = 99;
            this.label16.Text = "Check In";
            // 
            // txtEp
            // 
            this.txtEp.Enabled = false;
            this.txtEp.Location = new System.Drawing.Point(1131, 439);
            this.txtEp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEp.Name = "txtEp";
            this.txtEp.Size = new System.Drawing.Size(279, 38);
            this.txtEp.TabIndex = 98;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(880, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 32);
            this.label15.TabIndex = 97;
            this.label15.Text = "Expire Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1552, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 32);
            this.label14.TabIndex = 96;
            this.label14.Text = "Weight:";
            // 
            // txtLe
            // 
            this.txtLe.Enabled = false;
            this.txtLe.Location = new System.Drawing.Point(1131, 267);
            this.txtLe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLe.Name = "txtLe";
            this.txtLe.Size = new System.Drawing.Size(279, 38);
            this.txtLe.TabIndex = 95;
            // 
            // txtWi
            // 
            this.txtWi.Enabled = false;
            this.txtWi.Location = new System.Drawing.Point(1808, 272);
            this.txtWi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWi.Name = "txtWi";
            this.txtWi.Size = new System.Drawing.Size(279, 38);
            this.txtWi.TabIndex = 94;
            // 
            // txtWe
            // 
            this.txtWe.Location = new System.Drawing.Point(1808, 353);
            this.txtWe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWe.Name = "txtWe";
            this.txtWe.Size = new System.Drawing.Size(279, 38);
            this.txtWe.TabIndex = 93;
            // 
            // txtHe
            // 
            this.txtHe.Enabled = false;
            this.txtHe.Location = new System.Drawing.Point(1131, 353);
            this.txtHe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHe.Name = "txtHe";
            this.txtHe.Size = new System.Drawing.Size(279, 38);
            this.txtHe.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(885, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 32);
            this.label13.TabIndex = 91;
            this.label13.Text = "Height:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1552, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 32);
            this.label12.TabIndex = 90;
            this.label12.Text = "Width:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(880, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 32);
            this.label11.TabIndex = 89;
            this.label11.Text = "Length:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1552, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 32);
            this.label10.TabIndex = 88;
            this.label10.Text = "Unit:";
            // 
            // txtQu
            // 
            this.txtQu.Location = new System.Drawing.Point(1131, 193);
            this.txtQu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQu.Name = "txtQu";
            this.txtQu.Size = new System.Drawing.Size(279, 38);
            this.txtQu.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(880, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 32);
            this.label9.TabIndex = 86;
            this.label9.Text = "Quantity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(880, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 32);
            this.label8.TabIndex = 85;
            this.label8.Text = "Description:";
            // 
            // txtPID
            // 
            this.txtPID.Enabled = false;
            this.txtPID.Location = new System.Drawing.Point(1808, 31);
            this.txtPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(279, 38);
            this.txtPID.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1552, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 32);
            this.label7.TabIndex = 83;
            this.label7.Text = "Product ID:";
            // 
            // txtOID
            // 
            this.txtOID.Enabled = false;
            this.txtOID.Location = new System.Drawing.Point(1131, 38);
            this.txtOID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOID.Name = "txtOID";
            this.txtOID.Size = new System.Drawing.Size(279, 38);
            this.txtOID.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(885, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 81;
            this.label2.Text = "Order ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(606, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 91);
            this.btnSearch.TabIndex = 80;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(37, 739);
            this.dg1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.Size = new System.Drawing.Size(2096, 572);
            this.dg1.TabIndex = 79;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellClick);
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(267, 14);
            this.txtcname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(273, 38);
            this.txtcname.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 77;
            this.label1.Text = "Customer Name";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(426, 1331);
            this.btnReset.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(335, 95);
            this.btnReset.TabIndex = 122;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(40, 1331);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(333, 95);
            this.btnBack.TabIndex = 123;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2152, 1452);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtRw);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.comOrder);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtLo);
            this.Controls.Add(this.txtCO);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtNa);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtEp);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtLe);
            this.Controls.Add(this.txtWi);
            this.Controls.Add(this.txtWe);
            this.Controls.Add(this.txtHe);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRw;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comOrder;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLo;
        private System.Windows.Forms.TextBox txtCO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtNa;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLe;
        private System.Windows.Forms.TextBox txtWi;
        private System.Windows.Forms.TextBox txtWe;
        private System.Windows.Forms.TextBox txtHe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
    }
}