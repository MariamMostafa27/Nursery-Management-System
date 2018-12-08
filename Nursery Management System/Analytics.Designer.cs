namespace Nursery_Management_System
{
    partial class Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            this.analyticsChart = new LiveCharts.WinForms.CartesianChart();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // analyticsChart
            // 
            this.analyticsChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.analyticsChart.Location = new System.Drawing.Point(0, 85);
            this.analyticsChart.Name = "analyticsChart";
            this.analyticsChart.Size = new System.Drawing.Size(920, 455);
            this.analyticsChart.TabIndex = 0;
            this.analyticsChart.Text = "Analytics Chart";
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
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.analyticsChart);
            this.Name = "Analytics";
            this.Text = "Nusery Management System - Analytics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart analyticsChart;
        private System.Windows.Forms.Button backButton;
    }
}