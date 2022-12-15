using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    class Person : _user
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string secondName;
        public string SecondName { get { return secondName; } set { secondName = value; } }

        private string sex;
        public string Sex { get { return sex; } set { sex = value; } }

        private string post;
        public string Post { get { return post; } set { post = value; } }

        private DateTime birthDate;
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }

        private int workExperience;
        public int WorkExperience { get { return workExperience; } set { workExperience = value; } }

        public Person(string name, string secondName, string sex, string post, DateTime birthDate, int workExperience, string login, string password)
            :base(password, login)
        {
            this.Name = name;
            this.SecondName = secondName;
            this.Sex = sex;
            this.Post = post;
            this.BirthDate = birthDate;
            this.WorkExperience = workExperience;
        }
        
    }
}
