using System;

namespace BootCamp.Chapter.Computer
{
    public class HardDisk
    {
        public virtual void installHardisk()
        {
            Console.WriteLine("Install HardDisk");
        }

    }

    public class MSHardDisk : HardDisk
    {
        public override void installHardisk()
        {
            Console.WriteLine("Install MS HardDisk");
        }

    }

    public class MacHardDisk : HardDisk
    {
        public override void installHardisk()
        {
            Console.WriteLine("Install Mac HardDisk");
        }

    }

}