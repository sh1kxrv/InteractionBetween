using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction
{
    public struct InteractMetadata
    {
        public InteractMetadata(AbstractEntity self, AbstractEntity target, object interactdata)
        {
            Self = self;
            Target = target;
            InteractData = interactdata;
        }
        public AbstractEntity Self;
        public AbstractEntity Target;
        public object InteractData;
    }
}
