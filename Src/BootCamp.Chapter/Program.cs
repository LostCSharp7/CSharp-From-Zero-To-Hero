using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary: 10, Integer: " + BinaryConverter.ToInteger("10"));
            Console.WriteLine("Binary: 101, Integer: " + BinaryConverter.ToInteger("101"));
            Console.WriteLine("Binary: 1000, Integer: " + BinaryConverter.ToInteger("1000"));
            Console.WriteLine("Binary: 1001, Integer: " + BinaryConverter.ToInteger("1001"));
            try
            {
               // Console.WriteLine("Binary: 2, Integer: " + BinaryConverter.ToInteger("2"));
                Console.WriteLine("Binary: 2, Integer: " + BinaryConverter.ToInteger("a"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Integer: 10, Integer: " + BinaryConverter.ToBinary(10));
            Console.WriteLine("Integer: 50, Integer: " + BinaryConverter.ToBinary(50));
            Console.WriteLine("Integer: 15, Integer: " + BinaryConverter.ToBinary(15));
            Console.WriteLine("Integer: 4, Integer: " + BinaryConverter.ToBinary(4));
            Console.WriteLine("Integer: 51, Integer: " + BinaryConverter.ToBinary(51));
            ArrowMovement.GetIndicator('w');

        }
    }
}
