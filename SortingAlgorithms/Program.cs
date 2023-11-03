using SortingAlgorithms;

double[] arrayNum = new double[UserInteractive.GettingLengthArray()]; // Создаём иассив с заданной длинной.

Processor.FillArray(arrayNum); // Заполняем массив 

UserInteractive.SortinSelection(arrayNum); // Сортировка выбранная пользователем.

Processor.ArrayOutput(arrayNum); // Вывод отсортированного иассива.