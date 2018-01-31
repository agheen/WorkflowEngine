namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workEngine = new WorkflowEngine();
            var workflow = new Workflow();

            var run = new Running();
            var wait = new Waiting();
            var sit = new Sitting();
            var run2 = new Running();

            workflow.Add(run);
            workflow.Add(wait);
            workflow.Add(sit);
            workflow.Add(run2);

            workEngine.Run(workflow);
        }
    }
}
