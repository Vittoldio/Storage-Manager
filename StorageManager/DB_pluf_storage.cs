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
     * в его потомке будет функционал 
     */
    class DB_plug_storage 
    {                       
        private string name;
        private string adress;
        public DB_plug_storage(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
        }
        // Придумать поля

    }
}
