using System;

namespace WorkflowEngine
{
    public class Running : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Activity: Running");
        }
    }
}
