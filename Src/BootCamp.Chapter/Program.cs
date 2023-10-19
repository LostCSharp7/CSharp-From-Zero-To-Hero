using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = CaesarCipher.Encrypt("xyz", 1);
            Console.WriteLine(str);
            Console.WriteLine(CaesarCipher.Decrypt(str, 1));
        }
    }
}
