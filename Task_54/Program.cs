// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateArrayNumbers(int row, int colomn)
{
    int[,] array = new int[row, colomn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            Console.Write($"Введите значение элемента массива расположенного в {i + 1} строке, {j + 1} столбце: ");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.WriteLine();

    return array;
}

void ShowArray(int[,] arr, string phrase)
{
    Console.WriteLine(phrase);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] SortRowsArrayInDescendingOrder(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            for (int j = 1; j < arr.GetLength(1)-k; j++)
            {
                int buffer = default;

                if (arr[i, j - 1] < arr[i, j])
                {
                    buffer = arr[i, j - 1];

                    arr[i, j - 1] = arr[i, j];

                    arr[i, j] = buffer;
                }
            }
        }
    }

    return arr;
}

int longRow = InitialData("Введите колличество строк массива: ");
int longColomn = InitialData("Введите колличество столбцов массива: ");

int[,] newArray = new int[longRow, longColomn];
newArray = CreateArrayNumbers(longRow, longColomn);

ShowArray(newArray, "Введен двухмерный массив, содержащий следующте элементы:");

newArray = SortRowsArrayInDescendingOrder(newArray);

ShowArray(newArray, "В результате сортировки получен следующий массив элементов:");