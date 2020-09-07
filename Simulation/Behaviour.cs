using AwwareCmds;
using AwwareCmds.Arguments;
using InteractionBetween.Interaction;
using InteractionBetween.Interaction.World;
using InteractionBetween.Simulate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    public class Behaviour : ICMD
    {
        private List<AbstractObject> ObjsToCreate = new List<AbstractObject>()
        {
            new Bin()
        };
        public string Name => "Behaviour";

        public string Cmd => "behaviour";

        public string CmdAbbr => "beh";

        public string Desc => "Создает любой Behaviour объект и прочее";

        public string Syntax => "";

        public List<SubInfo> Subcommands => new List<SubInfo>();
        private AbstractWorld WrldSelected = null;

        public void C_Execute(Executer exe, ArgsController args)
        {
            //выбор мира
            if (args.SubCmds.IsSubcmd(0, "wselect"))
            {
                string wrldName = args.StrArgs[0];
                if(WrldSelected != null && wrldName == WrldSelected.WorldName)
                {
                    Interactor.Logger.Error($"Мир {wrldName} уже выбран!");
                    return;
                }
                if (Interactor.WorldController.Any((a) => a.WorldName == wrldName))
                {
                    WrldSelected = Interactor.WorldController.First((a) => a.WorldName == wrldName);
                    Interactor.Logger.Success($"Мир {WrldSelected.WorldName} выбран! | {WrldSelected.BehaviourID}");
                }
                else
                    Interactor.Logger.Error($"Мир {wrldName} не найден!");
            }
            else if (args.SubCmds.IsSubcmd(0, "obj"))
            {
                if (WrldSelected is null)
                {
                    Interactor.Logger.Error("Мир не выбран!");
                    return;
                }
                if (args.SubCmds.IsSubcmd(1, "add"))
                {
                    string whatIs = args.StrArgs[0];
                    if (ObjsToCreate.Any(a => a.ObjectName == whatIs))
                    {
                        WrldSelected.AddObject(ObjsToCreate.Find(a => a.ObjectName == whatIs));
                        Interactor.Logger.Success($"Объект {whatIs} добавлен в мир!");
                    }
                    else
                        Interactor.Logger.Error($"Объект {whatIs} не найден!");
                }
                else if(args.SubCmds.IsSubcmd(1, "list"))
                {
                    Interactor.Logger.Info($"Объекты в мире ({WrldSelected.ObjectsInTheWorld.Count}): ");
                    foreach (var obj in WrldSelected.ObjectsInTheWorld)
                        Interactor.Logger.Info($"{obj.ObjectName} | {obj.BehaviourID}");
                }
            }
        }

        public void C_Init(Executer exe)
        {

        }
    }
}
