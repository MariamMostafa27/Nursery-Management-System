namespace Nursery_Management_System
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.StaffAssignedRoom = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StaffAssignedRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffAssignedRoom
            // 
            this.StaffAssignedRoom.AllowUserToOrderColumns = true;
            this.StaffAssignedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffAssignedRoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StaffAssignedRoom.Location = new System.Drawing.Point(0, 70);
            this.StaffAssignedRoom.Name = "StaffAssignedRoom";
            this.StaffAssignedRoom.RowTemplate.Height = 24;
            this.StaffAssignedRoom.Size = new System.Drawing.Size(920, 470);
            this.StaffAssignedRoom.TabIndex = 0;
            this.StaffAssignedRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffAssignedRoom_CellContentClick);
            // 
            // backButton
            // 
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
            this.backButton.Size = new System.Drawing.Size(107, 70);
            this.backButton.TabIndex = 11;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.StaffAssignedRoom);
            this.Controls.Add(this.backButton);
            this.Name = "RoomForm";
            this.Text = "Nursery Management System - Room";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffAssignedRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffAssignedRoom;
        private System.Windows.Forms.Button backButton;
    }
}