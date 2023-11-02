using System;

namespace BootCamp.Chapter.Computer
{
    public class Ram
    {
        public virtual void installRam()
        {
            Console.WriteLine("Install Ram");
        }

    }

    public class MSRam : Ram
    {
        public override void installRam()
        {
            Console.WriteLine("Install MS Ram");
        }

    }
    public class MacRam : Ram
    {
        public override void installRam()
        {
            Console.WriteLine("Install Mac Ram");
        }

    }
}