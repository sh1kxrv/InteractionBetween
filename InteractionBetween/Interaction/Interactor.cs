using InteractionBetween.Interaction.World;
using InteractionBetween.Simulate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction
{
    public class Interactor
    {
        public static ILogger Logger;
        public static WorldController WorldController = new WorldController();
        public void Simulate()
        {
            Glowberry glow = WorldController.ExecuteWorld(new Glowberry()) as Glowberry;
            glow.AddObject(new Bin());
        }
    }
}
