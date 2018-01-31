using System;

namespace WorkflowEngine
{
    class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            Console.WriteLine("Engine is Executing Activities");
            foreach ( var acts in workflow.GetList())
            {
                acts.Execute();
            }
        }

    }
}
