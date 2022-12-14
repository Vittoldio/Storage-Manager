using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    class Section : DB_plug_storage
    {
        string name;
        string adress;
        Product someProduct; // Поля товаров 
        public Section(string name, string adress, Product someProduct)
            : base(name, adress, someProduct)
        {

        }
    }
}
