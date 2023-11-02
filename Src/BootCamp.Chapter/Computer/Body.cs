using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer
{
    public class Body
    {
        public virtual void InstallBody()
        {
            Console.WriteLine("Install Body");
        }
    }

    public class MSBody : Body
    {
        public override void InstallBody() 
        {
            Console.WriteLine("Install MS Body");
        }
    }

    public class MacBody : Body
    {
        public override void InstallBody()
        {
            Console.WriteLine("Install Mac Body");
        }
    }
}
