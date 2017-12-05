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
            this.comOrder = new System.Windows.Forms.ComboBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLo = new System.Windows.Forms.TextBox();
            this.txtCO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Customer = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Customer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comOrder
            // 
            this.comOrder.FormattingEnabled = true;
            this.comOrder.Items.AddRange(new object[] {
            "CHECK IN DATE ",
            "EXPIRATION DATE "});
            this.comOrder.Location = new System.Drawing.Point(252, 635);
            this.comOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comOrder.Name = "comOrder";
            this.comOrder.Size = new System.Drawing.Size(273, 39);
            this.comOrder.TabIndex = 119;
            this.comOrder.SelectedIndexChanged += new System.EventHandler(this.comOrder_SelectedIndexChanged);
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(252, 540);
            this.txtPN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(273, 38);
            this.txtPN.TabIndex = 118;
            this.txtPN.TextChanged += new System.EventHandler(this.txtPN_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 537);
            this.label18.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(203, 32);
            this.label18.TabIndex = 117;
            this.label18.Text = "Product Name:";
            // 
            // txtLo
            // 
            this.txtLo.Enabled = false;
            this.txtLo.Location = new System.Drawing.Point(1406, 619);
            this.txtLo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLo.Name = "txtLo";
            this.txtLo.Size = new System.Drawing.Size(279, 38);
            this.txtLo.TabIndex = 116;
            // 
            // txtCO
            // 
            this.txtCO.Location = new System.Drawing.Point(419, 631);
            this.txtCO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCO.Name = "txtCO";
            this.txtCO.Size = new System.Drawing.Size(279, 38);
            this.txtCO.TabIndex = 115;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1050, 625);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 32);
            this.label17.TabIndex = 114;
            this.label17.Text = "Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 625);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 32);
            this.label6.TabIndex = 113;
            this.label6.Text = "Check out";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(176, 694);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(260, 38);
            this.txtTotal.TabIndex = 111;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(176, 605);
            this.txtTax.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(260, 38);
            this.txtTax.TabIndex = 110;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(176, 512);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(260, 38);
            this.txtPrice.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 691);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 108;
            this.label5.Text = "total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 605);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 107;
            this.label4.Text = "tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 515);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 106;
            this.label3.Text = "price:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(97, 735);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(260, 64);
            this.btnCheckOut.TabIndex = 105;
            this.btnCheckOut.Text = "Check Out ";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(419, 175);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(279, 38);
            this.txtDesc.TabIndex = 104;
            // 
            // txtUnit
            // 
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(1406, 260);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(279, 38);
            this.txtUnit.TabIndex = 103;
            // 
            // txtNa
            // 
            this.txtNa.Enabled = false;
            this.txtNa.Location = new System.Drawing.Point(1406, 181);
            this.txtNa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNa.Name = "txtNa";
            this.txtNa.Size = new System.Drawing.Size(279, 38);
            this.txtNa.TabIndex = 102;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1050, 181);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 32);
            this.label20.TabIndex = 101;
            this.label20.Text = "Name:";
            // 
            // txtCI
            // 
            this.txtCI.Enabled = false;
            this.txtCI.Location = new System.Drawing.Point(1406, 532);
            this.txtCI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(279, 38);
            this.txtCI.TabIndex = 100;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1050, 541);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 32);
            this.label16.TabIndex = 99;
            this.label16.Text = "Check In";
            // 
            // txtEp
            // 
            this.txtEp.Enabled = false;
            this.txtEp.Location = new System.Drawing.Point(419, 535);
            this.txtEp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEp.Name = "txtEp";
            this.txtEp.Size = new System.Drawing.Size(279, 38);
            this.txtEp.TabIndex = 98;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 535);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 32);
            this.label15.TabIndex = 97;
            this.label15.Text = "Expire Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1052, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 32);
            this.label14.TabIndex = 96;
            this.label14.Text = "Weight:";
            // 
            // txtLe
            // 
            this.txtLe.Enabled = false;
            this.txtLe.Location = new System.Drawing.Point(419, 360);
            this.txtLe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLe.Name = "txtLe";
            this.txtLe.Size = new System.Drawing.Size(279, 38);
            this.txtLe.TabIndex = 95;
            // 
            // txtWi
            // 
            this.txtWi.Enabled = false;
            this.txtWi.Location = new System.Drawing.Point(1406, 357);
            this.txtWi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWi.Name = "txtWi";
            this.txtWi.Size = new System.Drawing.Size(279, 38);
            this.txtWi.TabIndex = 94;
            // 
            // txtWe
            // 
            this.txtWe.Enabled = false;
            this.txtWe.Location = new System.Drawing.Point(1406, 453);
            this.txtWe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWe.Name = "txtWe";
            this.txtWe.Size = new System.Drawing.Size(279, 38);
            this.txtWe.TabIndex = 93;
            // 
            // txtHe
            // 
            this.txtHe.Enabled = false;
            this.txtHe.Location = new System.Drawing.Point(419, 442);
            this.txtHe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHe.Name = "txtHe";
            this.txtHe.Size = new System.Drawing.Size(279, 38);
            this.txtHe.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(96, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 32);
            this.label13.TabIndex = 91;
            this.label13.Text = "Height:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1052, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 32);
            this.label12.TabIndex = 90;
            this.label12.Text = "Width:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 32);
            this.label11.TabIndex = 89;
            this.label11.Text = "Length:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1050, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 32);
            this.label10.TabIndex = 88;
            this.label10.Text = "Unit:";
            // 
            // txtQu
            // 
            this.txtQu.Enabled = false;
            this.txtQu.Location = new System.Drawing.Point(419, 266);
            this.txtQu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQu.Name = "txtQu";
            this.txtQu.Size = new System.Drawing.Size(279, 38);
            this.txtQu.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 32);
            this.label9.TabIndex = 86;
            this.label9.Text = "Quantity:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 32);
            this.label8.TabIndex = 85;
            this.label8.Text = "Description:";
            // 
            // txtPID
            // 
            this.txtPID.Enabled = false;
            this.txtPID.Location = new System.Drawing.Point(1406, 93);
            this.txtPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(279, 38);
            this.txtPID.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1050, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 32);
            this.label7.TabIndex = 83;
            this.label7.Text = "Product ID:";
            // 
            // txtOID
            // 
            this.txtOID.Enabled = false;
            this.txtOID.Location = new System.Drawing.Point(419, 96);
            this.txtOID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOID.Name = "txtOID";
            this.txtOID.Size = new System.Drawing.Size(279, 38);
            this.txtOID.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 81;
            this.label2.Text = "Order ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(252, 212);
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
            this.dg1.Location = new System.Drawing.Point(37, 884);
            this.dg1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.Size = new System.Drawing.Size(3149, 566);
            this.dg1.TabIndex = 79;
            this.dg1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellClick);
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(252, 101);
            this.txtcname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(273, 38);
            this.txtcname.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-6, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 77;
            this.label1.Text = "Customer Name";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(399, 1464);
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
            this.btnBack.Location = new System.Drawing.Point(37, 1464);
            this.btnBack.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(333, 95);
            this.btnBack.TabIndex = 123;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNa);
            this.groupBox1.Controls.Add(this.txtCO);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.btnCheckOut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtLo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtOID);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtQu);
            this.groupBox1.Controls.Add(this.txtLe);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEp);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtHe);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.txtWi);
            this.groupBox1.Controls.Add(this.txtWe);
            this.groupBox1.Controls.Add(this.txtCI);
            this.groupBox1.Location = new System.Drawing.Point(621, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1801, 809);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.btnSearch);
            this.Customer.Controls.Add(this.label1);
            this.Customer.Controls.Add(this.txtcname);
            this.Customer.Controls.Add(this.comOrder);
            this.Customer.Controls.Add(this.label18);
            this.Customer.Controls.Add(this.txtPN);
            this.Customer.Location = new System.Drawing.Point(37, 21);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(562, 722);
            this.Customer.TabIndex = 125;
            this.Customer.TabStop = false;
            this.Customer.Text = "Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTax);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(2446, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 796);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3184, 1728);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comOrder;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLo;
        private System.Windows.Forms.TextBox txtCO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Customer;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}