using System;
namespace stringmethod;

class main
{
    string name = "Priyanka Rudrawar";
    string address = "Palam";
    string HigestQualification = "BE";
    String Country = "India";

    // object[] test = { "name", "address", 8668527346, +91 };
    //string js = string.Join(", ", test);

    class program
    {
        public static void Main(string[] args)
        {

            //clone sting method 
            string s1 = "Priyanka Rudrawar ";
            string s2 = (String)s1.Clone();  //using the clone method
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            main n1 = new main();
            string copy = string.Copy(s1);  //copy string using copy() from s1

            Console.WriteLine("my name is", n1.name);
            Console.WriteLine(n1.name);
            Console.WriteLine(n1.address);
            Console.WriteLine(n1.Country);

            Console.WriteLine("--------------------------------------------------Compare methods in string------------------------");
            //compare the string
            string c1 = "Priyanka Rudrawar";
            string c2 = "Priyanka Rudrawar";


            Console.WriteLine(string.Compare(c1, c2));
            Console.WriteLine(string.Compare(c2, c1));
            Console.WriteLine("--------------------------------------------------CompareOrdinal() in string------------------------");


            //compare oridnal method used here 
            Console.WriteLine(string.CompareOrdinal(c1, c2));

            Console.WriteLine("--------------------------------------------------CompareTo() in string------------------------");


            Console.WriteLine(c1.CompareTo(c2));  //we using same string c1 and c2 to perform all the methods on string

            //concatination methods 
            Console.WriteLine("--------------------------------------------------Concatination in string------------------------");

            Console.WriteLine(string.Concat(c1, c2));
            //contains methods in string
            Console.WriteLine("--------------------------------------------------Contains in string return true or false------------------------");

            Console.WriteLine(c1.Contains(c2));
            //copy to 
            Console.WriteLine("--------------------------------------------------Copy method  in string------------------------");

            Console.WriteLine(copy);
            Console.WriteLine("--------------------------------------------------Get Emunrator method in string------------------------");


            //getemunrator methods
            CharEnumerator ch = c2.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
            }
            Console.WriteLine("-------------------------------------------------Split method in string------------------------");

            //split method  in string
            string k = "Hello C Sharp";
            string[] k2 = s1.Split(' ');
            foreach (string i in k2)
            {
                Console.WriteLine(i);
            }


        }
    }

}