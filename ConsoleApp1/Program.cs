using System;
using DataStructures;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputList = new int[] { 1 };
            ArrayList actual = new ArrayList(inputList);
            

            actual.PutLast(5);
            actual.DeleteLast();
            actual.DeleteLast();

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
