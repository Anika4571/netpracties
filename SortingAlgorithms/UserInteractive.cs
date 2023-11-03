namespace SortingAlgorithms
{
    public static class UserInteractive
    {
        public static int GettingLengthArray()
        {
            int arrayLength = 0;
            Console.WriteLine("Enter array length: ");
            return arrayLength = int.Parse(Console.ReadLine()); // Пользователь вводит длину массива.
        }
        public static void SortinSelection(double[] array)
        {
            Console.WriteLine("Select the option for sorting the array:\n1.\"BubbleSort\"\n2.\"InsertionSort\"");
            string selection = Console.ReadLine(); // Пользователь выбирает метод сортировки.
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Array after sorting \"BubbleSort\": ");
                    ICustomSort bubbleSort = new BubbleSort();
                    bubbleSort.SortArray(array); // Пузырьковая сортировка.
                    break;
                case "2":
                    Console.WriteLine("Array after sorting \"InsertionSort\": ");
                    ICustomSort insertionSort = new InsertionSort();
                    insertionSort.SortArray(array); // Сортировка вставками.
                    break;
                default:
                    Console.WriteLine("You entered an incorrect value");
                    break;
            }
        }
    }
}