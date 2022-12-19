// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindLineWithMinValuesSum(int[,] arr)
{
    int lineWithMinValuesSum = default;
    int numberLine = default;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = default;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }

        if (lineWithMinValuesSum == default)
        {
            lineWithMinValuesSum = sum;
            numberLine = i;
        }

        else if (sum < lineWithMinValuesSum)
        {
            lineWithMinValuesSum = sum;
            numberLine = i;
        }
    }

    Console.WriteLine($"Наименьшую сумму элементов, равную {lineWithMinValuesSum}, содержит {numberLine + 1} строка массива.");
}

int longRow = InitialData("Введите колличество строк массива: ");
int longColomn = InitialData("Введите колличество столбцов массива: ");

int[,] newArray = new int[longRow, longColomn];
newArray = CreateArrayNumbers(longRow, longColomn);

ShowArray(newArray, "Введен двухмерный массив, содержащий следующте элементы:");

FindLineWithMinValuesSum(newArray);