namespace WindowsFormsApp4
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.cmbSelectCustomer = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.cmbPlanType = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("SimSun-ExtB", 15F);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAddCustomer.Location = new System.Drawing.Point(91, 447);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(140, 45);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddBill.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("SimSun-ExtB", 15F);
            this.btnAddBill.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAddBill.Location = new System.Drawing.Point(284, 446);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(140, 46);
            this.btnAddBill.TabIndex = 62;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // cmbSelectCustomer
            // 
            this.cmbSelectCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.cmbSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectCustomer.Font = new System.Drawing.Font("SimSun-ExtB", 11F);
            this.cmbSelectCustomer.FormattingEnabled = true;
            this.cmbSelectCustomer.Location = new System.Drawing.Point(297, 167);
            this.cmbSelectCustomer.Name = "cmbSelectCustomer";
            this.cmbSelectCustomer.Size = new System.Drawing.Size(189, 23);
            this.cmbSelectCustomer.TabIndex = 61;
            this.cmbSelectCustomer.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.Color.GhostWhite;
            this.Label11.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(18, 167);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(142, 16);
            this.Label11.TabIndex = 60;
            this.Label11.Text = "Select Customer";
            // 
            // cmbPlanType
            // 
            this.cmbPlanType.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPlanType.Font = new System.Drawing.Font("SimSun-ExtB", 11F);
            this.cmbPlanType.FormattingEnabled = true;
            this.cmbPlanType.Items.AddRange(new object[] {
            "3G",
            "4G",
            "5G"});
            this.cmbPlanType.Location = new System.Drawing.Point(297, 382);
            this.cmbPlanType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlanType.Name = "cmbPlanType";
            this.cmbPlanType.Size = new System.Drawing.Size(153, 23);
            this.cmbPlanType.TabIndex = 58;
            this.cmbPlanType.Text = "Choose Plan Type";
            this.cmbPlanType.SelectedIndexChanged += new System.EventHandler(this.cmbPlanType_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.GhostWhite;
            this.Label7.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(18, 389);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(88, 16);
            this.Label7.TabIndex = 57;
            this.Label7.Text = "Plan Type";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerPhone.Font = new System.Drawing.Font("SimSun-ExtB", 11F);
            this.txtCustomerPhone.Location = new System.Drawing.Point(297, 238);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(153, 22);
            this.txtCustomerPhone.TabIndex = 54;
            this.txtCustomerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerPhone_KeyPress);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.GhostWhite;
            this.Label5.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(18, 240);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(133, 16);
            this.Label5.TabIndex = 53;
            this.Label5.Text = "Customer Phone";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerAddress.Font = new System.Drawing.Font("SimSun-ExtB", 11F);
            this.txtCustomerAddress.Location = new System.Drawing.Point(297, 287);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(153, 77);
            this.txtCustomerAddress.TabIndex = 51;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.txtCustomerName.Font = new System.Drawing.Font("SimSun-ExtB", 11F);
            this.txtCustomerName.Location = new System.Drawing.Point(297, 201);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(153, 22);
            this.txtCustomerName.TabIndex = 50;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.GhostWhite;
            this.Label3.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(18, 291);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(70, 16);
            this.Label3.TabIndex = 49;
            this.Label3.Text = "Address";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.GhostWhite;
            this.Label2.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(18, 205);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(124, 16);
            this.Label2.TabIndex = 48;
            this.Label2.Text = "Customer Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Font = new System.Drawing.Font("SimSun-ExtB", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(65, 22);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(376, 55);
            this.Label1.TabIndex = 47;
            this.Label1.Text = "Customer Form";
            
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 489);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMainMenu.Font = new System.Drawing.Font("SimSun-ExtB", 15F);
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(187, 523);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(140, 56);
            this.btnMainMenu.TabIndex = 64;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(519, 600);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.cmbSelectCustomer);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.cmbPlanType);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.Text = "Mobile Phone App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        internal System.Windows.Forms.Button btnAddBill;
        internal System.Windows.Forms.ComboBox cmbSelectCustomer;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ComboBox cmbPlanType;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtCustomerPhone;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCustomerAddress;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMainMenu;
    }
}