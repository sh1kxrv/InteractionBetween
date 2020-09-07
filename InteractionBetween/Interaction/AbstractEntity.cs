using InteractionBetween.Interaction.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction
{
    public abstract class AbstractEntity : AbstractBehaviour, Interactable
    {
        public abstract string EntityName { get; }
        public abstract InteractMetadata Interact();
    }
}
