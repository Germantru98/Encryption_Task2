using System;
using System.Collections.Generic;
using System.Linq;

namespace Encryption_Task2
{
    internal class Program
    {
        private static void CleanUp(Dictionary<char, int> dictionary, char[] alphabet)
        {
            List<char> tmp = dictionary.Keys.ToList();
            char[] eng = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'V', 'X', 'Y', 'Z' };
            for (int i = 0; i < tmp.Count; i++)
            {
                if (!char.IsLetter(tmp[i]) || eng.Contains(char.ToUpper(tmp[i])))
                {
                    dictionary.Remove(tmp[i]);
                }
            }
        }

        private static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            char[] alphabet = dp.GetAlphabet();
            string str = dp.getMessage("Message.txt");
            var res = str
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
            CleanUp(res, alphabet);
            foreach (var item in res)
            {
                Console.WriteLine("item - {0}, frequency {1:0.###}", item, (double)item.Value / alphabet.Length);
            }
        }
    }
}