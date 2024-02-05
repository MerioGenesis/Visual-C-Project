using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WindowsFormsApp4.SupportFile;

namespace WindowsFormsApp4
{
    public partial class StatementForm : Form
    {
        public static int CNbOfMinutes;
        public static int CNbofText;
        public static int CNbofData;

        public static int Min;
        public static int Texts;
        public static int Data;




        public StatementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Upon loading form, it reads data from the text file as well as sets text fields to empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatementForm_Load(object sender, EventArgs e)
        {
            // allocating memory for the arrays in CostByMonth---Very important
            for (int i = 0; i < SupportFile.StudentList.Length; i++)
            { SupportFile.StudentList[i].month = new SupportFile.student.CostByMonth[12]; }
           
            
            SupportFile.PopulateCustomers(ref cmbSelectCustomer, ref SupportFile.StudentList);

            lblCustomer.Text = "";
            lblCustomerPlan.Text = "";
            lblCustomerPhone.Text = "";
            lblCustomerAddress.Text = "";
        }

        /// <summary>
        /// Resets the values to their default, which is empty, when index is changed in the customer selection combobox.
        /// Additionally, data is being collected from the text file using Support File, which then fills the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBill.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
            numMinutes.Value = 0;
            numText.Value = 0;
            numData.Value = 0;
            txtTariffCost.Text = "";
            txtDataCost.Text = "";
            txtDataCost.Text = "";
            txtTextsCost.Text = "";
            txtMinutesCost.Text = "";
            txtTaxCost.Text = "";
            txtGrandTotal.Text = "";

            SupportFile.ShowCustomer(cmbSelectCustomer.SelectedIndex);
            lblCustomer.Text = CustomerForm.CName;
            lblCustomerAddress.Text = CustomerForm.CAddress;
            lblCustomerPhone.Text = CustomerForm.CPhone;
            lblCustomerPlan.Text = CustomerForm.CPlan;
            txtTariffCost.Text= CustomerForm.CPlan;

           

            
        }


        /// <summary>
        /// Firstly, upon pressing the button "Add Bill", it is checked whether all the fields are filled in, and a prompt message is being displayed if not
        /// If everything is being filled out, then the bill information is being stored in the text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btmAddBill_Click(object sender, EventArgs e)
        {
            {
                if (cmbSelectCustomer.SelectedIndex == -1)
                {
                    MessageBox.Show("You have to select a customer to add the bill");
                }
               

                else if (cmbMonth.SelectedIndex == -1)
                {
                    MessageBox.Show("You have to select a month to add the bill");

                }


                else if (numMinutes.Value == 0)
                {
                    MessageBox.Show("You have not entered any minutes");
                }


                else if (numText.Value == 0)
                {
                    MessageBox.Show("You have not entered any texts used");

                }

                else if (numData.Value == 0)
                {
                    MessageBox.Show("You have not entered any data used");

                }


                else
                {
                    CNbOfMinutes = Convert.ToInt32(numMinutes.Text);
                    CNbofText = Convert.ToInt32(numText.Text);
                    CNbofData = Convert.ToInt32(numData.Text);

                    SupportFile.TakeData(ref SupportFile.StudentList, cmbSelectCustomer.SelectedIndex, cmbMonth.SelectedIndex);
                    SupportFile.saveData(SupportFile.StudentList);

                }
            }

         
        }

        /// <summary>
        /// Reads the data from text file to fill out bill information in apprioprate textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupportFile.ShowCustomerbill(cmbSelectCustomer.SelectedIndex, cmbMonth.SelectedIndex);
            numMinutes.Text = CNbOfMinutes.ToString();
            numText.Text=CNbofText.ToString();
            numData.Text=CNbofData.ToString();

        }


        /// <summary>
        /// Function to calculate extra cost of minutes
        /// </summary>
        private void CalcMin()
        {
            
            double MinCost;

            MinCost = 0;

            if (numMinutes.Value> 500)
            {
                MinCost = ((double)numMinutes.Value - 500) * 0.2;

            }
            else
            {

            }
            txtMinutesCost.Text = Convert.ToString(MinCost);
        }

        /// <summary>
        /// Function to calculate extra cost of texts
        /// </summary>
        private void CalcText()
        {
            double TextCost;

            TextCost = 0;

            if (numText.Value > 500)
            {
                TextCost = ((double)numText.Value - 500) * 0.1;

            }

            else
            {

            }
            txtTextsCost.Text = Convert.ToString(TextCost);

        }

        /// <summary>
        /// Function to calculate extra cost of data
        /// </summary>
        private void CalcData()
        {
            double DataCost;
            DataCost = 0;

            if (numData.Value > 500)
            {
                DataCost = ((double)numData.Value - 500) * 0.5;

            }
            else
            {

            }
            txtDataCost.Text = Convert.ToString(DataCost);

        }

        /// <summary>
        /// Function that calculates VAT and final bill. It takes the values from the previous fields and does appropriate calculation.
        /// Additionally, it adds pound sign for display purposes
        /// </summary>
        private void FinalandVAT()
        {
            double finalpay;
            double VAT;
            string plan;
            double mins;
            double texts;
            double data;

            
            plan = txtTariffCost.Text;
            mins = double.Parse(txtMinutesCost.Text);
            texts =double.Parse(txtTextsCost.Text);
            data = double.Parse(txtDataCost.Text);

            if (plan == "3G")
            {
                plan = "10";
            }
            else if (plan == "4G")
            {
                plan = "20";

            }
            else
            {
                plan = "30";
            }

            

            VAT = (Convert.ToInt32(plan) + (double)mins + (double)texts + (double)data) * 0.2;
            txtTaxCost.Text = Convert.ToString(VAT);


            finalpay = Convert.ToInt32(plan) + VAT + mins + texts + data;


            txtGrandTotal.Text = Convert.ToString(finalpay) + "£";
            txtTaxCost.Text = txtTaxCost.Text + "£";            
            txtMinutesCost.Text = txtMinutesCost.Text + "£";
            txtTextsCost.Text = txtTextsCost.Text + "£";
            txtDataCost.Text = txtDataCost.Text + "£";



        }

       
        /// <summary>
        /// Clears the information upon pressing the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbBill.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;
            numMinutes.Value = 0;
            numText.Value = 0;
            numData.Value = 0;
            txtTariffCost.Text = "";
            txtDataCost.Text = "";
            txtDataCost.Text = "";
            txtTextsCost.Text = "";
            txtMinutesCost.Text = "";
            txtTaxCost.Text = "";
            txtGrandTotal.Text = "";
        }

        /// <summary>
        /// Function to calculate the bill. Firstly, it is being checked if the customer is being selected based on the index value in the customer selection combobox.
        /// If customer is being selected, then following functions are being called: CalcMin, CalcText, CalcData and FinalandVat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (cmbSelectCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Select a customer to calculate the bill");

            }
            else
            {
                CalcMin();
                CalcText();
                CalcData();
                FinalandVAT();
            }
        }

        /// <summary>
        /// Hides current form, and opens main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm SForm = new MainForm();
            SForm.Show();
        }

        
    }
}
