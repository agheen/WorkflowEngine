using System;

namespace WorkflowEngine
{
    public class Sitting : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Activity: Sitting");
        }
    }
}
