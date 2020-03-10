using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 158;
            object obj = num1; // boxing
            Console.WriteLine(num1);
            Console.WriteLine(num1.GetType());

            sbyte num2 = (sbyte)(short)obj; //unboxing
            Console.WriteLine(num2);
            Console.WriteLine(num2.GetType());
            Console.Read();
        }
    }
}
