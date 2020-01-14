using System;

namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create an instance of Number class 
            Number myNumber = new Number(100000);

            //call print methods
            myNumber.PrintMoney();
            myNumber.PrintNumber();
        }
    }
}
