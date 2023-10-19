using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public static class CaesarCipher
    {
        public static string Encrypt(string message, byte shift)
        {
            if(message == null)
            {
                return null;
            }
            if(message.Length == 0) 
            {
                return "";
            }
            var stringbuilder = new StringBuilder();
            foreach(var c in message) 
            {
                int i = c + shift;
                if(i > 255)
                {
                    i -=255;
                }
                stringbuilder.Append((char)(i));
            }
            return stringbuilder.ToString();
        }

        public static string Decrypt(string message, byte shift)
        {
            if (message == null)
            {
                return null;
            }
            if (message.Length == 0)
            {
                return "";
            }

            var stringbuilder = new StringBuilder();
            foreach (var c in message)
            {
                int i = c - shift;
                if (i < 0)
                {
                    i += 255;
                }
                stringbuilder.Append((char)(i));
            }
            return stringbuilder.ToString();   
        }
    }
}
