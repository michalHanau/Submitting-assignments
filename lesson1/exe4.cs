using System;


namespace Exercises.lesson1
{
    internal class exe4
    {

        public static void ExpandArray(ref int[] array) 
        {
                int[] oldArray = array;
                array = new int[oldArray.Length * 2];
                for (int i = 0; i < oldArray.Length; i++)
                {
                    array[i] = oldArray[i];
                    array[i + oldArray.Length] = oldArray[i];
                } 
        }
    }
}
