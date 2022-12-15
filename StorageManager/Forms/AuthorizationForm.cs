using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageManager
{
    public partial class AuthorizationForm : Form
    {
        private int authTries = 0;
        public AuthorizationForm()
        {
            InitializeComponent();
            VisualInit();
        }
        private void AuthButton_Click(object sender, EventArgs e)
        {
            DB_plug_user db = new DB_plug_user();

            if (!db.LoginCheck(this.LoginTextBox.Text)) // if any user.login will not be found
            {
                FailedAuth();
                return;
            }
            if (!db.PasswordCheck(this.LoginTextBox.Text, this.PasswordTextBox.Text)) // if concret user.password will not be true not be noe false koro4e
            {
                FailedAuth();
                return;
            }

            this.Close();

        }
        private void FailedAuth()
        {
            this.authTries++;
            if (authTries == 20)
            {
                Application.Exit();
            }
        }
        public void VisualInit()
        {
            // Здесь прописываем визуал
            this.MinimumSize = new Size(600, 400);
            this.MaximumSize = new Size(600, 400);

            this.LoginLabel.Text = "Login";

            this.LoginTextBox.MaxLength = 20;
            this.LoginTextBox.Text = "";

            this.PasswordTextBox.MaxLength = 20;
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Text = "";

            this.PasswordLabel.Text = "Password";

            this.AuthButton.Text = "Auth";

        }
    }
}
