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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetShopBoys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens Create New User Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewUserMenuItem_Click(object sender, EventArgs e)
        {
           newUser nu = new newUser();
            nu.ShowDialog();

        }

        /// <summary>
        /// Opens Items Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseItemsMenuItem_Click(object sender, EventArgs e)
        {
            items it = new items();
            it.ShowDialog();

        }

        /// <summary>
        /// Opens pets available form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petsAvailableMenuItem_Click(object sender, EventArgs e)
        {
            petsAvailable pa = new petsAvailable();
            pa.ShowDialog();
        }

        /// <summary>
        /// Opens shopping cart form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shoppingCart sc = new shoppingCart();
            sc.ShowDialog();
        }

        /// <summary>
        /// Checks for username and password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click_1(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Username and Password must be entered");
            }
            else
            {
                MessageBox.Show("Login Successful");
        
                items it = new items();
                it.ShowDialog();
             
            }
        }
    }
}
