using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///DONT FORGET ON OTHER PAGES
using System.IO;

namespace PetShopBoys
{
    public partial class newUser : Form
    {
        List<string> userNamesList = new List<string>();

        public newUser()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        /// <summary>
        /// IGNORE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            ///IGNORE
        }
        /// <summary>
        /// CORY IGNORE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewUserForm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Opens Pets Available form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petsAvailableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            petsAvailable pa = new petsAvailable();
            pa.ShowDialog();
        }

        /// <summary>
        /// Opens edit user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editUserMenuItem_Click(object sender, EventArgs e)
        {
            editUser eu = new editUser();
            eu.ShowDialog();
        }

        /// <summary>
        /// Opens shopping cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shoppingCartMenuItem_Click(object sender, EventArgs e)
        {
            shoppingCart sc = new shoppingCart();
            sc.ShowDialog();
        }

        /// <summary>
        /// SHOWS BROWSE ITEMS MENU 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseItemsMenuStrip_Click(object sender, EventArgs e)
        {
            items it = new items();
            it.ShowDialog();
        }

        /// <summary>
        /// Validate username text box cant leave blank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userNameTextBox_Leave(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("You can't leave this box blank");
                userNameTextBox.Focus();
            }
        }

        /// <summary>
        /// Validate password textbox cant leave blank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("You can't leave this box blank");
                passwordTextBox.Focus();
            }
        }

        /// <summary>
        /// Close out window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitUserButton_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                MessageBox.Show("Please Fix Any Errors.");

           

            try
            {
                StreamWriter outputFile;

                outputFile = File.AppendText("Username.txt");

                outputFile.WriteLine(userNameTextBox.Text);
                outputFile.WriteLine(passwordTextBox.Text);


                outputFile.Close();

                MessageBox.Show("Username and password have been saved to our records");
                this.Close();




            }
            catch
            {
                MessageBox.Show("");
            }
        }
    }
}

