using System;

namespace BootCamp.Chapter.Computer
{
    public class Gpu
    {
        public virtual void InstallGPU()
        {
            Console.WriteLine("Install GPU");
        }
    }
    public class MSGpu : Gpu
    {
        public override void InstallGPU()
        {
            Console.WriteLine("Install MS GPU");
        }

    }

    public class MacGpu : Gpu
    {
        public override void InstallGPU()
        {
            Console.WriteLine("Install Mac GPU");
        }

    }
}