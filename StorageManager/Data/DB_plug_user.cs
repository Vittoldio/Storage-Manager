using StorageManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    /*
     *  Заглушка от которой в теорий мы получаем данные.
     * реализовать подгон данных из дб
     * 
     */
    class DB_plug_user
    {
        public List<string> login;
        //List<string> Login { get; set; }
        public List<string> password;
        // List<string> Password { get; set; }
        public DB_plug_user(string s)
        {
            Parser parser = new Parser("C:\\Users\\MetaphysicsNecrosis\\source\\repos\\Storage-ManagerV2\\passwords.txt");
            List<string> list = parser.GetStringList();
            this.login = new List<string>();
            this.password = new List<string>();
            for(int i = 0;i < list.Count;i += 2)
            {
                this.login.Add(list[i]);
                this.password.Add(list[i + 1]);
            }

        }
        public DB_plug_user()
        {
            SQLData data = new SQLData();
            List<string> gotData = new List<string>();

            gotData = data.Get_login_password();

            this.login = new List<string>();
            this.password = new List<string>();

            for(int i = 0;i < gotData.Count;i += 2)
            {
                this.login.Add(gotData[i]);
                this.password.Add((gotData[i + 1]));
            }
        }
        public bool LoginCheck(string s)
        {
            for (int i = 0; i < login.Count; i++)
            {
                if (login[i] == s)
                {
                    return true;
                }
            }
            return false;
        }
        public bool PasswordCheck(string log, string pas)
        {
            for (int i = 0; i < login.Count; i++)
            {
                if (login[i] == log)
                {
                    if (password[i] == pas)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}