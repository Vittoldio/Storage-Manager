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
            this.components = new System.ComponentModel.Container();
            this.TaskSchedulerBox = new System.Windows.Forms.GroupBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskSchedulerBox
            // 
            this.TaskSchedulerBox.Location = new System.Drawing.Point(351, 9);
            this.TaskSchedulerBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskSchedulerBox.Name = "TaskSchedulerBox";
            this.TaskSchedulerBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskSchedulerBox.Size = new System.Drawing.Size(351, 320);
            this.TaskSchedulerBox.TabIndex = 0;
            this.TaskSchedulerBox.TabStop = false;
            this.TaskSchedulerBox.Text = "groupBox1";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserLabel.Location = new System.Drawing.Point(10, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(102, 21);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "USER MODE";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(10, 38);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(52, 21);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "label2";
            // 
            // MainFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.TaskSchedulerBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainFormUser";
            this.Text = "MainFormUser";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox TaskSchedulerBox;
        private Label UserLabel;
        private Label UserNameLabel;
        private BindingSource bindingSource1;
    }
}