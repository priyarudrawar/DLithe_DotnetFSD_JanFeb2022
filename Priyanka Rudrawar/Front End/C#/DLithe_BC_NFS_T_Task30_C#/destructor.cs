using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLithe_BC_NFS_T_Task30
{
    internal class Destructor
    {
        class baseClass
        {
            public baseClass()
            {
                Console.WriteLine("Executing Constructor of baseClass");
            }
            ~baseClass()
            {
                Console.WriteLine("Executing Destructor of baseClass");
            }
        }
        class level1 : baseClass
        {
            public level1()
            {
                Console.WriteLine("Executing Constructor of level1");
            }
            ~level1()
            {
                Console.WriteLine("Executing Destructor of level1");
            }
        }
        class level2 : level1
        {
            public level2()
            {
                Console.WriteLine("Executing Constructor of level2");
            }
            ~level2()
            {
                Console.WriteLine("Executing Destructor of level2");
            }
        }
        class testClass
        {
            public static void Main()
            {
                level2 obj = new level2();
                Console.WriteLine("Object Instantiation successful");
                obj = null;
                Console.WriteLine("Releasing Object and Forcing Garbage Collection…");
                GC.Collect();
            }
        }
    }
}