

namespace Exercises.lesson1
{
    public static class RecursionExperiments
    {
        public static void StackOverflowExperiment()
        {
            static int RecursiveMethod(int depth, int localArraySize)
            {
                // TODO: Implement a recursive method that:
                // 1. Creates a local byte array of specified size
                byte[] localArray = new byte[localArraySize];
                int num = 10;
                string str= "Hi";
                // 2. Prints current recursion depth
                Console.WriteLine($"Current depth: {depth}");
                // 3. Recursively calls itself, incrementing depth
                try
                {
                    return RecursiveMethod(depth + 1, localArraySize);
                }
                catch (StackOverflowException)
                {
                    return depth;
                }
            }
            // Experiment with different local array sizes
            int[] arraySizes = { 10000 };
            foreach (int size in arraySizes)
            {
                Console.WriteLine($"\nExperiment with local array size: {size} bytes");
                try
                {
                    int maxDepth = RecursiveMethod(0, size);
                    Console.WriteLine($"Maximum recursion depth: {maxDepth}");
                }
                catch (StackOverflowException)
                {
                    Console.WriteLine("Stack overflow occurred!");
                }
            }
        }
    }
}
