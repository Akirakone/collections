using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            int[] arrayOfInts = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (var i = 0; i < arrayOfInts.Length; i++)
            {
                arrayOfInts[i] = i;
            }
            foreach (var numbers in arrayOfInts)
            {
                Console.WriteLine(numbers);
            }
            //#2 
            string[] firstNames = new string[4] { "Tim", "Martin", "Nikki", "Sara" };
            foreach (var names in firstNames)
            {
                Console.WriteLine(names);
            }
            //#3 
            bool[] myArray = new bool[10] { true, false, true, false, true, false, true, false, true, false };
            for (var i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i % 2 == 0;
            }
            foreach (var boolean in myArray)
            {
                Console.WriteLine(boolean);
            }
            //#4 
            Random rand = new Random();
           
            List<string> icecream = new List<string>();
            icecream.Add("Vanilla");
            icecream.Add("Chocolate");
            icecream.Add("Strawberry");
            icecream.Add("Cherry");
            icecream.Add("Oreo");
            Console.WriteLine(icecream[3]);
            Console.WriteLine($"We currently have {icecream.Count} ice cream flavors.");

            icecream.Remove("Cherry");
            Console.WriteLine($"We now have {icecream.Count} ice cream flavors.");

            //#5

            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < firstNames.Length; i++)
            {
                users.Add(firstNames[i], icecream[rand.Next(icecream.Count)]);
            }
            foreach (KeyValuePair<string, string> entry in users)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }


        }



    }
    }
