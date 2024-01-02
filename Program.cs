using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //In the Main() method, create an object of data type Number and assign an amount to it
            
            Number number;

            number.amount = 4.5m;
           
            //Print this amount to the console
            Console.WriteLine(number.amount);
        }


        struct Number
        {   //Create a struct called Number and give it the property “Amount” and have it be of data type decimal
            public decimal amount;
           
        }
    }
}
