namespace Nursery_Management_System
{
    partial class Parent_Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent_Feedback));
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.feedbackBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.BackColor = System.Drawing.Color.Transparent;
            this.feedbackLabel.Font = new System.Drawing.Font("Comfortaa", 15F);
            this.feedbackLabel.ForeColor = System.Drawing.Color.DimGray;
            this.feedbackLabel.Location = new System.Drawing.Point(146, 110);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(523, 32);
            this.feedbackLabel.TabIndex = 7;
            this.feedbackLabel.Text = "Describe your issue or share your ideas :";
            // 
            // feedbackBox
            // 
            this.feedbackBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.feedbackBox.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBox.Location = new System.Drawing.Point(151, 203);
            this.feedbackBox.Name = "feedbackBox";
            this.feedbackBox.Size = new System.Drawing.Size(620, 200);
            this.feedbackBox.TabIndex = 6;
            this.feedbackBox.Text = "";
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
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
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
            this.backButton.TabIndex = 10;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // Parent_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.feedbackLabel);
            this.Controls.Add(this.feedbackBox);
            this.Name = "Parent_Feedback";
            this.Text = "Nusery Management System - Parent Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.RichTextBox feedbackBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button backButton;
    }
}