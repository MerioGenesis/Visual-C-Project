using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp4.MainForm;

namespace WindowsFormsApp4
{
    public partial class CustomerForm : Form
    {
        StatementForm SForm =new StatementForm();
        public static string CName;
        public static string CAddress;
        public static string CPhone;
        public static string CPlan;





        public CustomerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a function to a button, that will add customer.
        /// 3 strings are allocated which are equal to user input in the texboxes.
        /// In addition there are security features to prevent user from making mistakes, and to ensure that all the fields are filled in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string name;
            string phonenum;
            string address;

            name = txtCustomerName.Text;
            phonenum = txtCustomerPhone.Text;
            address = txtCustomerAddress.Text;

            if (CustomerBool(name, phonenum, address))
            {
                MessageBox.Show("You need to fill out all customer fields!");

            }

            else if (cmbPlanType.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a plan type for the customer");
            }
           
            else

            {
                CName = txtCustomerName.Text;
                CAddress = txtCustomerAddress.Text;
                CPhone = txtCustomerPhone.Text;


                SupportFile.loaddata(ref SupportFile.StudentList);

                // allocating memory for the arrays in CostByMonth---Very important
                for (int i = 0; i < SupportFile.StudentList.Length; i++)
                    SupportFile.StudentList[i].month = new SupportFile.student.CostByMonth[12];
                SupportFile.addStudent(ref SupportFile.StudentList);
            }
         

        }

        /// <summary>
        /// A boolean function that is true if all three strings in the form are equal to ""; meaning that they are empty. Used in the add button, to prevent adding bills
        /// with unfilled textboxes
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phonenum"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        private bool CustomerBool(string name, string phonenum, string address)
        {

            return name == "" || phonenum == "" || address == "";
        }


        /// <summary>
        /// A function that will hide current form, and open Statement Form upon pressing a button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatementForm SForm = new StatementForm();
            SForm.Show();
        }
       
        /// <summary>
        /// Plan type selection combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPlanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPlan = cmbPlanType.Text;
        }

        /// <summary>
        /// This function populates customer data from the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            SupportFile.PopulateCustomers(ref cmbSelectCustomer, ref SupportFile.StudentList);
        }

        
        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Parent = null;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            SupportFile.ShowCustomer(cmbSelectCustomer.SelectedIndex);
            txtCustomerName.Text = CName;
            txtCustomerAddress.Text = CAddress;
            txtCustomerPhone.Text = CPhone;
            cmbPlanType.SelectedItem = CPlan;

        }

        /// <summary>
        /// Main menu function, that hides Customer Form and opens Main Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm SForm = new MainForm();
            SForm.Show();
        }

        /// <summary>
        /// Function that prevents user from typing numbers into the Customer name field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only letters are allowed in the Customer Name field!");
                e.Handled = true;
            }
        }

        /// <summary>
        /// Function that prevents user from typing letters into the Phone number field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Only numbers are allowed in the Phone Number field!");
                e.Handled = true;
            }
                
        }
    }
}
