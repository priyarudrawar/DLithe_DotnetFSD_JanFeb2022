using System;


namespace oops
{
    class inheritace
    {
        class Students //base class
        {
            public string name = "priyanka";
            public void details()
            {
                Console.WriteLine("Priyanka");

            }
        }
        class SchoolDetails : Students //child class Schooldetails
        {
            public string Schoolname = "DPS"; //school details declaration
        }
          //protected inheritance
        class A 
        {
            protected int x = 123;
        }
        class B : A
        {
           public void k()
            {
                A a = new A();
                B b = new B();
                //a.x = 10; // Error  
                b.x = 10; // OK  

            }
        }

        class Final
        {
            static void Main(string[] args)
            {
                SchoolDetails info = new SchoolDetails();
                info.details();
                Console.WriteLine(info.name + " " + info.Schoolname);


            }
        }
    }
}
