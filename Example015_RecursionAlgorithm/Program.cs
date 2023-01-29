string [,] table = new string[2,5];
// String.Empty
//table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
//table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

/*
table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}*/


void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)                     // тоже самое, что  for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)                                   //тоже самое, что for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)                     // тоже самое, что  for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)                 //тоже самое, что for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);                  // [1, 10) полуинтервал, по факту от 1 до 9
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);