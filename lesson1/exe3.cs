using System;

namespace Exercises.lesson1
{
    public static class MemoryAnalyzer
    {

        #region exemple
        public static void MemoryAllocationExperiment()
        {
            // Track initial allocation
            long baselineMemory = GC.GetAllocatedBytesForCurrentThread();
            // TODO: Complete the following experiments
            // 1. Allocate an array of integers
            int[] intArray = new int[10000];
            long afterIntArray = GC.GetAllocatedBytesForCurrentThread();
            // 2. Allocate an array of doubles
            double[] doubleArray = new double[10000];
            long afterDoubleArray = GC.GetAllocatedBytesForCurrentThread();
            // 3. Allocate an array of strings
            string[] stringArray = new string[10000];
            long afterStringArray = GC.GetAllocatedBytesForCurrentThread();
            // Print allocation sizes
            Console.WriteLine($"Baseline Memory: {baselineMemory} bytes");
            Console.WriteLine($"Int Array Allocation: {afterIntArray - baselineMemory} bytes");
            Console.WriteLine($"Double Array Allocation: {afterDoubleArray - afterIntArray} bytes");
            Console.WriteLine($"String Array Allocation: {afterStringArray - afterDoubleArray} bytes");
        }
        #endregion

        public static long CalculateArraySize<T>(int size)
        {
            long initialMemory = GC.GetAllocatedBytesForCurrentThread();

            T[] arr = new T[size];

            long finalMemory = GC.GetAllocatedBytesForCurrentThread();
            return finalMemory - initialMemory;
        }
    }
}
