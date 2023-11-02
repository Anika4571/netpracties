namespace SortingAlgorithms
{
    public static class Processor
    {
        // Метод заполнеия массив рандомными числами.
        public static void FillArray(int arrayLength, double[] array)
        {
            Random rnd = new Random(); // Объект Random

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rnd.NextDouble();
            }
        }

        // Метод вывода массива на консоль.
        public static void ArrayOutput(double[] array)
        {
            foreach (double elementArray in array)
            {
                Console.Write($"{elementArray};");
            }
            Console.WriteLine();
        }

        // Метод пузырьковой сортировки.
        public static void BubbleSort(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Метод сортировка вставками.
        public static void InsertionSort(double[] array)
        {
            double currentElement;
            int index;

            for (int i = 1; i < array.Length; i++)
            {
                currentElement = array[i];
                index = i;
                while (index > 0 && array[index - 1] > currentElement)
                {
                    Swap(array, index, index - 1);
                    index -= 1;
                }
                array[index] = currentElement;
            }
        }

        // метод меняющий два элемента массива местами.
        static void Swap(double[] array, int indexOne, int jindexTwo) 
        {
            double temp = array[indexOne];
            array[indexOne] = array[jindexTwo];
            array[jindexTwo] = temp;
        }

        //// Метод быстрой сортировки.
        //void QuickSort(int[] array)
        //{

        //}
    }
}