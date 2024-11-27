using System;

namespace Exercises.lesson1
{
    public class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int W { get; set; }
    }

    public struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        //public int Z { get; set; }
        //public int W { get; set; }

    }
    public static class PointOperations
    {


        public static void MovePoint(ClassPoint point, int dx, int dy)
        {
            point.X += dx;
            point.Y += dy;
        }

        public static void MovePoint(StructPoint point, int dx, int dy)
        {
            point.X += dx;
            point.Y += dy;
        }

        public static void MovePointByRef(ref StructPoint point, int dx, int dy)
        {
            point.X += dx;
            point.Y += dy;
        }

    }
}
