namespace ArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ConsoleHelper.ReadNumber("The size of the array=", 3, 0);
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                int element = ConsoleHelper.ReadNumber($"element[{i}]=", 3, 0);
                array[i] = element;
            }

            ConsoleHelper.PrintArray("Array=", array);

            int minValue = ArrayHelper.Min(array);
            Console.WriteLine($"Min={minValue}");

            int[] sortedArray = ArrayHelper.SelectionSort(array, "asc");
            ConsoleHelper.PrintArray("Sorted Array=", sortedArray);
            ConsoleHelper.PrintArray("Array=", array);

        }
    }
}