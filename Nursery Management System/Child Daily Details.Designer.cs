namespace Nursery_Management_System
{
    partial class childDailyDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childDailyDetails));
            this.sendButton = new System.Windows.Forms.Button();
            this.parentNameLabel = new System.Windows.Forms.Label();
            this.childDailyDetailsBox = new System.Windows.Forms.RichTextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Transparent;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.sendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.sendButton.ForeColor = System.Drawing.Color.DimGray;
            this.sendButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendButton.Location = new System.Drawing.Point(629, 453);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(248, 44);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // parentNameLabel
            // 
            this.parentNameLabel.AutoSize = true;
            this.parentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.parentNameLabel.Font = new System.Drawing.Font("Comfortaa", 15F);
            this.parentNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.parentNameLabel.Location = new System.Drawing.Point(146, 110);
            this.parentNameLabel.Name = "parentNameLabel";
            this.parentNameLabel.Size = new System.Drawing.Size(540, 32);
            this.parentNameLabel.TabIndex = 11;
            this.parentNameLabel.Text = "Describe child\'s behaviour during the day :";
            // 
            // childDailyDetailsBox
            // 
            this.childDailyDetailsBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.childDailyDetailsBox.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childDailyDetailsBox.Location = new System.Drawing.Point(151, 203);
            this.childDailyDetailsBox.Name = "childDailyDetailsBox";
            this.childDailyDetailsBox.Size = new System.Drawing.Size(620, 200);
            this.childDailyDetailsBox.TabIndex = 10;
            this.childDailyDetailsBox.Text = "";
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButton.Location = new System.Drawing.Point(2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 90);
            this.backButton.TabIndex = 13;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // childDailyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.parentNameLabel);
            this.Controls.Add(this.childDailyDetailsBox);
            this.Name = "childDailyDetails";
            this.Text = "Nusery Management System - Child Daily Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label parentNameLabel;
        private System.Windows.Forms.RichTextBox childDailyDetailsBox;
        private System.Windows.Forms.Button backButton;
    }
}