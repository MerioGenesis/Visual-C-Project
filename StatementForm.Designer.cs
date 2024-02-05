namespace WindowsFormsApp4
{
    partial class StatementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatementForm));
            this.Label11 = new System.Windows.Forms.Label();
            this.cmbSelectCustomer = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpBill = new System.Windows.Forms.GroupBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTaxCost = new System.Windows.Forms.TextBox();
            this.lblTariff = new System.Windows.Forms.Label();
            this.txtTextsCost = new System.Windows.Forms.TextBox();
            this.txtDataCost = new System.Windows.Forms.TextBox();
            this.txtTariffCost = new System.Windows.Forms.TextBox();
            this.txtMinutesCost = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTexts = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.cmbBill = new System.Windows.Forms.ComboBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblCustomerPlan = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.btmAddBill = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.numData = new System.Windows.Forms.NumericUpDown();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.grpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numText)).BeginInit();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(212, 95);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(142, 16);
            this.Label11.TabIndex = 26;
            this.Label11.Text = "Select Customer";
            // 
            // cmbSelectCustomer
            // 
            this.cmbSelectCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.cmbSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectCustomer.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCustomer.FormattingEnabled = true;
            this.cmbSelectCustomer.Location = new System.Drawing.Point(211, 114);
            this.cmbSelectCustomer.Name = "cmbSelectCustomer";
            this.cmbSelectCustomer.Size = new System.Drawing.Size(153, 21);
            this.cmbSelectCustomer.TabIndex = 25;
            this.cmbSelectCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCustomer_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("SimSun-ExtB", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(98, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(388, 54);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Statement Form";
            // 
            // grpBill
            // 
            this.grpBill.BackColor = System.Drawing.Color.Lavender;
            this.grpBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpBill.BackgroundImage")));
            this.grpBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpBill.Controls.Add(this.btnMainMenu);
            this.grpBill.Controls.Add(this.Calculate);
            this.grpBill.Controls.Add(this.txtGrandTotal);
            this.grpBill.Controls.Add(this.lblGrandTotal);
            this.grpBill.Controls.Add(this.btnClear);
            this.grpBill.Controls.Add(this.txtTaxCost);
            this.grpBill.Controls.Add(this.lblTariff);
            this.grpBill.Controls.Add(this.txtTextsCost);
            this.grpBill.Controls.Add(this.txtDataCost);
            this.grpBill.Controls.Add(this.txtTariffCost);
            this.grpBill.Controls.Add(this.txtMinutesCost);
            this.grpBill.Controls.Add(this.lblData);
            this.grpBill.Controls.Add(this.lblTexts);
            this.grpBill.Controls.Add(this.lblMinutes);
            this.grpBill.Controls.Add(this.lblBill);
            this.grpBill.Controls.Add(this.cmbBill);
            this.grpBill.Controls.Add(this.lblTax);
            this.grpBill.Controls.Add(this.lblCustomerAddress);
            this.grpBill.Controls.Add(this.cmbMonth);
            this.grpBill.Controls.Add(this.Label15);
            this.grpBill.Controls.Add(this.numMinutes);
            this.grpBill.Controls.Add(this.lblCustomerPlan);
            this.grpBill.Controls.Add(this.Label13);
            this.grpBill.Controls.Add(this.lblCustomerPhone);
            this.grpBill.Controls.Add(this.btmAddBill);
            this.grpBill.Controls.Add(this.Label10);
            this.grpBill.Controls.Add(this.numData);
            this.grpBill.Controls.Add(this.lblCustomer);
            this.grpBill.Controls.Add(this.Label6);
            this.grpBill.Controls.Add(this.Label8);
            this.grpBill.Controls.Add(this.Label5);
            this.grpBill.Controls.Add(this.numText);
            this.grpBill.Controls.Add(this.Label4);
            this.grpBill.Controls.Add(this.Label2);
            this.grpBill.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBill.ForeColor = System.Drawing.Color.Black;
            this.grpBill.Location = new System.Drawing.Point(32, 155);
            this.grpBill.Name = "grpBill";
            this.grpBill.Size = new System.Drawing.Size(563, 554);
            this.grpBill.TabIndex = 23;
            this.grpBill.TabStop = false;
            this.grpBill.Text = "Bill Details";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMainMenu.Font = new System.Drawing.Font("SimSun-ExtB", 15F);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(6, 492);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(140, 46);
            this.btnMainMenu.TabIndex = 65;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.MidnightBlue;
            this.Calculate.Font = new System.Drawing.Font("SimSun-ExtB", 15F);
            this.Calculate.ForeColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(378, 415);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(154, 61);
            this.Calculate.TabIndex = 40;
            this.Calculate.Text = "Calculate Bill";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.Moccasin;
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(431, 328);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(76, 23);
            this.txtGrandTotal.TabIndex = 39;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.Color.GhostWhite;
            this.lblGrandTotal.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotal.Location = new System.Drawing.Point(311, 331);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(115, 16);
            this.lblGrandTotal.TabIndex = 37;
            this.lblGrandTotal.Text = "Total to pay";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("SimSun-ExtB", 15F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(169, 341);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 47);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTaxCost
            // 
            this.txtTaxCost.BackColor = System.Drawing.SystemColors.Info;
            this.txtTaxCost.Enabled = false;
            this.txtTaxCost.Location = new System.Drawing.Point(431, 278);
            this.txtTaxCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTaxCost.Name = "txtTaxCost";
            this.txtTaxCost.Size = new System.Drawing.Size(76, 23);
            this.txtTaxCost.TabIndex = 35;
            // 
            // lblTariff
            // 
            this.lblTariff.AutoSize = true;
            this.lblTariff.BackColor = System.Drawing.Color.GhostWhite;
            this.lblTariff.Font = new System.Drawing.Font("SimSun-ExtB", 11F, System.Drawing.FontStyle.Bold);
            this.lblTariff.ForeColor = System.Drawing.Color.Black;
            this.lblTariff.Location = new System.Drawing.Point(325, 137);
            this.lblTariff.Name = "lblTariff";
            this.lblTariff.Size = new System.Drawing.Size(88, 15);
            this.lblTariff.TabIndex = 34;
            this.lblTariff.Text = "Plan Cost";
            // 
            // txtTextsCost
            // 
            this.txtTextsCost.BackColor = System.Drawing.SystemColors.Info;
            this.txtTextsCost.Enabled = false;
            this.txtTextsCost.Location = new System.Drawing.Point(431, 205);
            this.txtTextsCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTextsCost.Name = "txtTextsCost";
            this.txtTextsCost.Size = new System.Drawing.Size(76, 23);
            this.txtTextsCost.TabIndex = 33;
            // 
            // txtDataCost
            // 
            this.txtDataCost.BackColor = System.Drawing.SystemColors.Info;
            this.txtDataCost.Enabled = false;
            this.txtDataCost.Location = new System.Drawing.Point(431, 244);
            this.txtDataCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataCost.Name = "txtDataCost";
            this.txtDataCost.Size = new System.Drawing.Size(76, 23);
            this.txtDataCost.TabIndex = 32;
            // 
            // txtTariffCost
            // 
            this.txtTariffCost.BackColor = System.Drawing.SystemColors.Info;
            this.txtTariffCost.Enabled = false;
            this.txtTariffCost.Location = new System.Drawing.Point(431, 135);
            this.txtTariffCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTariffCost.Name = "txtTariffCost";
            this.txtTariffCost.Size = new System.Drawing.Size(76, 23);
            this.txtTariffCost.TabIndex = 31;
            // 
            // txtMinutesCost
            // 
            this.txtMinutesCost.BackColor = System.Drawing.SystemColors.Info;
            this.txtMinutesCost.Enabled = false;
            this.txtMinutesCost.Location = new System.Drawing.Point(431, 168);
            this.txtMinutesCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinutesCost.Name = "txtMinutesCost";
            this.txtMinutesCost.Size = new System.Drawing.Size(76, 23);
            this.txtMinutesCost.TabIndex = 30;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.GhostWhite;
            this.lblData.Font = new System.Drawing.Font("SimSun-ExtB", 11F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(325, 242);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(97, 15);
            this.lblData.TabIndex = 29;
            this.lblData.Text = "Extra Cost";
            // 
            // lblTexts
            // 
            this.lblTexts.AutoSize = true;
            this.lblTexts.BackColor = System.Drawing.Color.GhostWhite;
            this.lblTexts.Font = new System.Drawing.Font("SimSun-ExtB", 11F, System.Drawing.FontStyle.Bold);
            this.lblTexts.ForeColor = System.Drawing.Color.Black;
            this.lblTexts.Location = new System.Drawing.Point(325, 207);
            this.lblTexts.Name = "lblTexts";
            this.lblTexts.Size = new System.Drawing.Size(97, 15);
            this.lblTexts.TabIndex = 28;
            this.lblTexts.Text = "Extra Cost";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.GhostWhite;
            this.lblMinutes.Font = new System.Drawing.Font("SimSun-ExtB", 11F, System.Drawing.FontStyle.Bold);
            this.lblMinutes.ForeColor = System.Drawing.Color.Black;
            this.lblMinutes.Location = new System.Drawing.Point(325, 170);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(97, 15);
            this.lblMinutes.TabIndex = 27;
            this.lblMinutes.Text = "Extra Cost";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.GhostWhite;
            this.lblBill.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.Black;
            this.lblBill.Location = new System.Drawing.Point(15, 116);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(95, 13);
            this.lblBill.TabIndex = 14;
            this.lblBill.Text = "Select Bill";
            this.lblBill.Visible = false;
            // 
            // cmbBill
            // 
            this.cmbBill.BackColor = System.Drawing.SystemColors.Info;
            this.cmbBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBill.FormattingEnabled = true;
            this.cmbBill.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.cmbBill.Location = new System.Drawing.Point(127, 108);
            this.cmbBill.Name = "cmbBill";
            this.cmbBill.Size = new System.Drawing.Size(153, 24);
            this.cmbBill.TabIndex = 13;
            this.cmbBill.Visible = false;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.GhostWhite;
            this.lblTax.Font = new System.Drawing.Font("SimSun-ExtB", 11F, System.Drawing.FontStyle.Bold);
            this.lblTax.ForeColor = System.Drawing.Color.Black;
            this.lblTax.Location = new System.Drawing.Point(325, 278);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(70, 15);
            this.lblTax.TabIndex = 25;
            this.lblTax.Text = "VAT 20%";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCustomerAddress.Location = new System.Drawing.Point(423, 51);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(117, 13);
            this.lblCustomerAddress.TabIndex = 24;
            this.lblCustomerAddress.Text = "lblCustomerAddress";
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.SystemColors.Info;
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.cmbMonth.Location = new System.Drawing.Point(127, 82);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(153, 24);
            this.cmbMonth.TabIndex = 2;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.GhostWhite;
            this.Label15.Font = new System.Drawing.Font("SimSun-ExtB", 10F, System.Drawing.FontStyle.Bold);
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(276, 51);
            this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(135, 14);
            this.Label15.TabIndex = 23;
            this.Label15.Text = "Customer Address";
            // 
            // numMinutes
            // 
            this.numMinutes.BackColor = System.Drawing.SystemColors.Info;
            this.numMinutes.Location = new System.Drawing.Point(127, 217);
            this.numMinutes.Maximum = new decimal(new int[] {
            44640,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(153, 23);
            this.numMinutes.TabIndex = 7;
            // 
            // lblCustomerPlan
            // 
            this.lblCustomerPlan.AutoSize = true;
            this.lblCustomerPlan.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPlan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCustomerPlan.Location = new System.Drawing.Point(137, 51);
            this.lblCustomerPlan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerPlan.Name = "lblCustomerPlan";
            this.lblCustomerPlan.Size = new System.Drawing.Size(97, 13);
            this.lblCustomerPlan.TabIndex = 22;
            this.lblCustomerPlan.Text = "lblCustomerPlan";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.GhostWhite;
            this.Label13.Font = new System.Drawing.Font("SimSun-ExtB", 10F, System.Drawing.FontStyle.Bold);
            this.Label13.ForeColor = System.Drawing.Color.Black;
            this.Label13.Location = new System.Drawing.Point(11, 51);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(111, 14);
            this.Label13.TabIndex = 21;
            this.Label13.Text = "Customer Plan";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCustomerPhone.Location = new System.Drawing.Point(423, 28);
            this.lblCustomerPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(108, 13);
            this.lblCustomerPhone.TabIndex = 20;
            this.lblCustomerPhone.Text = "lblCustomerPhone";
            // 
            // btmAddBill
            // 
            this.btmAddBill.BackColor = System.Drawing.Color.MidnightBlue;
            this.btmAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmAddBill.Font = new System.Drawing.Font("SimSun-ExtB", 15F);
            this.btmAddBill.ForeColor = System.Drawing.Color.White;
            this.btmAddBill.Location = new System.Drawing.Point(14, 341);
            this.btmAddBill.Name = "btmAddBill";
            this.btmAddBill.Size = new System.Drawing.Size(97, 47);
            this.btmAddBill.TabIndex = 12;
            this.btmAddBill.Text = "Add Bill";
            this.btmAddBill.UseVisualStyleBackColor = false;
            this.btmAddBill.Click += new System.EventHandler(this.btmAddBill_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.BackColor = System.Drawing.Color.GhostWhite;
            this.Label10.Font = new System.Drawing.Font("SimSun-ExtB", 10F, System.Drawing.FontStyle.Bold);
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(276, 28);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(119, 14);
            this.Label10.TabIndex = 19;
            this.Label10.Text = "Customer Phone";
            // 
            // numData
            // 
            this.numData.BackColor = System.Drawing.SystemColors.Info;
            this.numData.Location = new System.Drawing.Point(127, 289);
            this.numData.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numData.Name = "numData";
            this.numData.Size = new System.Drawing.Size(153, 23);
            this.numData.TabIndex = 11;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCustomer.Location = new System.Drawing.Point(137, 28);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 13);
            this.lblCustomer.TabIndex = 18;
            this.lblCustomer.Text = "lblCustomer";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.GhostWhite;
            this.Label6.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(15, 296);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(79, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Data Used";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.GhostWhite;
            this.Label8.Font = new System.Drawing.Font("SimSun-ExtB", 10F, System.Drawing.FontStyle.Bold);
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(11, 28);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(111, 14);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Customer Name";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.GhostWhite;
            this.Label5.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(15, 261);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 13);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Texts Used";
            // 
            // numText
            // 
            this.numText.BackColor = System.Drawing.SystemColors.Info;
            this.numText.Location = new System.Drawing.Point(127, 254);
            this.numText.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(153, 23);
            this.numText.TabIndex = 8;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.GhostWhite;
            this.Label4.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(15, 224);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Minutes Used";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.GhostWhite;
            this.Label2.Font = new System.Drawing.Font("SimSun-ExtB", 11F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(15, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 15);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Month";
            // 
            // StatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(621, 721);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.cmbSelectCustomer);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.grpBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatementForm";
            this.Text = "Mobile Phone App";
            this.Load += new System.EventHandler(this.StatementForm_Load);
            this.grpBill.ResumeLayout(false);
            this.grpBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ComboBox cmbSelectCustomer;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox grpBill;
        internal System.Windows.Forms.TextBox txtGrandTotal;
        internal System.Windows.Forms.Label lblGrandTotal;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.TextBox txtTaxCost;
        internal System.Windows.Forms.Label lblTariff;
        internal System.Windows.Forms.TextBox txtTextsCost;
        internal System.Windows.Forms.TextBox txtDataCost;
        internal System.Windows.Forms.TextBox txtTariffCost;
        internal System.Windows.Forms.TextBox txtMinutesCost;
        internal System.Windows.Forms.Label lblData;
        internal System.Windows.Forms.Label lblTexts;
        internal System.Windows.Forms.Label lblMinutes;
        internal System.Windows.Forms.Label lblBill;
        internal System.Windows.Forms.ComboBox cmbBill;
        internal System.Windows.Forms.Label lblTax;
        internal System.Windows.Forms.Label lblCustomerAddress;
        internal System.Windows.Forms.ComboBox cmbMonth;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.NumericUpDown numMinutes;
        internal System.Windows.Forms.Label lblCustomerPlan;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label lblCustomerPhone;
        internal System.Windows.Forms.Button btmAddBill;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.NumericUpDown numData;
        internal System.Windows.Forms.Label lblCustomer;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.NumericUpDown numText;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button btnMainMenu;
    }
}