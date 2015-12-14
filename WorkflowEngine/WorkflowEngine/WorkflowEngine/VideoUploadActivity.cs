using System;

namespace WorkflowEngine
{
    public class VideoUploadActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video...");
        }
    }
}
