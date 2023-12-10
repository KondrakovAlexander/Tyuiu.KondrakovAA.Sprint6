using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KondrakovAA.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string s, string path)
        {
            string res = "";
            string[] words = File.ReadAllText(path).Replace("\n", " ").Split(' ');
            foreach (string word in words) 
            {
                if (word.Contains(s))
                {
                    res += word;
                }
            }
            return res;
        }
    }
}
