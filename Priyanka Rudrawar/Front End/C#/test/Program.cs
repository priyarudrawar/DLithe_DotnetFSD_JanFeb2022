using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)


        {


            Console.WriteLine("Enter Employee Full Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Employee salary");
            string Employeeid = Console.ReadLine();
            Console.WriteLine("Enter Employee Age ");
            string Age = Console.ReadLine();
            Console.WriteLine("Employee Address");
            string address = Console.ReadLine();
            Console.WriteLine("Employee Designation");
            string designation = Console.ReadLine();

            // Create a string variable and get user input from the keyboard and store it in the variable


            Console.WriteLine("-------------------------------------------------/n");

            // Print the value of the variable (userNames), which will display the input value
            Console.WriteLine("Employee Full name is : " + userName);
            Console.WriteLine("Employee id is " + Employeeid);
            Console.WriteLine("Employee age is " + Age);
            Console.WriteLine("Employee Address is " + address);
            Console.WriteLine("Employee Address is " + designation);
            Console.WriteLine("" +
                "" +
                "" +
                "" +
                "");



            //performing arithmatic operation
            Console.WriteLine("BASICS ARTIHMATIC OPERATIONS");
            Console.WriteLine("Enter 1 st value");
            int a = Convert.ToInt16(Console.ReadLine());
          //  Decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value");
            int b = Convert.ToInt16(Console.ReadLine());

            int result;
            result = a + b;
            Console.WriteLine("Value is {0}", result);
            result = a - b;
            Console.WriteLine("Value is {0}", result);
            result = a * b;
            Console.WriteLine("Value is {0}", result);
            result = a / b;
            Console.WriteLine("Value is {0}", result);
            result = a % b;
            Console.WriteLine("Value is {0}", result);
            result = a++;
            Console.WriteLine("Value is {0}", result);
            result = a--;
            Console.WriteLine("Value is {0}", result);
            Console.ReadLine();


            //swap of two nos 

            Console.WriteLine("SWAPPING OF TWO NOS ");
            Console.WriteLine("/n ");
            Console.WriteLine("Enter 1 st value for swapping ");
            int j = Convert.ToInt16(Console.ReadLine()); // typecasting int
            Console.WriteLine("Enter 2nd Value for swapping");
            int k = Convert.ToInt16(Console.ReadLine());  //typecasting

            Console.WriteLine("Before swap j= " + j + " k= " + k); //printing normal
            j = j * k; //j=50 (5*10)      
            k = j / k; //k=5 (50/10)      
            j = j / k; //j=10 (50/5)    
            Console.Write("After swap j= " + j + " k= " + k);


            //without using 3rd variable



            //find the largest nos 

            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of between  three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Enter 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is greatest \n\n" , num1);
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest no. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest no \n\n" , num2);
            else
                Console.Write("The 3rd Number is the greatest no \n\n", num3);
        }


    }
}





