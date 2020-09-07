using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InteractionBetween.Interaction.Behaviour
{
    class BehaviourController
    {
        public static Dictionary<AbstractBehaviour, Thread> BehaviourThreads = new Dictionary<AbstractBehaviour, Thread>();
        public static void StartUpdateBehaviour(AbstractBehaviour beh)
        {
            Thread thr = new Thread(() =>
            {
                while(!beh.Terminate)
                {
                    beh.Update();
                    Thread.Sleep(50);
                }
            });
            lock(BehaviourThreads)
                BehaviourThreads.Add(beh, thr);
            thr.Start();
        }
    }
}
