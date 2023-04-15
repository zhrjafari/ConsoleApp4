using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace project
{
    class test1
    {
        public static void Main()
        {
            Console.WriteLine("enter num1 & num2");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Calc(num1,num2);
        }//end main

        private static void Calc(double num1, double num2)
        {
            double Result = (0.35*num1) + (0.65 * num2);
            if (Result > 10)
                Console.WriteLine("pass");
            else
                Console.WriteLine("fail");
        }
    }
}
