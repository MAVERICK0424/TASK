using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n: ");
            int valueOfn = int.Parse(Console.ReadLine());
            string result = Class1.practice(valueOfn);

            Console.WriteLine(result);
        }       
    } 
}
