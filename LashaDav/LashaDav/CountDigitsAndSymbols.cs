using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LashaDav
{
    internal class CountDigitsAndSymbols
    {
        public void DigitsCount()
        {
            string filePath = @"C:\Users\vakht\OneDrive\Desktop\LashaDav\LashaDav\RomeoAndJuliet.txt"; // ფაილის დასახელება
            string text = File.ReadAllText(filePath);// ფაილის წაკითხვა
            // სიმბოლოები დავათვლევინოთ
            int symbolCount = text.Length;
            // რიცხვები დავათვლევინოთ
            int digitCount = Regex.Matches(text, @"\d").Count;


            Console.WriteLine($"Total number of symbols and digits is {symbolCount + digitCount}");
            Console.WriteLine($"Numbers of symbols :{symbolCount}");
            Console.WriteLine($"Numbers of digits : {digitCount}");
            
        }
    }
}
