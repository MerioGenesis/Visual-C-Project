namespace WindowsFormsApp4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1.Font = new System.Drawing.Font("SimSun", 40F);
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(41, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(430, 56);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Kingston Mobile";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(185, 375);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 50);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnAddCustomer_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnAddCustomer_MouseHover);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBill.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBill.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.Location = new System.Drawing.Point(185, 286);
            this.btnAddBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(144, 50);
            this.btnAddBill.TabIndex = 21;
            this.btnAddBill.Text = "Add Bill";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            this.btnAddBill.MouseLeave += new System.EventHandler(this.btnAddCustomer_MouseLeave);
            this.btnAddBill.MouseHover += new System.EventHandler(this.btnAddCustomer_MouseHover);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(185, 207);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(144, 50);
            this.btnAddCustomer.TabIndex = 20;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            this.btnAddCustomer.MouseLeave += new System.EventHandler(this.btnAddCustomer_MouseLeave);
            this.btnAddCustomer.MouseHover += new System.EventHandler(this.btnAddCustomer_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(143, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 314);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(516, 521);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mobile Phone App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnAddBill;
        internal System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

