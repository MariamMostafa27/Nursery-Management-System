namespace Nursery_Management_System
{
    partial class childForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childForm));
            this.backButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.genderLabel = new System.Windows.Forms.Label();
            this.childDOBLabel = new System.Windows.Forms.Label();
            this.childName = new System.Windows.Forms.TextBox();
            this.groupedFeatures = new System.Windows.Forms.GroupBox();
            this.feature1 = new System.Windows.Forms.CheckBox();
            this.feature2 = new System.Windows.Forms.CheckBox();
            this.feature3 = new System.Windows.Forms.CheckBox();
            this.feature4 = new System.Windows.Forms.CheckBox();
            this.feature5 = new System.Windows.Forms.CheckBox();
            this.feature6 = new System.Windows.Forms.CheckBox();
            this.feature7 = new System.Windows.Forms.CheckBox();
            this.feature8 = new System.Windows.Forms.CheckBox();
            this.feature9 = new System.Windows.Forms.CheckBox();
            this.childNameLabel = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.DOBpicker = new System.Windows.Forms.DateTimePicker();
            this.detailsOfTheDayLabel = new System.Windows.Forms.Label();
            this.importImageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.childImageButton = new System.Windows.Forms.Button();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.childProfilePanel = new System.Windows.Forms.Panel();
            this.groupedFeatures.SuspendLayout();
            this.genderPanel.SuspendLayout();
            this.childProfilePanel.SuspendLayout();
            this.SuspendLayout();
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
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(-1, 1);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 73);
            this.backButton.TabIndex = 18;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editButton.Enabled = false;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.editButton.ForeColor = System.Drawing.Color.DimGray;
            this.editButton.Location = new System.Drawing.Point(479, 257);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(186, 36);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.genderLabel.Location = new System.Drawing.Point(124, 98);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(61, 24);
            this.genderLabel.TabIndex = 20;
            this.genderLabel.Text = "Gender:";
            // 
            // childDOBLabel
            // 
            this.childDOBLabel.AutoSize = true;
            this.childDOBLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.childDOBLabel.Location = new System.Drawing.Point(124, 155);
            this.childDOBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.childDOBLabel.Name = "childDOBLabel";
            this.childDOBLabel.Size = new System.Drawing.Size(100, 24);
            this.childDOBLabel.TabIndex = 18;
            this.childDOBLabel.Text = "Date of Birth:";
            // 
            // childName
            // 
            this.childName.Font = new System.Drawing.Font("Consolas", 8F);
            this.childName.Location = new System.Drawing.Point(227, 50);
            this.childName.Margin = new System.Windows.Forms.Padding(2);
            this.childName.Name = "childName";
            this.childName.Size = new System.Drawing.Size(212, 20);
            this.childName.TabIndex = 0;
            // 
            // groupedFeatures
            // 
            this.groupedFeatures.Controls.Add(this.feature9);
            this.groupedFeatures.Controls.Add(this.feature8);
            this.groupedFeatures.Controls.Add(this.feature7);
            this.groupedFeatures.Controls.Add(this.feature6);
            this.groupedFeatures.Controls.Add(this.feature5);
            this.groupedFeatures.Controls.Add(this.feature4);
            this.groupedFeatures.Controls.Add(this.feature3);
            this.groupedFeatures.Controls.Add(this.feature2);
            this.groupedFeatures.Controls.Add(this.feature1);
            this.groupedFeatures.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.groupedFeatures.Location = new System.Drawing.Point(17, 257);
            this.groupedFeatures.Margin = new System.Windows.Forms.Padding(2);
            this.groupedFeatures.Name = "groupedFeatures";
            this.groupedFeatures.Padding = new System.Windows.Forms.Padding(2);
            this.groupedFeatures.Size = new System.Drawing.Size(450, 162);
            this.groupedFeatures.TabIndex = 7;
            this.groupedFeatures.TabStop = false;
            this.groupedFeatures.Text = "Features";
            // 
            // feature1
            // 
            this.feature1.AutoSize = true;
            this.feature1.Checked = true;
            this.feature1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.feature1.Location = new System.Drawing.Point(22, 40);
            this.feature1.Margin = new System.Windows.Forms.Padding(2);
            this.feature1.Name = "feature1";
            this.feature1.Size = new System.Drawing.Size(80, 28);
            this.feature1.TabIndex = 9;
            this.feature1.Text = "Feature";
            this.feature1.UseVisualStyleBackColor = true;
            // 
            // feature2
            // 
            this.feature2.AutoSize = true;
            this.feature2.Location = new System.Drawing.Point(22, 79);
            this.feature2.Margin = new System.Windows.Forms.Padding(2);
            this.feature2.Name = "feature2";
            this.feature2.Size = new System.Drawing.Size(80, 28);
            this.feature2.TabIndex = 11;
            this.feature2.Text = "Feature";
            this.feature2.UseVisualStyleBackColor = true;
            // 
            // feature3
            // 
            this.feature3.AutoSize = true;
            this.feature3.Location = new System.Drawing.Point(22, 119);
            this.feature3.Margin = new System.Windows.Forms.Padding(2);
            this.feature3.Name = "feature3";
            this.feature3.Size = new System.Drawing.Size(80, 28);
            this.feature3.TabIndex = 14;
            this.feature3.Text = "Feature";
            this.feature3.UseVisualStyleBackColor = true;
            // 
            // feature4
            // 
            this.feature4.AutoSize = true;
            this.feature4.Location = new System.Drawing.Point(146, 40);
            this.feature4.Margin = new System.Windows.Forms.Padding(2);
            this.feature4.Name = "feature4";
            this.feature4.Size = new System.Drawing.Size(80, 28);
            this.feature4.TabIndex = 9;
            this.feature4.Text = "Feature";
            this.feature4.UseVisualStyleBackColor = true;
            // 
            // feature5
            // 
            this.feature5.AutoSize = true;
            this.feature5.Location = new System.Drawing.Point(146, 79);
            this.feature5.Margin = new System.Windows.Forms.Padding(2);
            this.feature5.Name = "feature5";
            this.feature5.Size = new System.Drawing.Size(80, 28);
            this.feature5.TabIndex = 12;
            this.feature5.Text = "Feature";
            this.feature5.UseVisualStyleBackColor = true;
            // 
            // feature6
            // 
            this.feature6.AutoSize = true;
            this.feature6.Location = new System.Drawing.Point(146, 119);
            this.feature6.Margin = new System.Windows.Forms.Padding(2);
            this.feature6.Name = "feature6";
            this.feature6.Size = new System.Drawing.Size(80, 28);
            this.feature6.TabIndex = 15;
            this.feature6.Text = "Feature";
            this.feature6.UseVisualStyleBackColor = true;
            // 
            // feature7
            // 
            this.feature7.AutoSize = true;
            this.feature7.Location = new System.Drawing.Point(257, 40);
            this.feature7.Margin = new System.Windows.Forms.Padding(2);
            this.feature7.Name = "feature7";
            this.feature7.Size = new System.Drawing.Size(80, 28);
            this.feature7.TabIndex = 10;
            this.feature7.Text = "Feature";
            this.feature7.UseVisualStyleBackColor = true;
            // 
            // feature8
            // 
            this.feature8.AutoSize = true;
            this.feature8.Location = new System.Drawing.Point(257, 79);
            this.feature8.Margin = new System.Windows.Forms.Padding(2);
            this.feature8.Name = "feature8";
            this.feature8.Size = new System.Drawing.Size(80, 28);
            this.feature8.TabIndex = 13;
            this.feature8.Text = "Feature";
            this.feature8.UseVisualStyleBackColor = true;
            // 
            // feature9
            // 
            this.feature9.AutoSize = true;
            this.feature9.Location = new System.Drawing.Point(257, 119);
            this.feature9.Margin = new System.Windows.Forms.Padding(2);
            this.feature9.Name = "feature9";
            this.feature9.Size = new System.Drawing.Size(80, 28);
            this.feature9.TabIndex = 16;
            this.feature9.Text = "Feature";
            this.feature9.UseVisualStyleBackColor = true;
            // 
            // childNameLabel
            // 
            this.childNameLabel.AutoSize = true;
            this.childNameLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.childNameLabel.Location = new System.Drawing.Point(124, 50);
            this.childNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.childNameLabel.Name = "childNameLabel";
            this.childNameLabel.Size = new System.Drawing.Size(49, 24);
            this.childNameLabel.TabIndex = 16;
            this.childNameLabel.Text = "Name:";
            // 
            // roomNumber
            // 
            this.roomNumber.Font = new System.Drawing.Font("Consolas", 8F);
            this.roomNumber.Location = new System.Drawing.Point(227, 203);
            this.roomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(212, 20);
            this.roomNumber.TabIndex = 4;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.roomNumberLabel.Location = new System.Drawing.Point(124, 203);
            this.roomNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(60, 24);
            this.roomNumberLabel.TabIndex = 21;
            this.roomNumberLabel.Text = "Room #:";
            // 
            // DOBpicker
            // 
            this.DOBpicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DOBpicker.Location = new System.Drawing.Point(227, 154);
            this.DOBpicker.Margin = new System.Windows.Forms.Padding(2);
            this.DOBpicker.Name = "DOBpicker";
            this.DOBpicker.Size = new System.Drawing.Size(212, 20);
            this.DOBpicker.TabIndex = 3;
            // 
            // detailsOfTheDayLabel
            // 
            this.detailsOfTheDayLabel.AutoSize = true;
            this.detailsOfTheDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsOfTheDayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.detailsOfTheDayLabel.Location = new System.Drawing.Point(476, 231);
            this.detailsOfTheDayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.detailsOfTheDayLabel.Name = "detailsOfTheDayLabel";
            this.detailsOfTheDayLabel.Size = new System.Drawing.Size(183, 13);
            this.detailsOfTheDayLabel.TabIndex = 24;
            this.detailsOfTheDayLabel.Text = "*click the image for details of the day.";
            // 
            // importImageButton
            // 
            this.importImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importImageButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.importImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.importImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.importImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importImageButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.importImageButton.ForeColor = System.Drawing.Color.DimGray;
            this.importImageButton.Location = new System.Drawing.Point(479, 257);
            this.importImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.importImageButton.Name = "importImageButton";
            this.importImageButton.Size = new System.Drawing.Size(186, 36);
            this.importImageButton.TabIndex = 6;
            this.importImageButton.Text = "Import Image";
            this.importImageButton.UseVisualStyleBackColor = true;
            this.importImageButton.Visible = false;
            this.importImageButton.Click += new System.EventHandler(this.importImageButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(479, 384);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(186, 36);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // childImageButton
            // 
            this.childImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.childImageButton.FlatAppearance.BorderSize = 0;
            this.childImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.childImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.childImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.childImageButton.Image = ((System.Drawing.Image)(resources.GetObject("childImageButton.Image")));
            this.childImageButton.Location = new System.Drawing.Point(479, 20);
            this.childImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.childImageButton.Name = "childImageButton";
            this.childImageButton.Size = new System.Drawing.Size(186, 208);
            this.childImageButton.TabIndex = 5;
            this.childImageButton.UseVisualStyleBackColor = true;
            this.childImageButton.Click += new System.EventHandler(this.childImageButton_Click_2);
            // 
            // genderPanel
            // 
            this.genderPanel.Controls.Add(this.male);
            this.genderPanel.Controls.Add(this.female);
            this.genderPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderPanel.Location = new System.Drawing.Point(227, 73);
            this.genderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(210, 67);
            this.genderPanel.TabIndex = 29;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Checked = true;
            this.female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.female.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.female.Image = ((System.Drawing.Image)(resources.GetObject("female.Image")));
            this.female.Location = new System.Drawing.Point(5, 16);
            this.female.Margin = new System.Windows.Forms.Padding(2);
            this.female.Name = "female";
            this.female.Padding = new System.Windows.Forms.Padding(2);
            this.female.Size = new System.Drawing.Size(109, 34);
            this.female.TabIndex = 2;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.male.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.male.Image = ((System.Drawing.Image)(resources.GetObject("male.Image")));
            this.male.Location = new System.Drawing.Point(118, 16);
            this.male.Margin = new System.Windows.Forms.Padding(2);
            this.male.Name = "male";
            this.male.Padding = new System.Windows.Forms.Padding(2);
            this.male.Size = new System.Drawing.Size(95, 34);
            this.male.TabIndex = 1;
            this.male.Text = "Male";
            this.male.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // childProfilePanel
            // 
            this.childProfilePanel.Controls.Add(this.genderPanel);
            this.childProfilePanel.Controls.Add(this.childImageButton);
            this.childProfilePanel.Controls.Add(this.saveButton);
            this.childProfilePanel.Controls.Add(this.importImageButton);
            this.childProfilePanel.Controls.Add(this.detailsOfTheDayLabel);
            this.childProfilePanel.Controls.Add(this.DOBpicker);
            this.childProfilePanel.Controls.Add(this.roomNumberLabel);
            this.childProfilePanel.Controls.Add(this.roomNumber);
            this.childProfilePanel.Controls.Add(this.childNameLabel);
            this.childProfilePanel.Controls.Add(this.groupedFeatures);
            this.childProfilePanel.Controls.Add(this.childName);
            this.childProfilePanel.Controls.Add(this.childDOBLabel);
            this.childProfilePanel.Controls.Add(this.genderLabel);
            this.childProfilePanel.Enabled = false;
            this.childProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.childProfilePanel.Margin = new System.Windows.Forms.Padding(2);
            this.childProfilePanel.Name = "childProfilePanel";
            this.childProfilePanel.Size = new System.Drawing.Size(690, 439);
            this.childProfilePanel.TabIndex = 29;
            this.childProfilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.childProfilePanel_Paint);
            // 
            // childForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(690, 439);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.childProfilePanel);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "childForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nusery Management System - Child Profile";
            this.Load += new System.EventHandler(this.Child_Load);
            this.groupedFeatures.ResumeLayout(false);
            this.groupedFeatures.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            this.childProfilePanel.ResumeLayout(false);
            this.childProfilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label childDOBLabel;
        private System.Windows.Forms.TextBox childName;
        private System.Windows.Forms.GroupBox groupedFeatures;
        private System.Windows.Forms.CheckBox feature9;
        private System.Windows.Forms.CheckBox feature8;
        private System.Windows.Forms.CheckBox feature7;
        private System.Windows.Forms.CheckBox feature6;
        private System.Windows.Forms.CheckBox feature5;
        private System.Windows.Forms.CheckBox feature4;
        private System.Windows.Forms.CheckBox feature3;
        private System.Windows.Forms.CheckBox feature2;
        private System.Windows.Forms.CheckBox feature1;
        private System.Windows.Forms.Label childNameLabel;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.DateTimePicker DOBpicker;
        private System.Windows.Forms.Label detailsOfTheDayLabel;
        private System.Windows.Forms.Button importImageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button childImageButton;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Panel childProfilePanel;
    }
}