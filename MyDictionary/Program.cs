using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> items = new Dictionary<int, string>();

            items.Add(12, "Demet");
            items.Add(22, "Aleyna");
            items.Add(34, "Dilan");

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
          

            Console.WriteLine("myItems.Count : " + items.Count);


          

            MyDictionary<int, string> myItems = new MyDictionary<int, string>();
            Console.WriteLine("myItems.Count : " + myItems.Count);

            myItems.Add(12, "Demet");
            myItems.Add(22, "Aleyna");
            myItems.Add(34, "Dilan");

            foreach (var item in myItems.KeyList)
            {
                Console.WriteLine(item);

            }

            foreach (var item in myItems.ValueList)
            {
                Console.WriteLine(item);

            }



            Console.WriteLine("myItems.Count : " + myItems.Count);

            Console.ReadLine();

        }
    }
}
   