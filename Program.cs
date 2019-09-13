using System;
using System.Linq;

namespace Encryption_Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            string str = dp.getMessage("Message.txt");
            var res = str
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
            foreach (var item in res)
            {
                Console.WriteLine("item - {0}, frequency -{1:0.###}", item, (double)item.Value / str.Length);
            }
        }
    }
}