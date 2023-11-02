/* Задание: заполни массив рандомными вещественными числами, кол-во чисел в массиве задает пользователь.
 * Примени алгоритм сортировки массива вставками, пузырьком и быструю сортировку,
 * замерь скрость исполнения каждой сортировки по отдельности. 
 * Предоставь выбор пользователю какую сортировку он выберет. 
 * На выводе выводить отсортированный массив с временем выполнения сортировки*/

using SortingAlgorithms;

Console.WriteLine("Enter array length: ");

int arrayLength = Int32.Parse(Console.ReadLine()); // Пользователь вводит длину массива.

double[] arrayNum = new double[arrayLength]; // Создаём иассив с заданной длинной.

Processor.FillArray(arrayLength, arrayNum); // Заполняем массив 

Console.WriteLine("Select the option for sorting the array:\n1.\"BubbleSort\"\n2.\"InsertionSort\"");

string selection = Console.ReadLine(); // Пользователь выбирает метод сортировки.

DialogueWithTheUser.SortinSelection(arrayNum, selection); // Сортировка выбранная пользователем.

Processor.ArrayOutput(arrayNum); // Вывод отсортированного иассива.