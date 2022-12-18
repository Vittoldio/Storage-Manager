namespace StorageManager
{
    partial class Modal_UpdateUsers
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.switchModeButton = new System.Windows.Forms.Button();
            this.addRemoveButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(226, 22);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 20);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "label1";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(12, 124);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(50, 20);
            this.modeLabel.TabIndex = 1;
            this.modeLabel.Text = "label2";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 173);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(50, 20);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.Text = "label3";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(226, 61);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(50, 20);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "label5";
            // 
            // switchModeButton
            // 
            this.switchModeButton.Location = new System.Drawing.Point(12, 304);
            this.switchModeButton.Name = "switchModeButton";
            this.switchModeButton.Size = new System.Drawing.Size(159, 37);
            this.switchModeButton.TabIndex = 5;
            this.switchModeButton.Text = "button1";
            this.switchModeButton.UseVisualStyleBackColor = true;
            this.switchModeButton.Click += new System.EventHandler(this.switchModeButton_Click);
            // 
            // addRemoveButton
            // 
            this.addRemoveButton.Location = new System.Drawing.Point(12, 261);
            this.addRemoveButton.Name = "addRemoveButton";
            this.addRemoveButton.Size = new System.Drawing.Size(159, 37);
            this.addRemoveButton.TabIndex = 6;
            this.addRemoveButton.Text = "button2";
            this.addRemoveButton.UseVisualStyleBackColor = true;
            this.addRemoveButton.Click += new System.EventHandler(this.addRemoveButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 19);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(159, 27);
            this.loginTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 58);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(159, 27);
            this.passwordTextBox.TabIndex = 8;
            // 
            // Modal_UpdateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 372);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.addRemoveButton);
            this.Controls.Add(this.switchModeButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "Modal_UpdateUsers";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginLabel;
        private Label modeLabel;
        private Label errorLabel;
        private Label passwordLabel;
        private Button switchModeButton;
        private Button addRemoveButton;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
    }
}