using System;
public class ArrayExample
{
    public static void Main(string[] args)
    {
        string[] arr = {"priyu","manisha"   };//Declaration of 1d array

        //traversing array  
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}