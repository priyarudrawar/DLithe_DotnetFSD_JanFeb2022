using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new ArrayList();   //arraylist collection
            data.Add("Priyanka");             // add element
            data.Add(1);
            data.Add(5);
            data.Add(26);
            data.Add(56.4);
            data.Add(32);
            data.Remove(5);              // remove element
            foreach (object obj in data)   // iteration
            {
                Console.WriteLine(obj);
                Console.ReadLine();
            }
        }
    }
}