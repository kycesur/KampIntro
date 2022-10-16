using System;
using System.Collections.Generic;

namespace _MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(78, "Karabük");
            myDictionary.Add(74, "Bartın");
           
          
            Console.WriteLine(myDictionary.Count);
        }
    }
}
