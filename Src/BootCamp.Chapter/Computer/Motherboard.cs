using System;

namespace BootCamp.Chapter.Computer
{
    public class Motherboard
    {
        public virtual void installMotherBoard()
        {
            Console.WriteLine("Install MotherBoard");
        }


    }

    public class MSMotherboard : Motherboard
    {
        public override void installMotherBoard()
        {
            Console.WriteLine("Install MS MotherBoard");
        }

    }

    public class MacMotherboard : Motherboard
    {
        public override void installMotherBoard()
        {
            Console.WriteLine("Install Mac MotherBoard");
        }

    }
}