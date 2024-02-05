using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    
    
    
    
    
    public partial class MainForm : Form
    {
        CustomerForm dd = new CustomerForm();
        //public static student[] StudentList = new student[1];
        public MainForm()
        {
            InitializeComponent();
        }
       

       
        /// <summary>
        /// Hides current form, and opens Custmer Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm dd = new CustomerForm();
            dd.Show();
        }

        /// <summary>
        /// Hides current form, and opens Statement Form
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
        /// Closes the aplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Changes the color of a button upon hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.CornflowerBlue;
        }

        /// <summary>
        /// Changes a color to original
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.LightSteelBlue;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
