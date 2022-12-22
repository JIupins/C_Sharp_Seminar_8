// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateSpiralArrayOfNumbers(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    int value = 1;
    int totalElements = rows * columns;

    int rowMin = default, rowMax = rows - 1;
    int colMin = default, colMax = columns - 1;

    while (value <= totalElements)
    {
        for (int i = colMin; value <= totalElements && i <= colMax; i++)
        {
            array[rowMin, i] = value++;
        }
        rowMin++;

        for (int i = rowMin; value <= totalElements && i <= rowMax; i++)
        {
            array[i, colMax] = value++;
        }
        colMax--;

        for (int i = colMax; value <= totalElements && i >= colMin; i--)
        {
            array[rowMax, i] = value++;
        }
        rowMax--;

        for (int i = rowMax; value <= totalElements && i >= rowMin; i--)
        {
            array[i, colMin] = value++;
        }
        colMin++;
    }

    return array;
}

void ShowArray(int[,] arr, string phrase)
{
    Console.WriteLine();

    Console.WriteLine(phrase);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] / 10 < 1) Console.Write($"{0}{arr[i, j]}  ");

            else Console.Write($"{arr[i, j]}  ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

int longRow = InitialData("Введите колличество строк массива: ");
int longColomn = InitialData("Введите колличество столбцов массива: ");

int[,] newArray = new int[longRow, longColomn];
newArray = CreateSpiralArrayOfNumbers(longRow, longColomn);

ShowArray(newArray, $"Сгенерирован двухмерный спиральный массив размером {longRow} x {longColomn}, содержащий следующте элементы:");