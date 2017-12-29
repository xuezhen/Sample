using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "aa", "bb", "aa", "cc", "dd", "ee", "ff", "", "bb" };
            List<string> lst1Distinct = list.Distinct().ToList();
            foreach (var item in lst1Distinct)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
