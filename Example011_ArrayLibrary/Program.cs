// Создай массив с 10 элементами и выведи на экран его значения от 1 до 10

void FillArray(int[] collection) //заполни массив
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //напиши массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;   //-1 если нет какого-то значения в массиве. 
                         //Можно поставить "0", но тогда значение, которого нет в массиве программа определит как "0" и можно спутать что значение в индексе 0
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //new int[10] - создай новый массив с 10ю элементами, т.е. поулчится массив с пустыми/нудевыми элементами 

FillArray(array);
// принудительно добавим еще четверок:
array[4] = 4;
array[6] = 6;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44); //попробуем найти значение 44 в массиве
Console.WriteLine(pos);