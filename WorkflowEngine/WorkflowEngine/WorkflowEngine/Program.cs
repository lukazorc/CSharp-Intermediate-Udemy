using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.RegisterActivity(new VideoUploadActivity());
            workflow.RegisterActivity(new VideoEncodeActivity());
            var workflowEngine = new WorkflowEngine(workflow);
            workflowEngine.Run();

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
        }
    }
}
