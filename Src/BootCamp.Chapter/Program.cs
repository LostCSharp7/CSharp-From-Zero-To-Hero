using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var msFact = new MsFactory();
            msFact.Assemble();

            var MacFact = new MacFactory();
            MacFact.Assemble();
        }
    }
}
