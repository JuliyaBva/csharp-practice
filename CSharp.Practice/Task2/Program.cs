using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            //simple types: (int) 45, (boolean) true, (double) 23.45 - value types; (string) "Hello" - reference type
            arrayList.Add(45);
            arrayList.Add(true);
            arrayList.Add("Hello!");
            arrayList.Add(23.45);
        }
    }
}
