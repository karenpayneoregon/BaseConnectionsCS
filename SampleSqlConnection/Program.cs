using System;
using SampleSqlConnection.Classes;

namespace SampleSqlConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DataOperations ops = new DataOperations();
            ops.TestSqlConnection();
            if (ops.IsSuccessFul)
            {
                var foregroundColorColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Successfully connected!!!");
                Console.ForegroundColor = foregroundColorColor;
            }
            else
            {
                var foregroundColorColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unsuccessful");
                Console.ForegroundColor = foregroundColorColor;
                Console.WriteLine(ops.LastExceptionMessage);
            }
            Console.ReadLine();
        }
    }
}
