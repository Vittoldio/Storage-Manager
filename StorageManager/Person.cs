using StorageManager.AccessLevels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    public class Person : AdminLevel, UserLevel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime dateBirth;
        public string post { get; set; }
        public int workExperience { get; set; }
        public string AccessLevel { get; set; }
    }
}
