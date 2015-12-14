using System.Diagnostics;


namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack1 = new Stack();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            Debug.WriteLine(stack1.Pop());
            Debug.WriteLine(stack1.Pop());
            Debug.WriteLine(stack1.Pop());
            Debug.WriteLine(stack1.Pop());

            stack1.Push(4);
            stack1.Push(5);
            stack1.Push(6);

            stack1.Clear();
            Debug.WriteLine(stack1.Pop());


        }
    }
}
