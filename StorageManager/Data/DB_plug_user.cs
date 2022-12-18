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
        public List<string> password;
        public DB_plug_user()
        {
            SQLData data = new SQLData();
            List<string> gotData = new List<string>();

            gotData = data.Get_id_login_password();

            this.login = new List<string>();
            this.password = new List<string>();

            for(int i = 0;i < gotData.Count;i += 3)
            {
                this.login.Add(gotData[i + 1]);
                this.password.Add(gotData[i + 2]);
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