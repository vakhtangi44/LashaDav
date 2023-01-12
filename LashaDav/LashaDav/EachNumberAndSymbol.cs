using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LashaDav
{
    internal class EachNumberAndSymbol
    {
        public void EachNumAndSym()
        {
            string fileName = @"C:\Users\vakht\OneDrive\Desktop\LashaDav\LashaDav\RomeoAndJuliet.txt"; // ფაილის დასახელება
            int[] charCounts = new int[256]; // არაი თითოეული სიმბოლოს რაოდენობის შესანახად
            int[] numCounts = new int[10]; // არაი თითოეული ნომრის რაოდენობის შესანახად

            // წავაკითხოთ ფაილი
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    char c = (char)reader.Read();
                    if (char.IsLetter(c))
                    {
                        charCounts[c]++;
                    }
                    else if (char.IsDigit(c))
                    {
                        numCounts[c - '0']++;
                    }
                }
            }

            // დავპრინტოთ "სიმბოლოები" ჩარი. აქ დიდ პატარა ასოს ვაპრინტინებ ცალ-ცალკე გაერთიანება თუ დაგჭირდება თუ სმოლზე გაუშვი ტექსტი.
            Console.WriteLine("Character count:");
            for (int i = 0; i < charCounts.Length; i++)
            {
                if (charCounts[i] > 0)
                {
                    Console.WriteLine("{0}: {1}", (char)i, charCounts[i]);
                }
            }

            // დავპრინტოთ თითო რიცხვი
            Console.WriteLine("\nNumber count:");
            for (int i = 0; i < numCounts.Length; i++)
            {
                if (numCounts[i] > 0)
                {
                    Console.WriteLine("{0}: {1}", i, numCounts[i]);
                }
            }
        }
    }
}