using System;

namespace WorkflowEngine
{
    public class VideoEncodeActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Encoding video...");
        }
    }
}
