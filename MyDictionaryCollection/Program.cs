using System;
using System.Collections.Generic;

namespace MyDictionaryCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            //eng-tr
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("pencil", "kalem");

            //Console.WriteLine(dictionary.Count);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("***********************************");

            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            //eng-tr
            myDictionary.Add("book", "kitap");
            myDictionary.Add("table", "tablo");
            myDictionary.Add("pencil", "kalem");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.ReadLine();
        }
    }
}
