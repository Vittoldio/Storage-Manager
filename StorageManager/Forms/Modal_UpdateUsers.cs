using StorageManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class Modal_UpdateUsers : Form
    {
        public Modal_UpdateUsers()
        {
            InitializeComponent();
            visualInit();
            
        }
        bool mode = true;

        private void visualInit()
        {
            this.passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.loginLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.modeLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.addRemoveButton.TextAlign = ContentAlignment.MiddleCenter;
            this.switchModeButton.TextAlign = ContentAlignment.MiddleCenter;

            this.passwordLabel.Text = "password";
            this.loginLabel.Text = "login";

            this.errorLabel.Visible= false;
            this.errorLabel.ForeColor = Color.Red;

            this.switchModeButton.Text = "switch";
            this.modeLabel.Text = "Adding mode";

            this.addRemoveButton.Text = "Add";

        }

        private void addRemoveButton_Click(object sender, EventArgs e)
        {
            /*
             * if mode is true mode Add
             * if mode is false mode remove
             */
            if (this.loginTextBox.Text.IndexOf(' ') != -1 || 
                this.loginTextBox.Text == "" ||
                this.loginTextBox.Text.IndexOf('\n') != -1)
            {
                errorLabel.Text = "Incorrect login";
                errorLabel.Visible = true;
                return;
            }
            if (mode is true)
            {
                UpdateSql sql = new UpdateSql();
                if (sql.DoesExist_Login(this.loginTextBox.Text))
                {
                    errorLabel.Text = "Login already exists";
                    errorLabel.Visible = true;
                    return;
                }
                errorLabel.Visible = false;
                sql.Add_login_password(this.loginTextBox.Text, this.passwordTextBox.Text);
            }
            if (mode is false)
            {
                UpdateSql sql = new UpdateSql();
                if (sql.DoesExist_Login(this.loginTextBox.Text))
                {
                    errorLabel.Text = "Login doesnt exist";
                    errorLabel.Visible = true;
                    return;
                }
                errorLabel.Visible = false;
                sql.Remove_login_password(this.loginTextBox.Text);
            }
        }

        private void switchModeButton_Click(object sender, EventArgs e)
        {
            this.mode = !this.mode;

            if (this.mode is true)
            {
                this.passwordLabel.Visible = mode;
                this.passwordTextBox.Visible = mode;
                this.addRemoveButton.Text = "Add";
                this.modeLabel.Text = "Adding mode";
            }
            else
            {
                this.passwordLabel.Visible = false;
                this.passwordTextBox.Visible = false;
                this.addRemoveButton.Text = "Remove";
                this.modeLabel.Text = "Removing mode";
            }
        }
    }
}
