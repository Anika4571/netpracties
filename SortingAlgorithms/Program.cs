/* Задание: заполни массив рандомными вещественными числами, кол-во чисел в массиве задает пользователь.
 * Примени алгоритм сортировки массива вставками, пузырьком и быструю сортировку,
 * замерь скрость исполнения каждой сортировки по отдельности. 
 * Предоставь выбор пользователю какую сортировку он выберет. 
 * На выводе выводить отсортированный массив с временем выполнения сортировки*/

using System.Diagnostics;

Random rnd = new Random(); // Объект Random

Console.WriteLine("Enter array length: ");

int arrayLength = int.Parse(Console.ReadLine()); // Пользователь вводит длину массива.

int[] arrayNum = new int[arrayLength]; // Создаём иассив с заданной длинной.

// Заполняеи массив рандомными числами.
for (int i = 0; i < arrayLength; i++) 
{
    arrayNum[i] = rnd.Next(0, 100); 
}

Console.Write("Array before sorting: ");
ArrayOutput(arrayNum); // Выводим на консоль массив до сортировки.

Console.WriteLine("Select the option for sorting the array:\n1.\"BubbleSort\"\n2.\"InsertionSort\"");

string selection = Console.ReadLine(); // Пользователь выбирает метод сортировки.

Stopwatch stopwatch = new Stopwatch(); // Объект Stopwatch.

switch (selection)
{
    case "1":
        Console.Write("Array after sorting \"BubbleSort\": ");
        stopwatch.Start();
        BubbleSort(arrayNum); // Пузырьковая сортировка.
        stopwatch.Stop();
        break;
    case "2":
        Console.Write("Array after sorting \"InsertionSort\": ");
        stopwatch.Start();
        InsertionSort(arrayNum); // Сортировка вставками.
        stopwatch.Stop();
        break;
    default:
        Console.WriteLine("You entered an incorrect value"); 
        break;
}

ArrayOutput(arrayNum); // Выводим на консоль массив после сортировки.

long elapsedTicks = stopwatch.ElapsedTicks;

Console.WriteLine($"lead time: {elapsedTicks} ticks");

// Метод вывода массива на консоль.
void ArrayOutput(int[] inArray)
{
    foreach (int i in arrayNum)
    {
        Console.Write($"{i};");
    }
    Console.WriteLine();
}

// Метод пузырьковой сортировки.
void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}

// Метод сортировка вставками.
void InsertionSort(int[] array)
{
    void Swap(int[] array, int i, int j) // метод меняющий два элемента массива местами.
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    int x;
    int j;

    for (int i = 1; i < array.Length; i++)
    {
        x = array[i];
        j = i;
        while (j > 0 && array[j - 1] > x)
        {
            Swap(array, j, j - 1);
            j -= 1;
        }
        array[j] = x;
    }
}

//// Метод быстрой сортировки.
//void QuickSort(int[] array)
//{

//}