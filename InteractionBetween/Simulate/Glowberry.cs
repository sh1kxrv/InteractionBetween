using InteractionBetween.Interaction;
using InteractionBetween.Interaction.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Simulate
{
    public class Glowberry : AbstractWorld
    {
        public override string WorldName => this.GetType().Name;

        public override void Initialize()
        {
            Interactor.Logger.Debug("Мир инициализирован!");
            //Bin bin = new Bin();
            //bin.ObjectName = "КОРЗИНА";
            //AddObject(bin);
        }

        public override void Update()
        {
            //Interactor.Logger.Debug("Мир обновляется!");
        }
    }
}
