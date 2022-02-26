using System;

namespace CompleteInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Record myRecord = new Record("Priyanka", 25, "Palam");
            myRecord.PrintRecord();
            Console.ReadLine();
        }
    }
}