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
    public partial class shoppingCart : Form
    {
        public shoppingCart()
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
        /// BROWSE ITEMS FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseItemsMenu_Click(object sender, EventArgs e)
        {
            items it = new items();
            it.ShowDialog();
        }

        /// <summary>
        /// OPENS PETS AVAILABLE FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petsAvailableMenuItem_Click(object sender, EventArgs e)
        {
            petsAvailable pa = new petsAvailable(); 
            pa.ShowDialog();
        }

        /// <summary>
        /// OPENS ORDER HISTORY FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderHistoryMenuItem_Click(object sender, EventArgs e)
        {
            orderHistory oh = new orderHistory();
            oh.ShowDialog();
        }
    }
}
