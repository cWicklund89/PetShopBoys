namespace PetShopBoys
{
    partial class editUser
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newUserMenu = new System.Windows.Forms.MenuStrip();
            this.editUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseItemsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.petsAvailableMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(387, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 31);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 31);
            this.textBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(349, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change Password:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edit Name:";

            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 84);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pet Shop        Edit User:";

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 84);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit Changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newUserMenu
            // 
            this.newUserMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.newUserMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.newUserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserMenuItem,
            this.browseItemsMenu,
            this.petsAvailableMenuItem,
            this.shoppingCartMenuItem});
            this.newUserMenu.Location = new System.Drawing.Point(0, 0);
            this.newUserMenu.Name = "newUserMenu";
            this.newUserMenu.Size = new System.Drawing.Size(800, 42);
            this.newUserMenu.TabIndex = 17;
            this.newUserMenu.Text = "menuStrip1";
            // 
            // editUserMenuItem
            // 
            this.editUserMenuItem.Name = "editUserMenuItem";
            this.editUserMenuItem.Size = new System.Drawing.Size(128, 38);
            this.editUserMenuItem.Text = "Edit User";
            this.editUserMenuItem.Click += new System.EventHandler(this.editUserMenuItem_Click);
            // 
            // browseItemsMenu
            // 
            this.browseItemsMenu.Name = "browseItemsMenu";
            this.browseItemsMenu.Size = new System.Drawing.Size(175, 38);
            this.browseItemsMenu.Text = "Browse Items";
            this.browseItemsMenu.Click += new System.EventHandler(this.browseItemsMenu_Click);
            // 
            // petsAvailableMenuItem
            // 
            this.petsAvailableMenuItem.Name = "petsAvailableMenuItem";
            this.petsAvailableMenuItem.Size = new System.Drawing.Size(180, 38);
            this.petsAvailableMenuItem.Text = "Pets Available";
            this.petsAvailableMenuItem.Click += new System.EventHandler(this.petsAvailableMenuItem_Click);
            // 
            // shoppingCartMenuItem
            // 
            this.shoppingCartMenuItem.Name = "shoppingCartMenuItem";
            this.shoppingCartMenuItem.Size = new System.Drawing.Size(187, 38);
            this.shoppingCartMenuItem.Text = "Shopping Cart";
            this.shoppingCartMenuItem.Click += new System.EventHandler(this.shoppingCartMenuItem_Click);
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newUserMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editUser";
            this.Text = "editUserForm";
            this.newUserMenu.ResumeLayout(false);
            this.newUserMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip newUserMenu;
        private System.Windows.Forms.ToolStripMenuItem editUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseItemsMenu;
        private System.Windows.Forms.ToolStripMenuItem petsAvailableMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartMenuItem;
    }
}