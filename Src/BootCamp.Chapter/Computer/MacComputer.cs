using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public class MacComputer:DesktopComputer
    {
        private MacBody _MacBody;
        public override Body GetBody()
        {
            _MacBody = new MacBody();
            return _MacBody;
        }

        private MacCpu _MacCpu;

        public override Cpu GetCpu()
        {
            _MacCpu = new MacCpu();
            return _MacCpu;
        }

        private MacGpu _MacGpu;
        public override Gpu GetGpu()
        {
            _MacGpu = new MacGpu();
            return _MacGpu;
        }

        private MacRam _MacRam;
        public override Ram GetRam()
        {
            _MacRam = new MacRam();
            return _MacRam;
        }

        private MacMotherboard _MacMotherboard;
        public override Motherboard GetMotherboard()
        {
            _MacMotherboard = new MacMotherboard();
            return _MacMotherboard;
        }

        private MacHardDisk _MacHard;
        public override HardDisk GetHard()
        {
            _MacHard = new MacHardDisk();
            return _MacHard;
        }
    }
}
