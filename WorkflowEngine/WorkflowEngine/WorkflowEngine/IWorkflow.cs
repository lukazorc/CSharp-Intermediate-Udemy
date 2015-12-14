using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        IEnumerable<IActivity> Acitivites { get; }
        void RegisterActivity(IActivity activity);
    }
}
