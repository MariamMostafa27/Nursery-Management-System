﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursery_Management_System
{
    public partial class staffForm : Form
    {
        public staffForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            ValidateData vaild = new ValidateData();
            string headProblemOfData = "", promblemInData = "";
            if (vaild.vaildDataForStaff(firstName.Text, email.Text, ID.Text, phoneNumber.Text, ref headProblemOfData, ref promblemInData))
            {
                MessageBox.Show(promblemInData, headProblemOfData, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Staff staff = new Staff(Convert.ToInt64(ID.Text), firstName.Text, lastName.Text, phoneNumber.Text, email.Text, -1, 1, "Staff");
                mSQLQuery.insertStaffData(staff, "Staff");

                mSQLQuery.insertUser(username.Text, password.Text, "Staff", staff.id);
                MessageBox.Show("Requset has been sent", "Request sent", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.signUpForm.Show();
        }

        private void staffForm_Load(object sender, EventArgs e)
        {

        }

        private void staffProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Sfill_info()
        {
            signUpButton.Visible = false;
            SQL mysql = new SQL();

            Program.globalAdmin.ToString();
            Program.globalStaff.ToString();
            if (Program.globalStaff.type == "Staff")
            {
                string staff_username = "select userName from User_Password where staffID like '" + (Program.globalStaff.id).ToString() + "' ";
                string staff_password = "select userPassword from User_Password where staffID  like'" + (Program.globalStaff.id).ToString() + "' ";
                string un = mysql.retrieveQuery(staff_username).ToString();
                string pass = mysql.retrieveQuery(staff_password).ToString();
                firstName.Text = Program.globalStaff.firstName;
                lastName.Text = Program.globalStaff.lastName;
                username.Text = un;
                email.Text = Program.globalStaff.email;
                phoneNumber.Text = Program.globalStaff.phoneNumber;
                password.Text = pass;
                ID.Text = (Program.globalStaff.id).ToString();
            }
            else
            {
                string admin_username = "select userName from User_Password where staffID like '" + (Program.globalAdmin.id).ToString() + "' ";
                string admin_password = "select userPassword from User_Password where staffID  like'" + (Program.globalAdmin.id).ToString() + "' ";
                string un = mysql.retrieveQuery(admin_username).ToString();
                string pass = mysql.retrieveQuery(admin_password).ToString();
                firstName.Text = Program.globalAdmin.firstName;
                lastName.Text = Program.globalAdmin.lastName;
                username.Text = un;
                email.Text = Program.globalAdmin.email;
                phoneNumber.Text = Program.globalAdmin.phoneNumber;
                password.Text = pass;
                ID.Text = (Program.globalAdmin.id).ToString();

            }
        }


    }
}