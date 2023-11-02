namespace SortingAlgorithms
{
    public static class DialogueWithTheUser
    {
        public static void SortinSelection(double[] array, string selection)
        {
            switch (selection)
            {
                case "1":
                    Console.WriteLine("Array after sorting \"BubbleSort\": ");
                    Processor.BubbleSort(array); // Пузырьковая сортировка.
                    break;
                case "2":
                    Console.WriteLine("Array after sorting \"InsertionSort\": ");
                    Processor.InsertionSort(array); // Сортировка вставками.
                    break;
                default:
                    Console.WriteLine("You entered an incorrect value");
                    break;
            }
        }
    }
}