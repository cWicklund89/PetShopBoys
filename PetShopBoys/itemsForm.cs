using System;
using System.IO;
using System.Windows.Forms;


namespace PetShopBoys
{
    public partial class items : Form
    {
        public items()
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
        /// SHOWS PETS AVAILABLE FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petsAvailableMenuStrip_Click(object sender, EventArgs e)
        {
            petsAvailable pa = new petsAvailable();
            pa.ShowDialog();
        }

        /// <summary>
        /// SHOWS SHOPPING CART FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shoppingCartMenuItem_Click(object sender, EventArgs e)
        {
            shoppingCart sc = new shoppingCart();
            sc.ShowDialog();
        }

        private void items_Load(object sender, EventArgs e)
        {
            

            var fileName = "pets.txt";
            if (File.Exists(fileName))
            {
                StreamReader textFile = new StreamReader(fileName);
                string pets;

                while ((pets = textFile.ReadLine()) != null)
                {
                    itemsListBox.Items.Add(pets);
                }
        }
        }
    }
}
