using System;

namespace WorkflowEngine
{
    public class Waiting : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Activity: Waiting");
        }
    }
}
