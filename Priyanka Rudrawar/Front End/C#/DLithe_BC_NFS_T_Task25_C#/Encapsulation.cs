
using System;
using System.Reflection;


public class Encapsulation
{


    private String Name;
    private int Age;

  
    public String name
    {

        get
        {
            return Name;
        }

        set
        {
            Name = value;
        }

    }

    // using accessors to get and 
    // set the value of studentAge
    public int age
    {

        get
        {
            return Age;
        }

        set
        {
            Age = value;
        }

    }


}

class Details
{
    static public void Main()
    {



        Encapsulation Employee = new Encapsulation();


        Employee.name = "Priyanka";

        Employee.age = 26;

        Console.WriteLine("Name: " + Employee.name);
        Console.WriteLine("Age: " + Employee.age);

       


      
    }
}
  