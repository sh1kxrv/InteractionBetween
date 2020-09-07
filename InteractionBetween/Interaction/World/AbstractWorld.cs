using InteractionBetween.Interaction.Behaviour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction.World
{
    public abstract class AbstractWorld : AbstractBehaviour
    {
        public AbstractWorld()
        {
            EntitiesInTheWorld = new List<AbstractEntity>();
            ObjectsInTheWorld = new List<AbstractObject>();
            SomethingInTheWorld = new List<AbstractBehaviour>();
        }
        public abstract string WorldName { get; }
        public List<AbstractEntity> EntitiesInTheWorld { get; private set; }
        public List<AbstractObject> ObjectsInTheWorld { get; private set; }
        public List<AbstractBehaviour> SomethingInTheWorld { get; private set; }
        public void AddEntity(AbstractEntity beh)
        {
            beh.Belongs = this;
            beh.Initialize();
            lock(EntitiesInTheWorld)
                EntitiesInTheWorld.Add(beh);
            BehaviourController.StartUpdateBehaviour(beh);
        }
        public void RemoveEntity(AbstractEntity entity)
        {
            AbstractEntity ent = EntitiesInTheWorld.Find(a => a.BehaviourID == entity.BehaviourID);
            lock (EntitiesInTheWorld)
                EntitiesInTheWorld.Remove(ent);
            ent.Dispose();
        }
        public void AddObject(AbstractObject beh)
        {
            beh.Belongs = this;
            beh.Initialize();
            lock (ObjectsInTheWorld)
                ObjectsInTheWorld.Add(beh);
            BehaviourController.StartUpdateBehaviour(beh);
        }
        public void RemoveObject(AbstractObject @object)
        {
            AbstractObject obj = ObjectsInTheWorld.Find(a => a.BehaviourID == @object.BehaviourID);
            lock(ObjectsInTheWorld)
                ObjectsInTheWorld.Remove(obj);
            obj.Dispose();
        }
        public void AddBehaviour(AbstractBehaviour beh)
        {
            beh.Belongs = this;
            beh.Initialize();
            lock(SomethingInTheWorld)
                SomethingInTheWorld.Add(beh);
            BehaviourController.StartUpdateBehaviour(beh);
        }

        public void RemoveBehaviour(AbstractBehaviour behav)
        {
            AbstractBehaviour beh = SomethingInTheWorld.Find(a => a.BehaviourID == behav.BehaviourID);
            lock (SomethingInTheWorld)
                SomethingInTheWorld.Remove(beh);
            beh.Dispose();
        }

        public override void Dispose()
        {
            EntitiesInTheWorld.ForEach((a) => a.Dispose());
            ObjectsInTheWorld.ForEach((a) => a.Dispose());
            SomethingInTheWorld.ForEach((a) => a.Dispose());
            EntitiesInTheWorld = null;
            SomethingInTheWorld = null;
            ObjectsInTheWorld = null;
            base.Dispose();
        }
    }
}
