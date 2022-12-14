using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    /*
     * Подтягивает информацию о себе с дб
     */
    class Product
    {
        string productName;
        int count;

        public Product(string productName, int count)
        {
            this.productName = productName;
            this.count = count;
        }


    }
}
