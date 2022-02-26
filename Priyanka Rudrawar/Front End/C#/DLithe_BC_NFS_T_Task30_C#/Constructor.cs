using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLithe_BC_NFS_T_Task30
{
    internal class Constructor
    {
        class sampleClass
        {
            int member1, member2;
            public sampleClass()
            {
                member1 = 10;
                member2 = 20;
            }
            public sampleClass(int member1, int member2)
            {
                this.member1 = member1;
                this.member2 = member2;
            }
            public void displayData()
            {
                Console.WriteLine("member1 = {0}, member2 = {1}");
            }
        }
        public class testClass
        {
            public static void Main()
            {
                sampleClass obj1 = new sampleClass();
                obj1.displayData();
                sampleClass obj2 = new sampleClass(100, 200);
                obj2.displayData();
            }
        }
    }
}