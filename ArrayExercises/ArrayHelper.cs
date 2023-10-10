using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    public static class ArrayHelper
    {
        public static int Min(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(
                    "Array must have at least 1 element",
                    nameof(array));
            }

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Sorts an array using the selection sort algorithm.
        /// </summary>
        /// <param name="array">The original unsorted array.</param>
        /// <param name="sortOrder">The sort order.</param>
        /// <returns>The sorted array.</returns>
        /// <exception cref="ArgumentNullException">When array is null.</exception>
        public static int[] SelectionSort(int[] array, SortOrder sortOrder)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                return new int[0];
            }

            //  0   1   2   3   4
            // ------------------
            // 11, 25, 12, 22, 64

            // 1) Index = 0;
            // Pe pozitia Index (0) trebuie sa aduc minimul (0 -> 4)
            // gasesc: 11 (index = 0)
            // sorted[0] = 11;

            // 2) Index = 1;
            // Pe pozitia Index (1) trebuie sa aduc minimul (1 -> 4)
            // gasesc: 12 (index 2); swap (array[1], array[2])
            // temp = array[1];
            // array[1] = array[2]
            // array[2] = temp
            // 11, 12, 25, 22, 64
            // sorted[1] = 12

            //  0   1   2   3   4
            // ------------------
            // 11, 12, 25, 22, 64

            // 3) Index = 2;
            // Pe pozitia Index (2) trebuie sa aduc minimul (2 -> 4)


            for (int index = 0; index < array.Length - 1; index++)
            {
                int candidateMin = array[index];

                // parcurg subsirul de la elementul urmator pana la capat ca sa gasesc minimul
                for (int subArrayIndex = index + 1; subArrayIndex < array.Length; subArrayIndex++)
                {
                    if (array[subArrayIndex] < candidateMin)
                    {
                        // swap array[subArrayIndex] => array[index]
                        int temp = array[index];
                        array[index] = array[subArrayIndex];
                        array[subArrayIndex] = temp;

                        // candidatul minim este totdeauna pe pozitia index
                        candidateMin = array[index];
                    }
                }
            }

            return array;

        }
    }
}
