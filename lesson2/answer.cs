using System;
using System.Text;

namespace Exercises.lesson2
{
    internal class answer
    {
        public static void MeasureObjectMemory()
        {
            long beforeMemory = GC.GetAllocatedBytesForCurrentThread();
            PointStruct point = new PointStruct();
            long afterMemory = GC.GetAllocatedBytesForCurrentThread();
            Console.WriteLine($"MeasureObjectMemory: Allocated Memory={afterMemory - beforeMemory}");
        }

        public static void MeasureHeapStringMemory()
        {
            long beforeMemory = GC.GetAllocatedBytesForCurrentThread();
            string str = new string("hello world");
            long afterMemory = GC.GetAllocatedBytesForCurrentThread();
            Console.WriteLine($"MeasureHeapStringMemory: Allocated Memory={afterMemory - beforeMemory}");
        }

        public static string CreateNumberString()
        {
            string result = "";
            for (int i = 1; i <= 100; i++)
            {
                result += i + " ";
            }
            return result;
        }

        public static string CreateNumberStringUsingBuilder()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                result.Append(i);
                result.Append(' ');
            }

            return result.ToString();
        }

        public static void CompareMemoryUsageForStrings()
        {
            long beforeStringMemory = GC.GetAllocatedBytesForCurrentThread();
            string str1 = CreateNumberString();
            Console.WriteLine($"String created by concatenation: {str1}");
            long afterStringMemory = GC.GetAllocatedBytesForCurrentThread();
            Console.WriteLine($"Memory used for string: {afterStringMemory - beforeStringMemory} bytes");

            long beforeStringBuilderMemory = GC.GetAllocatedBytesForCurrentThread();
            string str2 = CreateNumberStringUsingBuilder();
            Console.WriteLine($"String created using StringBuilder: {str2}");
            long afterStringBuilderMemory = GC.GetAllocatedBytesForCurrentThread();
            Console.WriteLine($"Memory used for StringBuilder: {afterStringBuilderMemory - beforeStringBuilderMemory} bytes");
        }

        public static void TestGarbageCollectionGenerations()
        {
            var testObject = new object();

            Console.WriteLine($"Generation of testObject before GC: {GC.GetGeneration(testObject)}");

            GC.Collect(0); // Perform GC for Generation 0
            Console.WriteLine("Garbage Collection for Generation 0 performed.");

            Console.WriteLine($"Generation of testObject after GC: {GC.GetGeneration(testObject)}");
        }

        public static void main()
        {
            Console.WriteLine("Running MeasureObjectMemory...");
            MeasureObjectMemory();

            Console.WriteLine("\nRunning MeasureHeapStringMemory...");
            MeasureHeapStringMemory();

            Console.WriteLine("\nRunning CompareMemoryUsageForStrings...");
            CompareMemoryUsageForStrings();

            Console.WriteLine("\nRunning TestGarbageCollectionGenerations...");
            TestGarbageCollectionGenerations();
        }
    }

    struct PointStruct
    {
        public int X;
        public int Y;
    }
}
