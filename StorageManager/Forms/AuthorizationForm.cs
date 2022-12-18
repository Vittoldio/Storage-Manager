using StorageManager.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            /*
             * public void Add_login_password(string login, string password)
             * эта дура тебе на раз два даст возможность добавить пароль в бд
             */
            DB_plug_user db = new DB_plug_user();

            if (!db.LoginCheck(this.LoginTextBox.Text)) // if any user.login will not be found
            {
                this.label1.Text = "не тот логин";
                this.label1.Visible = true;
                FailedAuth();
                return;
            }
            if (!db.PasswordCheck(this.LoginTextBox.Text, this.PasswordTextBox.Text)) // if concret user.password will not be true not be noe false koro4e
            {
                this.label2.Text = "пароль вспоминай";
                this.label2.Visible = true;
                this.label1.Visible = false;
                FailedAuth();
                return;
            }
            Program.validationFlag = true;
            Program.login = this.LoginTextBox.Text;
            this.Close();

        }
        private void FailedAuth()
        {
            this.authTries++;
            if (authTries == 20)
            {
                MessageBox.Show("nice try");
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            UpdateSql addUser = new UpdateSql();
            DB_plug_user doesExist = new DB_plug_user();

            for (int i = 0;i < doesExist.login.Count;i++)
            {
                if (doesExist.login[i] == this.LoginTextBox.Text) 
                {
                    this.label1.Text = "Login exists";
                    this.label1.Visible = true;
                    return;
                }
            }
            this.label1.Text = "Welcome here";
            this.label1.Visible = true;
            //this.label1.Visible= false;
            addUser.Add_login_password(this.LoginTextBox.Text, this.PasswordTextBox.Text);
        }
    }
}
