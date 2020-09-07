using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction
{
    public abstract class AbstractObject : AbstractBehaviour, Interactable
    {
        public abstract string ObjectName { get; set; }
        public abstract InteractMetadata Interact();
    }
}
