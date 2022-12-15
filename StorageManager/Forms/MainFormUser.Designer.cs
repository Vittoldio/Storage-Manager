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
            this.TaskSchedulerBox = new System.Windows.Forms.GroupBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TaskSchedulerBox
            // 
            this.TaskSchedulerBox.Location = new System.Drawing.Point(401, 12);
            this.TaskSchedulerBox.Name = "TaskSchedulerBox";
            this.TaskSchedulerBox.Size = new System.Drawing.Size(401, 426);
            this.TaskSchedulerBox.TabIndex = 0;
            this.TaskSchedulerBox.TabStop = false;
            this.TaskSchedulerBox.Text = "groupBox1";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserLabel.Location = new System.Drawing.Point(12, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(127, 28);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "USER MODE";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(12, 51);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(65, 28);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "label2";
            // 
            // MainFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.TaskSchedulerBox);
            this.Name = "MainFormUser";
            this.Text = "MainFormUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox TaskSchedulerBox;
        private Label UserLabel;
        private Label UserNameLabel;
    }
}