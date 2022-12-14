using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Data
{
    /*
     *  Заглушка от которой в теорий мы получаем данные.
     * реализовать подгон данных из дб
     * в его потомке будет функционал 
     * 
     * Для записки:
     *      storage агрегирует в себя продукт
     */
    class DB_plug_storage
    {
        private string name;
        private string adress;
        private Product someProduct;
        public DB_plug_storage(string name, string adress, Product someProduct)
        {
            this.name = name;
            this.adress = adress;
            this.someProduct = someProduct;
        }
        // Придумать поля

    }
}
