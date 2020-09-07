using AwwareCmds;
using AwwareCmds.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public class IModule : IModuleInfo
    {
        public ModuleKind Kind => ModuleKind.System;

        public string ModuleName => "Simulation";

        public string Version => "1.0.0.0";

        public string Author => "Awware";

        public void ModuleDeinitialize(Executer exec)
        {
            
        }

        public void ModuleInitialize(Executer exec)
        {
            
        }
    }
}
