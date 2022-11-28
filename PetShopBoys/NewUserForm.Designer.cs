namespace PetShopBoys
{
    partial class newUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.newUserMenu = new System.Windows.Forms.MenuStrip();
            this.editUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseItemsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.petsAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoppingCartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitUserButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.newUserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New User";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(301, 143);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(309, 31);
            this.userNameTextBox.TabIndex = 3;
            this.userNameTextBox.Leave += new System.EventHandler(this.userNameTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(301, 204);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(309, 31);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // newUserMenu
            // 
            this.newUserMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.newUserMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.newUserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserMenuItem,
            this.browseItemsMenuStrip,
            this.petsAvailableToolStripMenuItem,
            this.shoppingCartMenuItem});
            this.newUserMenu.Location = new System.Drawing.Point(0, 0);
            this.newUserMenu.Name = "newUserMenu";
            this.newUserMenu.Size = new System.Drawing.Size(837, 48);
            this.newUserMenu.TabIndex = 5;
            this.newUserMenu.Text = "menuStrip1";
            // 
            // editUserMenuItem
            // 
            this.editUserMenuItem.Name = "editUserMenuItem";
            this.editUserMenuItem.Size = new System.Drawing.Size(128, 40);
            this.editUserMenuItem.Text = "Edit User";
            this.editUserMenuItem.Click += new System.EventHandler(this.editUserMenuItem_Click);
            // 
            // browseItemsMenuStrip
            // 
            this.browseItemsMenuStrip.Name = "browseItemsMenuStrip";
            this.browseItemsMenuStrip.Size = new System.Drawing.Size(175, 40);
            this.browseItemsMenuStrip.Text = "Browse Items";
            this.browseItemsMenuStrip.Click += new System.EventHandler(this.browseItemsMenuStrip_Click);
            // 
            // petsAvailableToolStripMenuItem
            // 
            this.petsAvailableToolStripMenuItem.Name = "petsAvailableToolStripMenuItem";
            this.petsAvailableToolStripMenuItem.Size = new System.Drawing.Size(180, 40);
            this.petsAvailableToolStripMenuItem.Text = "Pets Available";
            this.petsAvailableToolStripMenuItem.Click += new System.EventHandler(this.petsAvailableToolStripMenuItem_Click);
            // 
            // shoppingCartMenuItem
            // 
            this.shoppingCartMenuItem.Name = "shoppingCartMenuItem";
            this.shoppingCartMenuItem.Size = new System.Drawing.Size(187, 40);
            this.shoppingCartMenuItem.Text = "Shopping Cart";
            this.shoppingCartMenuItem.Click += new System.EventHandler(this.shoppingCartMenuItem_Click);
            // 
            // submitUserButton
            // 
            this.submitUserButton.Location = new System.Drawing.Point(41, 281);
            this.submitUserButton.Name = "submitUserButton";
            this.submitUserButton.Size = new System.Drawing.Size(204, 72);
            this.submitUserButton.TabIndex = 11;
            this.submitUserButton.Text = "Submit ";
            this.submitUserButton.UseVisualStyleBackColor = true;
            this.submitUserButton.Click += new System.EventHandler(this.submitUserButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(276, 281);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(204, 72);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 462);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitUserButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserMenu);
            this.MainMenuStrip = this.newUserMenu;
            this.Name = "newUser";
            this.Text = "User Name:";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.newUserMenu.ResumeLayout(false);
            this.newUserMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.MenuStrip newUserMenu;
        private System.Windows.Forms.ToolStripMenuItem editUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseItemsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem petsAvailableToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button submitUserButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}