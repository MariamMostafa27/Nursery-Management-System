﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace Nursery_Management_System
{
    public partial class childForm : Form
    {
        string Gender= "Female";
        byte[] location; 
        
        public childForm()
        {
            InitializeComponent();

            // make location of pictuer is default
            Image image= childImageButton.Image;
            ImageOperation OP = new ImageOperation();

            location = OP.ImageToBinary(image) ;
            


        }
        


        public void enableEditing(string state)
        {
            this.editButton.Visible = false;
            this.childProfilePanel.Enabled = true;
            this.importImageButton.Visible = true;
            this.importImageButton.Enabled = true;

            this.saveButton.Visible = true;

            switch(state)
            {
                case "parentSignUp":
                {
                    this.Text = "Nusery Management System - Child Sign Up";                    
                    this.roomNumber.Enabled = false;
                }
                break;

                default:
                {

                }
                break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    Program.signForm.Dispose();
                    break;
                default:
                    break;
            }
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void childName_TextChanged(object sender, EventArgs e)
        {

        }

        private void childImageButton_Click(object sender, EventArgs e)
        {

        }

        private void note_Click(object sender, EventArgs e)
        {

        }

        private void Child_Load(object sender, EventArgs e)
        {

        }

        private void childProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            Gender = "Female";
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            Gender = "Male";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            if (childName.Text.Length >= 2)
            {
                Program.parentSignUpForm.ChildOfParent(childName.Text, DOBpicker.Value , Gender, location);
                            
                MessageBox.Show("Requset has been sent", "Request sent", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();


            }
            else
            {
                MessageBox.Show("Please Enter atleast 2 letter", "Invaild Child Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void childName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void childImageButton_Click_1(object sender, EventArgs e)
        {

        }

        private void childImageButton_Click_2(object sender, EventArgs e)
        {
            
           

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            enableEditing("adminEdit");

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.parentSignUpForm.Show();
        }

        private void importImageButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog getPictureLocation = new OpenFileDialog();
            getPictureLocation.Filter = "JPG(*.JPG)|*.JPG";

            if (getPictureLocation.ShowDialog() == DialogResult.OK)
            {

                childImageButton.Image = Image.FromFile(getPictureLocation.FileName);
                childImageButton.Image.Width.Equals(248);
                childImageButton.Image.Height.Equals(256);
                
            }
        }
    }
}