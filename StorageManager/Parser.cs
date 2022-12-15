using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager
{
    class Parser
    {
        StreamReader reader;
        StreamWriter writer;
        string path;
        public Parser(string path)
        {
            this.path = path;
        }

        public List<string> GetStringList()
        {
            this.OpenReader();
            List<string> list = new List<string>();
            string[] strs = this.reader.ReadToEnd().Split(' ', '\n');
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i] != "" && strs[i] != " " && strs[i] != "\n" && strs[i][0] != (char)13)
                {
                    if(strs[i][strs[i].Length - 1] == '\r')
                    {
                        strs[i] = strs[i].Remove(strs[i].Length - 1);
                    }
                    list.Add(strs[i]);
                }
            }
            this.CloseReader();
            return list;
        }
        private void OpenReader()
        {
            this.reader = new StreamReader(this.path);
        }

        private void CloseReader()
        {
            this.reader.Close();
        }

    }
}

