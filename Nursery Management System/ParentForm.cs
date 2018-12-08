using System;
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
    public partial class parentForm : Form
    {

        LinkedList<Child> childOfParent = new LinkedList<Child>();


        public parentForm()
        {
            InitializeComponent();
            
        }

        private void parentForm_Load(object sender, EventArgs e)
        {

        }
        public void parentShow()
        {
            acceptButton.Visible = false;
            declineButton.Visible = false;
            signUpButton.Visible = true;
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
            if (Program.globalType != "")
                Program.parentLoggedInForm.Show();
            else
                Program.signUpForm.Show();
        }

        private void addChildButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            ValidateData vaild = new ValidateData();
            string headProblemOfData = "", promblemInData = "";

            if (vaild.vaildDataForParent(username.Text, email.Text, ID.Text, phoneNumber.Text, creditCard.Text, ref headProblemOfData, ref promblemInData))
            {
                MessageBox.Show(promblemInData, headProblemOfData, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Program.childSignUpForm.Show() ;
                Program.childSignUpForm.enableEditing("parentSignUp");
            }
        }
        public void ChildOfParent(string childName , DateTime dT , string gender , byte[] picLocation)
        {
            
            Int64 id = Int64.Parse(ID.Text);
            // 43 room id 
            Child child = new Child(childName, firstName.Text , id , 43, gender, dT, picLocation, -1);
            childOfParent.AddLast(child);

        }
        private void parentProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSQLQuery = new SQLQuery();
            ValidateData vaild = new ValidateData();
            int numberOfChildren = childOfParent.Count;
            string headProblemOfData="", promblemInData="";
            if(vaild.vaildDataForParent(username.Text,email.Text,ID.Text,phoneNumber.Text,creditCard.Text,numberOfChildren,ref headProblemOfData,ref promblemInData))
            {
                MessageBox.Show(promblemInData, headProblemOfData, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Parent parent = new Parent(Convert.ToInt64(ID.Text), firstName.Text, lastName.Text, phoneNumber.Text, email.Text, address.Text, creditCard.Text, 1);
                mSQLQuery.insertParentData(parent);

                Program.globalParent = parent;

                mSQLQuery.insertUser(username.Text, password.Text, "Parent", parent.id);
                foreach(Child i in childOfParent)
                {
                    mSQLQuery.insertChildData(i);
                }

                MessageBox.Show("Requset has been sent", "Request sent", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

        }

        private void declineButton_Click(object sender, EventArgs e)
        {

        }
        public void Pfill_info()
        {
            acceptButton.Visible = false;
            declineButton.Visible = false;
            signUpButton.Visible = false;
            SQL mysql = new SQL();
            string parent_username = "select userName from User_Password where parentID like '" + (Program.globalParent.id).ToString() + "' ";
            string un = mysql.retrieveQuery(parent_username).ToString();
            Program.globalParent.ToString();
            firstName.Text = Program.globalParent.firstName;
            lastName.Text = Program.globalParent.lastName;
            username.Text = un;
            email.Text = Program.globalParent.email;
            creditCard.Text = Program.globalParent.creditCard;
            ID.Text = Program.globalParent.id.ToString();
            phoneNumber.Text = Program.globalParent.phoneNumber;
            address.Text = Program.globalParent.address;
        }
    }
}
