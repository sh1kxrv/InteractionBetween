using InteractionBetween.Interaction.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction
{
    public abstract class AbstractBehaviour : IDisposable
    {
        public AbstractBehaviour()
        {
            BehaviourID = Guid.NewGuid();
        }
        public Guid BehaviourID { get; }
        public bool Terminate { get; set; }
        public abstract void Update();
        public abstract void Initialize();

        public virtual void Dispose()
        {
            Terminate = true;
        }
        public AbstractWorld Belongs { get; set; } = null;
    }
}
