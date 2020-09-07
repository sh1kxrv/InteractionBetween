using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction.AI
{
    public interface AI
    {
        string AIName { get; set; }
        void InteractWithObject(AbstractObject obj);
        void InteractWithEntity(AbstractEntity entity);
    }
}
