using Exercises.lesson1;
using Exercises.lesson2;
using System;

namespace Exercises.Lesson1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            answer.main();
            //exe1
            //var classPoint = new ClassPoint { X = 5, Y = 5 };
            //PointOperations.MovePoint(classPoint, 2, 3);
            //Console.WriteLine($"Class Point after move: ({classPoint.X}, {classPoint.Y})");

            //var structPoint = new StructPoint { X = 5, Y = 5 };
            //PointOperations.MovePoint(structPoint, 2, 3);
            //Console.WriteLine($"Struct Point after move: ({structPoint.X}, {structPoint.Y})");

            //PointOperations.MovePointByRef(ref structPoint, 2, 3);
            //Console.WriteLine($"After move by ref: ({structPoint.X}, {structPoint.Y})");

            ////exe2
            //RecursionExperiments.StackOverflowExperiment();

            //exe3
            long intArraySize = MemoryAnalyzer.CalculateArraySize<int>(0);
            Console.WriteLine($"Int Array Allocation: {intArraySize} bytes");


            long doubleArraySize = MemoryAnalyzer.CalculateArraySize<double>(0);
            Console.WriteLine($"Double Array Allocation: {doubleArraySize} bytes");

            long stringArraySize = MemoryAnalyzer.CalculateArraySize<string>(0);
            Console.WriteLine($"String Array Allocation: {stringArraySize} bytes");


            long classPointArraySize = MemoryAnalyzer.CalculateArraySize<ClassPoint>(1);
            Console.WriteLine($"ClassPoint Array Allocation: {classPointArraySize} bytes");

            long structPointArraySize = MemoryAnalyzer.CalculateArraySize<StructPoint>(1);
            Console.WriteLine($"StructPoint Array Allocation: {structPointArraySize} bytes");

            //exe4
            int[] a = { 1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            exe4.ExpandArray(ref a);
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
