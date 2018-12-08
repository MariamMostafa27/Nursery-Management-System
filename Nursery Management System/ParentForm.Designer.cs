﻿namespace Nursery_Management_System
{
    partial class parentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parentForm));
            this.firstName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.parentProfilePanel = new System.Windows.Forms.Panel();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.creditCard = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.childrenPanel = new System.Windows.Forms.Panel();
            this.addChildButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.parentProfilePanel.SuspendLayout();
            this.childrenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstName.Font = new System.Drawing.Font("Consolas", 8F);
            this.firstName.Location = new System.Drawing.Point(285, 53);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(201, 23);
            this.firstName.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Enabled = false;
            this.firstNameLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.firstNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.firstNameLabel.Location = new System.Drawing.Point(127, 53);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(112, 30);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name :";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 90);
            this.backButton.TabIndex = 10;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // parentProfilePanel
            // 
            this.parentProfilePanel.BackColor = System.Drawing.Color.Transparent;
            this.parentProfilePanel.Controls.Add(this.declineButton);
            this.parentProfilePanel.Controls.Add(this.acceptButton);
            this.parentProfilePanel.Controls.Add(this.IDLabel);
            this.parentProfilePanel.Controls.Add(this.ID);
            this.parentProfilePanel.Controls.Add(this.signUpButton);
            this.parentProfilePanel.Controls.Add(this.firstNameLabel);
            this.parentProfilePanel.Controls.Add(this.firstName);
            this.parentProfilePanel.Controls.Add(this.lastNameLabel);
            this.parentProfilePanel.Controls.Add(this.lastName);
            this.parentProfilePanel.Controls.Add(this.usernameLabel);
            this.parentProfilePanel.Controls.Add(this.username);
            this.parentProfilePanel.Controls.Add(this.passwordLabel);
            this.parentProfilePanel.Controls.Add(this.password);
            this.parentProfilePanel.Controls.Add(this.emailLabel);
            this.parentProfilePanel.Controls.Add(this.email);
            this.parentProfilePanel.Controls.Add(this.creditCardLabel);
            this.parentProfilePanel.Controls.Add(this.creditCard);
            this.parentProfilePanel.Controls.Add(this.phoneNumberLabel);
            this.parentProfilePanel.Controls.Add(this.phoneNumber);
            this.parentProfilePanel.Controls.Add(this.addressLabel);
            this.parentProfilePanel.Controls.Add(this.address);
            this.parentProfilePanel.Controls.Add(this.childrenPanel);
            this.parentProfilePanel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parentProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentProfilePanel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.parentProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.parentProfilePanel.Name = "parentProfilePanel";
            this.parentProfilePanel.Size = new System.Drawing.Size(920, 540);
            this.parentProfilePanel.TabIndex = 3;
            this.parentProfilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.parentProfilePanel_Paint);
            // 
            // declineButton
            // 
            this.declineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.declineButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.declineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.declineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.declineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.declineButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.declineButton.ForeColor = System.Drawing.Color.DimGray;
            this.declineButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.declineButton.Location = new System.Drawing.Point(650, 475);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(248, 44);
            this.declineButton.TabIndex = 45;
            this.declineButton.Text = "Decline";
            this.declineButton.UseVisualStyleBackColor = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.acceptButton.ForeColor = System.Drawing.Color.DimGray;
            this.acceptButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.acceptButton.Location = new System.Drawing.Point(650, 401);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(248, 44);
            this.acceptButton.TabIndex = 44;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.IDLabel.ForeColor = System.Drawing.Color.DimGray;
            this.IDLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IDLabel.Location = new System.Drawing.Point(506, 185);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(114, 30);
            this.IDLabel.TabIndex = 43;
            this.IDLabel.Text = "National ID :";
            // 
            // ID
            // 
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.Font = new System.Drawing.Font("Consolas", 8F);
            this.ID.Location = new System.Drawing.Point(651, 186);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(201, 23);
            this.ID.TabIndex = 42;
            // 
            // signUpButton
            // 
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.signUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.signUpButton.ForeColor = System.Drawing.Color.DimGray;
            this.signUpButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.signUpButton.Location = new System.Drawing.Point(650, 475);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(248, 44);
            this.signUpButton.TabIndex = 9;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Enabled = false;
            this.lastNameLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.lastNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.lastNameLabel.Location = new System.Drawing.Point(506, 53);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 30);
            this.lastNameLabel.TabIndex = 37;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // lastName
            // 
            this.lastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastName.Font = new System.Drawing.Font("Consolas", 8F);
            this.lastName.Location = new System.Drawing.Point(651, 53);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(201, 23);
            this.lastName.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Enabled = false;
            this.usernameLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.usernameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.usernameLabel.Location = new System.Drawing.Point(127, 98);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(104, 30);
            this.usernameLabel.TabIndex = 39;
            this.usernameLabel.Text = "Username :";
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Consolas", 8F);
            this.username.Location = new System.Drawing.Point(285, 98);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(201, 23);
            this.username.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Enabled = false;
            this.passwordLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.passwordLabel.ForeColor = System.Drawing.Color.DimGray;
            this.passwordLabel.Location = new System.Drawing.Point(506, 98);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(103, 30);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Password :";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Consolas", 8F);
            this.password.Location = new System.Drawing.Point(651, 98);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(201, 23);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Enabled = false;
            this.emailLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.emailLabel.ForeColor = System.Drawing.Color.DimGray;
            this.emailLabel.Location = new System.Drawing.Point(127, 143);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(68, 30);
            this.emailLabel.TabIndex = 41;
            this.emailLabel.Text = "Email :";
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Consolas", 8F);
            this.email.Location = new System.Drawing.Point(285, 143);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(281, 23);
            this.email.TabIndex = 4;
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Enabled = false;
            this.creditCardLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.creditCardLabel.ForeColor = System.Drawing.Color.DimGray;
            this.creditCardLabel.Location = new System.Drawing.Point(127, 185);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(119, 30);
            this.creditCardLabel.TabIndex = 28;
            this.creditCardLabel.Text = "Credit Card :";
            // 
            // creditCard
            // 
            this.creditCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.creditCard.Font = new System.Drawing.Font("Consolas", 8F);
            this.creditCard.Location = new System.Drawing.Point(285, 185);
            this.creditCard.Name = "creditCard";
            this.creditCard.Size = new System.Drawing.Size(201, 23);
            this.creditCard.TabIndex = 5;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Enabled = false;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.DimGray;
            this.phoneNumberLabel.Location = new System.Drawing.Point(127, 223);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(140, 30);
            this.phoneNumberLabel.TabIndex = 34;
            this.phoneNumberLabel.Text = "Phone Number :";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumber.Font = new System.Drawing.Font("Consolas", 8F);
            this.phoneNumber.Location = new System.Drawing.Point(285, 223);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(281, 23);
            this.phoneNumber.TabIndex = 6;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Enabled = false;
            this.addressLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.addressLabel.ForeColor = System.Drawing.Color.DimGray;
            this.addressLabel.Location = new System.Drawing.Point(127, 261);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(89, 30);
            this.addressLabel.TabIndex = 32;
            this.addressLabel.Text = "Address :";
            // 
            // address
            // 
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.Font = new System.Drawing.Font("Consolas", 8F);
            this.address.Location = new System.Drawing.Point(285, 261);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(281, 23);
            this.address.TabIndex = 7;
            // 
            // childrenPanel
            // 
            this.childrenPanel.AutoScroll = true;
            this.childrenPanel.Controls.Add(this.payButton);
            this.childrenPanel.Controls.Add(this.addChildButton);
            this.childrenPanel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.childrenPanel.Location = new System.Drawing.Point(5, 320);
            this.childrenPanel.Name = "childrenPanel";
            this.childrenPanel.Size = new System.Drawing.Size(630, 210);
            this.childrenPanel.TabIndex = 8;
            // 
            // addChildButton
            // 
            this.addChildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addChildButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addChildButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addChildButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addChildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addChildButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.addChildButton.Image = ((System.Drawing.Image)(resources.GetObject("addChildButton.Image")));
            this.addChildButton.Location = new System.Drawing.Point(21, 30);
            this.addChildButton.Name = "addChildButton";
            this.addChildButton.Size = new System.Drawing.Size(150, 150);
            this.addChildButton.TabIndex = 0;
            this.addChildButton.Text = " add child";
            this.addChildButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addChildButton.UseVisualStyleBackColor = true;
            this.addChildButton.Click += new System.EventHandler(this.addChildButton_Click);
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.Transparent;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.payButton.Image = ((System.Drawing.Image)(resources.GetObject("payButton.Image")));
            this.payButton.Location = new System.Drawing.Point(21, 30);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(150, 150);
            this.payButton.TabIndex = 46;
            this.payButton.Text = "Pay Fees";
            this.payButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payButton.UseVisualStyleBackColor = false;
            // 
            // parentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.parentProfilePanel);
            this.Name = "parentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nursery Management System - Sign Up as Parent";
            this.Load += new System.EventHandler(this.parentForm_Load);
            this.parentProfilePanel.ResumeLayout(false);
            this.parentProfilePanel.PerformLayout();
            this.childrenPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel parentProfilePanel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.TextBox creditCard;
        private System.Windows.Forms.Panel childrenPanel;
        private System.Windows.Forms.Button addChildButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button payButton;
    }
}