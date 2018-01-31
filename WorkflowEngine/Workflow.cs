using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
    }

    public class Workflow
    {
        private readonly List<IActivity> _workflow;

        public Workflow()
        {
            _workflow = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _workflow.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _workflow.Remove(activity);
        }

        public IEnumerable<IActivity> GetList()
        {
            return _workflow;
        }

    }
}
