using AwwareCmds;
using InteractionBetween;
using InteractionBetween.Interaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Simulation
{
    class Program
    {
        public static Interactor Interactor;
        static Executer exec;
        static void Main(string[] args)
        {
            exec = new Executer();
            exec.Initialize(true, "");
            exec.AttachModule(Assembly.GetExecutingAssembly());
            Interactor = new Interactor();
            Interactor.Logger = new ConsoleLogger();
            Interactor.Simulate();
            for (; ; )
            {
                exec.CommandHandler(Console.ReadLine());
            }
            //Task.Delay(-1).Wait();
        }

    }
}
