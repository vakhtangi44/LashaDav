using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashaDav
{
    public class WordCount
    {
        public void CountWord()
        {          
            string filePath = @"C:\Users\vakht\OneDrive\Desktop\LashaDav\LashaDav\RomeoAndJuliet.txt"; // ფაილის დასახელება
            string text = File.ReadAllText(filePath);
            Console.WriteLine("Word count: " + text.Split(' ').Count(x => x.Length > 0));            
        }
    }
}
