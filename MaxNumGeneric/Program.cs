using System;

namespace GenericMaximum
{
    class Program
    {
        static void Main(string[] args)//main method
        {
            Console.WriteLine("Welcome to Generic Program");
            Console.WriteLine("Maximum Number is :");
            /*int output = MaximumNumber.MaximumInteger(90, 80, 30);// calling method for integer
             double doubleoutput = MaximumNumber.MaximumFloat(30.23, 42.43, 53.22);//calling method for float
             string stringoutput = MaximumNumber.MaximumString("40", "60", "85");  //calling method for string
             Console.WriteLine(output);*/
            int[] intArray = { 112, 344, 432, 634, 488 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 120.2, 34.8, 46.3, 568.5, 686.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "apple", "mango", "orange", "banana", "grapes" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();

        }
    }
}
