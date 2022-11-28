using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopBoys
{
    public partial class orderHistory : Form
    {
        public orderHistory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SHOWS EDIT USER FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editUserMenuItem_Click(object sender, EventArgs e)
        {
            editUser eu = new editUser();
            eu.ShowDialog();
        }

        /// <summary>
        /// SHOWS BROWSE ITEMS FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseItemsMenu_Click(object sender, EventArgs e)
        {
            items it = new items();
            it.ShowDialog();
        }

        private void petsAvailableMenuItem_Click(object sender, EventArgs e)
        {
            petsAvailable pa = new petsAvailable();
            pa.ShowDialog();
        }
    }
}
