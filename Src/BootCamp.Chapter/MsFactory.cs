using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory
    {
        public DesktopComputer Assemble()
        {
            MSComputer MsComputer = new MSComputer();
            MsComputer.GetBody().InstallBody();
            MsComputer.GetMotherboard().installMotherBoard();
            MsComputer.GetCpu().InstallCPU();
            MsComputer.GetGpu().InstallGPU();
            MsComputer.GetHard().installHardisk();
            MsComputer.GetRam().installRam();

            return MsComputer;
            //return new DesktopComputer();
        }
    }
}
