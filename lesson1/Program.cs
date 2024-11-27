using Exercises.lesson1;
using System;

namespace Exercises.Lesson1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var classPoint = new ClassPoint { X = 5, Y = 5 };
            PointOperations.MovePoint(classPoint, 2, 3);
            Console.WriteLine($"Class Point after move: ({classPoint.X}, {classPoint.Y})");

            var structPoint = new StructPoint { X = 5, Y = 5 };
            PointOperations.MovePoint(structPoint, 2, 3);
            Console.WriteLine($"Struct Point after move: ({structPoint.X}, {structPoint.Y})");

            PointOperations.MovePointByRef(ref structPoint, 2, 3);
            Console.WriteLine($"After move by ref: ({structPoint.X}, {structPoint.Y})");

            RecursionExperiments.StackOverflowExperiment();
        }
    }
}
