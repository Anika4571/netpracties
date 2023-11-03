namespace SortingAlgorithms
{
    public static class Processor
    {
        // Метод заполнеия массив рандомными числами.
        public static void FillArray(double[] array)
        {
            Random rnd = new Random(); // Объект Random

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 1000000);
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
    }
}