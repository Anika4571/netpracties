namespace SortingAlgorithms
{
    public class InsertionSort : ICustomSort
    {
        // Метод сортировка вставками.
        public static void SortArray(double[] array)
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
    }
}