using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLithe_BC_NFS_T_Task30
{
    internal class Refrence
    {
        public static string GetNextName(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("First Valye of Integer:" + i.ToString());
            string test = GetNextName(ref i);
            Console.WriteLine("Now the value of Integer i is :" + i.ToString());
        }
    }
}