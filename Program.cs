using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arrayOfInts = {0,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(arrayOfInts[0]);
            foreach( int x in arrayOfInts)
            {
                Console.WriteLine($"Number: {x}");
            }
            string[] arrayOfStrings = {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(arrayOfStrings[0]);
            foreach(string x in arrayOfStrings){
                Console.WriteLine($"Name: {x}");
            }
            bool[] boolArray = new bool[10];
            bool[] boolArray2 = {true,false,true,false,true,false,true,false,true,false};
            Console.WriteLine(boolArray2[0]);

            List<string> iceCream = new List<string>();
            iceCream.Add("strawberry");
            iceCream.Add("chocolate");
            iceCream.Add("vanilla");
            iceCream.Add("pistachio");
            iceCream.Add("rainbow sherbert");

            for (var x = 0; x < iceCream.Count; x++)
            {
                Console.WriteLine("The flavor of the month is: " + iceCream[x]);
            }
            Console.WriteLine("The length of this list is: " + iceCream.Count);
            Console.WriteLine($"The third flavor is {iceCream[2]}");
            iceCream.RemoveAt(2);
            Console.WriteLine("After removing the third item, the new length of this list is: " + iceCream.Count);
            
            Random rand = new Random();
            Dictionary<string, string> flavors = new Dictionary<string, string>();
            for(int i = 0; i < arrayOfStrings.Length; i++)
            {
                flavors.Add(arrayOfStrings[i], iceCream[rand.Next(iceCream.Count)]);
            }
            foreach(KeyValuePair<string,string> x in flavors)
            {
                Console.WriteLine(x.Key + "-" + x.Value);
            }

        }
    }
}
