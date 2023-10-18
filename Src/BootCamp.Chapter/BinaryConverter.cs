using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            long Number = 0;
            if(string.IsNullOrEmpty(binary))
            {
                return 0;
            }
            if(!binary.All(x=>(x == '0' || x == '1')))
            {
                throw new InvalidBinaryNumberException(binary);
            }
            int j = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Number += long.Parse(binary[i].ToString()) * (long)Math.Pow(2, j);
                j++;
            }
            return Number;
        }

        public static string RecursiveBinary(long number)
        {
            if(number == 0)
                return "";

           var strBin = string.Concat(RecursiveBinary(number / 2));
            return strBin = string.Concat(strBin, number % 2);
        }

        public static string ToBinary(long number)
        {
            if(number == 0)
            {
                return "0";
            }
            if(number < 0)
            {
                return "";
            }
            return RecursiveBinary(number);
        }
    }
}
