using System;

namespace BootCamp.Chapter.Computer
{
    public class Cpu
    {
        public virtual void InstallCPU()
        {
            Console.WriteLine("Install CPU");
        }

    }
    public class MSCpu:Cpu
    {
        public override void InstallCPU()
        {
            Console.WriteLine("Install MS CPU");
        }

    }

    public class MacCpu:Cpu
    {
        public override void InstallCPU()
        {
            Console.WriteLine("Install Mac CPU");
        }

    }


}