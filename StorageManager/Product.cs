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
        DateTime creationDate, expiredDate;

        public Product(string productName, int count, DateTime creationDate, DateTime expiredDate)
        {
            this.productName = productName;
            this.count = count;
            this.creationDate = creationDate;
            this.expiredDate = expiredDate;
        }


    }
}
