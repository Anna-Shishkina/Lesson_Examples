// Найти позицию минимального элемента в неотсортированной части массива
// Произвести обмен этого значения со значением первой неосортированной позиции
// Повторять пока есть не отсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)                      // поиск максимального элемента
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];                                     //swap (свап) - смена
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);