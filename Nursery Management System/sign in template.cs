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
    public partial class signInTemplate : Form
    {
        bool togMove;
        int MouseX;
        int MouseY;

        public signInTemplate()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movementPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SQLQuery mSqlQuery = new SQLQuery();

            if (mSqlQuery.serachForUser(username.Text, password.Text) == false)
            {
                MessageBox.Show("Username doesn't exist", "Wrong Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hello, " + username.Text + "!", "Logged In Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                if (Program.globalType.Equals("Staff"))
                {
                    //open staff form
                    Program.staffLoggedInForm.Show();
                }
                else if (Program.globalType.Equals("Admin"))
                {
                    //open admin form
                    Program.adminLoggedInForm.Show();
                }
                else if (Program.globalType.Equals("Parent"))
                {
                    //open parent form
                    Program.parentLoggedInForm.Show();
                }
            }
        }
        

    private void signInTemplate_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = false;
        }

        private void signInTemplate_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = true;
            MouseX = e.X;
            MouseY = e.Y;
        }

        private void signInTemplate_MouseMove(object sender, MouseEventArgs e)
        {
            if(togMove)
            {
                this.SetDesktopLocation(MousePosition.X - MouseX, MousePosition.Y - MouseY);
            }
        }

        private void userLoginPicture_Click(object sender, EventArgs e)
        {

        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            this.Hide();
            Program.signUpForm.Show();
        }
    }
}
