using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            string str = dp.getMessage("Message.txt");
            var res = str
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
            foreach (var item in res)
            {
                Console.WriteLine("item - {0}, frequaecy-{1:0.###}" ,item,(double)item.Value/str.Length);
            }
        }
    }
}
