using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public  class MSComputer : DesktopComputer
    {
        private MSBody _MsBody;
        public override Body GetBody()
        {
            _MsBody = new MSBody();
            return _MsBody;
        }

        private MSCpu _MsCpu;

        public override Cpu GetCpu()
        {
            _MsCpu = new MSCpu();
            return _MsCpu;
        }

        private MSGpu _MsGpu;
        public override Gpu GetGpu()
        {
            _MsGpu = new MSGpu();
            return _MsGpu;
        }

        private MSRam _MsRam;
        public override Ram GetRam() 
        {
            _MsRam = new MSRam();
            return _MsRam;
        }

        private MSMotherboard _MsMotherboard;
        public override Motherboard GetMotherboard()
        {
            _MsMotherboard = new MSMotherboard();
            return _MsMotherboard;
        }

        private MSHardDisk _MsHard;
        public override HardDisk GetHard()
        {
            _MsHard = new MSHardDisk();
            return _MsHard;
        }
    }
}
