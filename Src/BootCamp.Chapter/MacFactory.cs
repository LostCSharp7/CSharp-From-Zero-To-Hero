using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory
    {
       
        public DesktopComputer Assemble()
        {
            MacComputer MacComputer = new MacComputer();
            MacComputer.GetBody().InstallBody();
            MacComputer.GetMotherboard().installMotherBoard();
            MacComputer.GetCpu().InstallCPU();
            MacComputer.GetGpu().InstallGPU();
            MacComputer.GetHard().installHardisk();
            MacComputer.GetRam().installRam();

            return MacComputer;
            //return new DesktopComputer();
        }
    }
}
