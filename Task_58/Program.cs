// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] CreateArrayNumbers(int row, int colomn, string word)
{
    int[,] array = new int[row, colomn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            Console.Write($"Введите значение элемента {word} массива расположенного в {i + 1} строке, {j + 1} столбце: ");
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

int[,] MultiplyTwoArrays(int[,] arr1, int[,] arr2)
{
    int[,] totArray = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < totArray.GetLength(0); i++)
    {
        for (int j = 0; j < totArray.GetLength(1); j++)
        {
            for (int k = 0; k < totArray.GetLength(0); k++)
            {
                totArray[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }

    return totArray;
}

int longRow = InitialData("Введите колличество строк первого и второго массива: ");
int longColomn = InitialData("Введите колличество столбцов первого и второго массива: ");

int[,] newArray1 = new int[longRow, longColomn];
newArray1 = CreateArrayNumbers(longRow, longColomn, "первого");

int[,] newArray2 = new int[longRow, longColomn];
newArray2 = CreateArrayNumbers(longRow, longColomn, "второго");

ShowArray(newArray1, "Введен первый двухмерный массив, содержащий следующте элементы:");
ShowArray(newArray2, "Введенм второй двухмерный массив, содержащий следующте элементы:");

int[,] totalArray = new int[longRow, longColomn];
totalArray = MultiplyTwoArrays(newArray1, newArray2);

ShowArray(totalArray, "В результате перемножения двух двухмерных массивов получена следующая матрица: ");