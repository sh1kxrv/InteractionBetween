using InteractionBetween.Interaction;
using InteractionBetween.Interaction.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Simulate
{
    public class Bin : AbstractObject
    {
        private string oName = "Bin";
        public override string ObjectName { get => oName; set { oName = value; } }

        public override void Initialize()
        {
            Interactor.Logger.Debug($"{ObjectName} инициализирован!");
        }

        public override InteractMetadata Interact()
        {
            return new InteractMetadata();
        }

        public override void Update()
        {

        }
    }
}
