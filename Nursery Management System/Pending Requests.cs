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
    public partial class adminPendingRequests : Form
    {
        public adminPendingRequests()
        {
            InitializeComponent();

            viewGride();

            

        }
        private void viewGride()
        {
            
            DataTable pennding = new DataTable();
            DataTable all = new DataTable();
            SQLQuery MyQuery = new SQLQuery();
            SQLQuery MyQuery2 = new SQLQuery();

            // staff pennding list veiw load
            pennding = MyQuery.getPendingStaff();
            foreach(DataRow row in pennding.Rows)
            {
                ListViewItem item = new ListViewItem(row[1].ToString());
                for (int i = 2; i <= 4; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                staffListView.Items.Add(item);
            }
            staffListView.View = View.Details;
            staffListView.FullRowSelect = true;

            // parents pennding list veiw  laod
            pennding = MyQuery.getPendingParent();
            foreach (DataRow row in pennding.Rows)
            {
                ListViewItem item = new ListViewItem(row[1].ToString());
               
                    item.SubItems.Add(row[2].ToString());
                item.SubItems.Add(row[4].ToString());
                item.SubItems.Add(row[6].ToString());

                parentsListView.Items.Add(item);
            }
            parentsListView.View = View.Details;
            parentsListView.FullRowSelect = true;

            // Child Pending listview laod
            
            /*
                ImageOperation OP = new ImageOperation();
                ImageList imgs = new ImageList();
                   pennding = MyQuery2.getPendingChild();
                    foreach (DataRow rows in pennding.Rows)
                    {
                
                imgs.ImageSize = new Size(100, 100);
                Image image = OP.StringToImage((rows[6].ToString()));
                imgs.Images.Add("Key",image);
                childListView.LargeImageList = imgs;
                
                
                        ListViewItem item = new ListViewItem(rows[1].ToString());
                        item.ImageKey = "Key";
                        item.SubItems.Add(rows[2].ToString());
                        item.SubItems.Add(rows[4].ToStrin8g());
                        childListView.Items.Add(item);
                    }
            childListView.View = View.Details;
            childListView.FullRowSelect = true;*/
            



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

        private void backButtonChild_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.adminLoggedInForm.Show();
        }

        private void backButtonStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.adminLoggedInForm.Show();
        }

        private void backButtonParents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.adminLoggedInForm.Show();
        }

        private void adminPendingRequests_Load(object sender, EventArgs e)
        {

        }

        private void childListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
