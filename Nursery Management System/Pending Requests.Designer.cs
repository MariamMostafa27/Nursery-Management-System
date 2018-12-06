namespace Nursery_Management_System
{
    partial class adminPendingRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPendingRequests));
            this.pendingRequestsControl = new System.Windows.Forms.TabControl();
            this.staff = new System.Windows.Forms.TabPage();
            this.staffListView = new System.Windows.Forms.ListView();
            this.staffFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staffEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButtonStaff = new System.Windows.Forms.Button();
            this.child = new System.Windows.Forms.TabPage();
            this.childImage = new System.Windows.Forms.PictureBox();
            this.childListView = new System.Windows.Forms.ListView();
            this.childID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.childName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.childParent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.childGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButtonChild = new System.Windows.Forms.Button();
            this.Parents = new System.Windows.Forms.TabPage();
            this.parentsListView = new System.Windows.Forms.ListView();
            this.parentsFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parentsLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parentsPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.parentsEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backButtonParents = new System.Windows.Forms.Button();
            this.pendingRequestsControl.SuspendLayout();
            this.staff.SuspendLayout();
            this.child.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childImage)).BeginInit();
            this.Parents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pendingRequestsControl
            // 
            this.pendingRequestsControl.Controls.Add(this.staff);
            this.pendingRequestsControl.Controls.Add(this.child);
            this.pendingRequestsControl.Controls.Add(this.Parents);
            this.pendingRequestsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingRequestsControl.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.pendingRequestsControl.Location = new System.Drawing.Point(0, 0);
            this.pendingRequestsControl.Name = "pendingRequestsControl";
            this.pendingRequestsControl.Padding = new System.Drawing.Point(10, 10);
            this.pendingRequestsControl.SelectedIndex = 0;
            this.pendingRequestsControl.Size = new System.Drawing.Size(920, 540);
            this.pendingRequestsControl.TabIndex = 0;
            // 
            // staff
            // 
            this.staff.Controls.Add(this.staffListView);
            this.staff.Controls.Add(this.backButtonStaff);
            this.staff.Location = new System.Drawing.Point(4, 53);
            this.staff.Name = "staff";
            this.staff.Padding = new System.Windows.Forms.Padding(3);
            this.staff.Size = new System.Drawing.Size(912, 483);
            this.staff.TabIndex = 0;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            this.staff.Click += new System.EventHandler(this.staff_Click);
            // 
            // staffListView
            // 
            this.staffListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.staffFirstName,
            this.staffLastName,
            this.staffPhoneNumber,
            this.staffEmail});
            this.staffListView.Location = new System.Drawing.Point(-5, 0);
            this.staffListView.Name = "staffListView";
            this.staffListView.Size = new System.Drawing.Size(916, 401);
            this.staffListView.TabIndex = 11;
            this.staffListView.UseCompatibleStateImageBehavior = false;
            // 
            // staffFirstName
            // 
            this.staffFirstName.Text = "First Name";
            this.staffFirstName.Width = 120;
            // 
            // staffLastName
            // 
            this.staffLastName.Text = "Last Name";
            this.staffLastName.Width = 120;
            // 
            // staffPhoneNumber
            // 
            this.staffPhoneNumber.Text = "Phone Number";
            this.staffPhoneNumber.Width = 150;
            // 
            // staffEmail
            // 
            this.staffEmail.Text = "Email";
            this.staffEmail.Width = 240;
            // 
            // backButtonStaff
            // 
            this.backButtonStaff.AutoSize = true;
            this.backButtonStaff.BackColor = System.Drawing.Color.Transparent;
            this.backButtonStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButtonStaff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButtonStaff.FlatAppearance.BorderSize = 0;
            this.backButtonStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButtonStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButtonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButtonStaff.Image = ((System.Drawing.Image)(resources.GetObject("backButtonStaff.Image")));
            this.backButtonStaff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButtonStaff.Location = new System.Drawing.Point(8, 407);
            this.backButtonStaff.Name = "backButtonStaff";
            this.backButtonStaff.Size = new System.Drawing.Size(74, 68);
            this.backButtonStaff.TabIndex = 10;
            this.backButtonStaff.UseVisualStyleBackColor = false;
            this.backButtonStaff.Click += new System.EventHandler(this.backButtonStaff_Click);
            // 
            // child
            // 
            this.child.Controls.Add(this.childImage);
            this.child.Controls.Add(this.childListView);
            this.child.Controls.Add(this.backButtonChild);
            this.child.Location = new System.Drawing.Point(4, 53);
            this.child.Name = "child";
            this.child.Padding = new System.Windows.Forms.Padding(3);
            this.child.Size = new System.Drawing.Size(912, 483);
            this.child.TabIndex = 1;
            this.child.Text = "Child";
            this.child.UseVisualStyleBackColor = true;
            // 
            // childImage
            // 
            this.childImage.Location = new System.Drawing.Point(589, 0);
            this.childImage.Name = "childImage";
            this.childImage.Size = new System.Drawing.Size(320, 268);
            this.childImage.TabIndex = 14;
            this.childImage.TabStop = false;
            // 
            // childListView
            // 
            this.childListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.childID,
            this.childName,
            this.childParent,
            this.childGender});
            this.childListView.Location = new System.Drawing.Point(-4, -2);
            this.childListView.Name = "childListView";
            this.childListView.Size = new System.Drawing.Size(587, 401);
            this.childListView.TabIndex = 13;
            this.childListView.UseCompatibleStateImageBehavior = false;
            this.childListView.SelectedIndexChanged += new System.EventHandler(this.childListView_SelectedIndexChanged);
            // 
            // childID
            // 
            this.childID.DisplayIndex = 2;
            this.childID.Text = "ID";
            // 
            // childName
            // 
            this.childName.DisplayIndex = 0;
            this.childName.Text = "Child Name";
            this.childName.Width = 120;
            // 
            // childParent
            // 
            this.childParent.DisplayIndex = 1;
            this.childParent.Text = "Parent Name";
            this.childParent.Width = 150;
            // 
            // childGender
            // 
            this.childGender.Text = "Gender";
            this.childGender.Width = 120;
            // 
            // backButtonChild
            // 
            this.backButtonChild.AutoSize = true;
            this.backButtonChild.BackColor = System.Drawing.Color.Transparent;
            this.backButtonChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButtonChild.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButtonChild.FlatAppearance.BorderSize = 0;
            this.backButtonChild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButtonChild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButtonChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButtonChild.Image = ((System.Drawing.Image)(resources.GetObject("backButtonChild.Image")));
            this.backButtonChild.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButtonChild.Location = new System.Drawing.Point(20, 405);
            this.backButtonChild.Name = "backButtonChild";
            this.backButtonChild.Size = new System.Drawing.Size(56, 56);
            this.backButtonChild.TabIndex = 10;
            this.backButtonChild.UseVisualStyleBackColor = false;
            this.backButtonChild.Click += new System.EventHandler(this.backButtonChild_Click);
            // 
            // Parents
            // 
            this.Parents.Controls.Add(this.parentsListView);
            this.Parents.Controls.Add(this.backButtonParents);
            this.Parents.Location = new System.Drawing.Point(4, 53);
            this.Parents.Name = "Parents";
            this.Parents.Padding = new System.Windows.Forms.Padding(3);
            this.Parents.Size = new System.Drawing.Size(912, 483);
            this.Parents.TabIndex = 2;
            this.Parents.Text = "Parents";
            this.Parents.UseVisualStyleBackColor = true;
            // 
            // parentsListView
            // 
            this.parentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.parentsFirstName,
            this.parentsLastName,
            this.parentsPhoneNumber,
            this.parentsEmail});
            this.parentsListView.Location = new System.Drawing.Point(-5, 0);
            this.parentsListView.Name = "parentsListView";
            this.parentsListView.Size = new System.Drawing.Size(916, 401);
            this.parentsListView.TabIndex = 12;
            this.parentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // parentsFirstName
            // 
            this.parentsFirstName.Text = "First Name";
            this.parentsFirstName.Width = 120;
            // 
            // parentsLastName
            // 
            this.parentsLastName.Text = "Last Name";
            this.parentsLastName.Width = 120;
            // 
            // parentsPhoneNumber
            // 
            this.parentsPhoneNumber.Text = "Phone Number";
            this.parentsPhoneNumber.Width = 150;
            // 
            // parentsEmail
            // 
            this.parentsEmail.Text = "Email";
            this.parentsEmail.Width = 240;
            // 
            // backButtonParents
            // 
            this.backButtonParents.AutoSize = true;
            this.backButtonParents.BackColor = System.Drawing.Color.Transparent;
            this.backButtonParents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButtonParents.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButtonParents.FlatAppearance.BorderSize = 0;
            this.backButtonParents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButtonParents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButtonParents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButtonParents.Image = ((System.Drawing.Image)(resources.GetObject("backButtonParents.Image")));
            this.backButtonParents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButtonParents.Location = new System.Drawing.Point(20, 405);
            this.backButtonParents.Name = "backButtonParents";
            this.backButtonParents.Size = new System.Drawing.Size(56, 56);
            this.backButtonParents.TabIndex = 11;
            this.backButtonParents.UseVisualStyleBackColor = false;
            this.backButtonParents.Click += new System.EventHandler(this.backButtonParents_Click);
            // 
            // adminPendingRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.pendingRequestsControl);
            this.Name = "adminPendingRequests";
            this.Text = "Nursery Management System - Pending Requests";
            this.Load += new System.EventHandler(this.adminPendingRequests_Load);
            this.pendingRequestsControl.ResumeLayout(false);
            this.staff.ResumeLayout(false);
            this.staff.PerformLayout();
            this.child.ResumeLayout(false);
            this.child.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childImage)).EndInit();
            this.Parents.ResumeLayout(false);
            this.Parents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pendingRequestsControl;
        private System.Windows.Forms.TabPage staff;
        private System.Windows.Forms.TabPage child;
        private System.Windows.Forms.Button backButtonStaff;
        private System.Windows.Forms.Button backButtonChild;
        private System.Windows.Forms.TabPage Parents;
        private System.Windows.Forms.Button backButtonParents;
        private System.Windows.Forms.ListView staffListView;
        private System.Windows.Forms.ColumnHeader staffFirstName;
        private System.Windows.Forms.ColumnHeader staffLastName;
        private System.Windows.Forms.ColumnHeader staffPhoneNumber;
        private System.Windows.Forms.ColumnHeader staffEmail;
        private System.Windows.Forms.ListView parentsListView;
        private System.Windows.Forms.ColumnHeader parentsFirstName;
        private System.Windows.Forms.ColumnHeader parentsLastName;
        private System.Windows.Forms.ColumnHeader parentsPhoneNumber;
        private System.Windows.Forms.ColumnHeader parentsEmail;
        private System.Windows.Forms.ListView childListView;
        private System.Windows.Forms.ColumnHeader childName;
        private System.Windows.Forms.ColumnHeader childParent;
        private System.Windows.Forms.ColumnHeader childID;
        private System.Windows.Forms.ColumnHeader childGender;
        private System.Windows.Forms.PictureBox childImage;
    }
}