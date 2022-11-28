namespace PetShopBoys
{
    partial class items
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.newUserMenu = new System.Windows.Forms.MenuStrip();
            this.editUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseItemsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.petsAvailableMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.newUserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(299, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 31);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 84);
            this.label1.TabIndex = 10;
            this.label1.Text = "Search by";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(38, 463);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(154, 59);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // newUserMenu
            // 
            this.newUserMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.newUserMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.newUserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserMenuItem,
            this.browseItemsMenu,
            this.petsAvailableMenuStrip,
            this.shoppingCartMenuItem});
            this.newUserMenu.Location = new System.Drawing.Point(0, 0);
            this.newUserMenu.Name = "newUserMenu";
            this.newUserMenu.Size = new System.Drawing.Size(743, 40);
            this.newUserMenu.TabIndex = 16;
            this.newUserMenu.Text = "menuStrip1";
            // 
            // editUserMenuItem
            // 
            this.editUserMenuItem.Name = "editUserMenuItem";
            this.editUserMenuItem.Size = new System.Drawing.Size(128, 36);
            this.editUserMenuItem.Text = "Edit User";
            this.editUserMenuItem.Click += new System.EventHandler(this.editUserMenuItem_Click);
            // 
            // browseItemsMenu
            // 
            this.browseItemsMenu.Name = "browseItemsMenu";
            this.browseItemsMenu.Size = new System.Drawing.Size(175, 36);
            this.browseItemsMenu.Text = "Browse Items";
            // 
            // petsAvailableMenuStrip
            // 
            this.petsAvailableMenuStrip.Name = "petsAvailableMenuStrip";
            this.petsAvailableMenuStrip.Size = new System.Drawing.Size(180, 36);
            this.petsAvailableMenuStrip.Text = "Pets Available";
            this.petsAvailableMenuStrip.Click += new System.EventHandler(this.petsAvailableMenuStrip_Click);
            // 
            // shoppingCartMenuItem
            // 
            this.shoppingCartMenuItem.Name = "shoppingCartMenuItem";
            this.shoppingCartMenuItem.Size = new System.Drawing.Size(187, 36);
            this.shoppingCartMenuItem.Text = "Shopping Cart";
            this.shoppingCartMenuItem.Click += new System.EventHandler(this.shoppingCartMenuItem_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(38, 548);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(154, 59);
            this.addItemButton.TabIndex = 27;
            this.addItemButton.Text = "Add to Cart:";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PetShopBoys.Properties.Resources.pexels_pixabay_104827;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(38, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 185);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 25;
            this.itemsListBox.Location = new System.Drawing.Point(299, 232);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(402, 179);
            this.itemsListBox.TabIndex = 28;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(299, 457);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(402, 288);
            this.dataGridView.TabIndex = 29;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(38, 638);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(154, 59);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Remove from Cart:";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 773);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newUserMenu);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "items";
            this.Text = "itemsForm";
            this.Load += new System.EventHandler(this.items_Load);
            this.newUserMenu.ResumeLayout(false);
            this.newUserMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MenuStrip newUserMenu;
        private System.Windows.Forms.ToolStripMenuItem editUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseItemsMenu;
        private System.Windows.Forms.ToolStripMenuItem petsAvailableMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button deleteButton;
    }
}