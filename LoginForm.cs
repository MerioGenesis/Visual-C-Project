using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

    

        /// <summary>
        /// Enables tooltip message for textboxes Username and Password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtBoxUsername, "Enter username provided in the manual");
            toolTip1.SetToolTip(txtBoxPassword, "Enter password provided in the manual");
        }

        /// <summary>
        /// Login function that enables logging in to the main form. It uses boolean function, that has set strings, which then have to be true within this function
        /// in order for the user to succesfully log in.
        /// </summary>
        private void Login()
        {
            string username;
            string password;

            username = txtBoxUsername.Text;
            password = txtBoxPassword.Text;

            if(LoginCorrect(username, password))
            {
                MessageBox.Show("Login successful. Welcome to Mobile Phone App");
                
                //Hides login form upon successful login
                this.Hide();

                //Opens Main Mobile Form
                MainForm main = new MainForm();
                main.Show();
                
                

            }

            //If login failed due to wrong credentials
            else
            {
                MessageBox.Show("Invalid login credentials. Please try again");
                txtBoxUsername.Text = "";
                txtBoxPassword.Text = "";
            }

            

        }

        /// <summary>
        /// Boolean that sets strings, which then are used in Login() function
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool LoginCorrect(string username, string password)
        {

            return username == "admin" && password == "admin01";
        }

        /// <summary>
        /// Calls for Login() function to take place when the button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        /// <summary>
        /// Changes a color of the button upon hover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.CornflowerBlue;
        }


        /// <summary>
        /// Changes the color to original color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.MidnightBlue;
        }

     
    }
}
