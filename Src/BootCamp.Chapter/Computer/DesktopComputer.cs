using System.ComponentModel;

namespace BootCamp.Chapter.Computer
{
    public abstract class DesktopComputer
    {
        //private Body _body;
        //public  Body GetBody();
        //{
        //    return _body;
        //}

        //private Ram _ram;
        //public Ram GetRam()
        //{
        //    return _ram;
        //}

        //private Cpu _cpu;
        //public Cpu GetCpu()
        //{
        //    return _cpu;

        //}
        //private Gpu _gpu;
        //public Gpu GetGpu()
        //{
        //    return _gpu;
        //}

        //private HardDisk _hard;
        //public HardDisk GetHard()
        //{
        //    return _hard;
        //}

        //private Motherboard _motherboard;
        //public Motherboard GetMotherboard()
        //{
        //    return _motherboard;
        //}

        public abstract Body GetBody();
        public abstract Ram GetRam();
        public abstract Cpu GetCpu();

        public abstract Gpu GetGpu();
        public abstract HardDisk GetHard();
        public abstract Motherboard GetMotherboard();


    }
}
