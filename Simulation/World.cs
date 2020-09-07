using AwwareCmds;
using AwwareCmds.Arguments;
using InteractionBetween.Interaction;
using InteractionBetween.Interaction.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public class World : ICMD
    {
        public string Name => "World";

        public string Cmd => "world";

        public string CmdAbbr => "wd";

        public string Desc => "Показывает все миры и что в них происходит";

        public string Syntax => "";

        public List<SubInfo> Subcommands => new List<SubInfo>();

        public void C_Execute(Executer exe, ArgsController args)
        {
            if (args.SubCmds.IsSubcmd(0, "all"))
            {
                Interactor.Logger.Info("Миры:");
                foreach (var world in Interactor.WorldController)
                {
                    Interactor.Logger.Info($"{world.WorldName} | {world.BehaviourID}");
                }
            }
        }

        public void C_Init(Executer exe)
        {

        }
    }
}
