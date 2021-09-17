using System;

namespace MaxNumGeneric
{
    class Program
    {
        static void Main(string[] args)//main method
        {
            Console.WriteLine("Welcome to Generic Program");
            Console.WriteLine("Maximum Number is :");
            int output = MaximumNumber.MaximumInteger(90, 80, 30);//calling method
            Console.WriteLine(output);
        }
    }
}
