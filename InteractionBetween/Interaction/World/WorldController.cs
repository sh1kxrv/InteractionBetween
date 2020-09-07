using System;
using System.Collections;
using System.Collections.Generic;

namespace InteractionBetween.Interaction.World
{
    public class WorldController: IEnumerable<AbstractWorld>
    {
        protected List<AbstractWorld> Worlds;
        public AbstractWorld this[int index]
        {
            get
            {
                if (index >= Worlds.Count || index < 0)
                    throw new IndexOutOfRangeException();
                return Worlds[index];
            }
        }
        public WorldController()
        {
            Worlds = new List<AbstractWorld>();
        }
        public AbstractWorld ExecuteWorld(AbstractWorld world)
        {
            if(Worlds.Contains(world))
                throw new Exceptions.WorldAlreadyExecutedException($"Мир {world.WorldName} уже запущен!");
            lock(Worlds)
                Worlds.Add(world);
            world.Initialize();
            Behaviour.BehaviourController.StartUpdateBehaviour(world);
            Interactor.Logger.Debug($"Мир {world.WorldName} был запущен!");
            return world;
        }
        //public void ExecuteWorldCopy(AbstractWorld world)
        //{
        //    world.Initialize();
        //    Behaviour.BehaviourController.StartUpdateBehaviour(world);
        //    Interactor.Logger.Debug($"Мир {world.WorldName} был запущен как копия.");
        //}
        public void DisposeWorld(AbstractWorld world)
        {
            if (Worlds.Contains(world))
            {
                int index = Worlds.FindIndex(w => w.BehaviourID == world.BehaviourID);
                Worlds[index].Dispose();
                lock (Worlds)
                    Worlds.RemoveAt(index);
                Interactor.Logger.Debug($"Мир {world.WorldName} был удален!");
            }
            else
                Interactor.Logger.Error($"Мир {world.WorldName} не найден!");
        }

        public IEnumerator<AbstractWorld> GetEnumerator()
        {
            return Worlds.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
