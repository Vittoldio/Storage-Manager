namespace StorageManager
{
    partial class MainFormUser
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
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.TaskSchedulerBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserLabel.Location = new System.Drawing.Point(22, 17);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(127, 28);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "USER MODE";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(22, 94);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(65, 28);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "label2";
            // 
            // TaskSchedulerBox
            // 
            this.TaskSchedulerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskSchedulerBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskSchedulerBox.Location = new System.Drawing.Point(271, 17);
            this.TaskSchedulerBox.Name = "TaskSchedulerBox";
            this.TaskSchedulerBox.Size = new System.Drawing.Size(414, 371);
            this.TaskSchedulerBox.TabIndex = 3;
            // 
            // MainFormUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1500, 832);
            this.Controls.Add(this.TaskSchedulerBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainFormUser";
            this.Text = "MainFormUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label UserLabel;
        private Label UserNameLabel;
        private Panel TaskSchedulerBox;
    }
}