using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLithe_BC_NFS_T_Task30
{
    internal class Dictonary
    {

        public class DictionaryExample
        {
            public static void Main(string[] args)
            {
                Dictionary<string, string> names = new Dictionary<string, string>();
                names.Add("1", "pune");
                names.Add("2", "nagpur");
                names.Add("3", "Nanded");
                names.Add("4", "mumbai");
                names.Add("5", "Palam");

                foreach (KeyValuePair<string, string> kv in names)
                {
                    Console.WriteLine(kv.Key + " " + kv.Value);
                }
            }
        }
    }
}