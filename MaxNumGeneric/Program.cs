using System;

namespace MaxNumGeneric
{
    class Program
    {
        static void Main(string[] args)//main method
        {
            Console.WriteLine("Welcome to Generic Program");
            Console.WriteLine("Maximum Number is :");
            int output = MaximumNumber.MaximumInteger(90, 80, 30);// calling method for integer
            double doubleoutput = MaximumNumber.MaximumFloat(30.23, 42.43, 53.22);//calling method for float
            string stringoutput = MaximumNumber.MaximumString("40", "60", "85");  //calling method for string
            Console.WriteLine(output);
        }
    }
}
