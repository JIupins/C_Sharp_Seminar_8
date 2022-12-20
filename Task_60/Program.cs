// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int InitialData(string word)
{
    Console.Write(word);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,,] CreateArrayNumbers(int row, int colomn, int width)
{
    Console.WriteLine();

    int[,,] array = new int[row, colomn, width];

    for (int k = 0; k < width; k++)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < colomn; j++)
            {
                Console.Write($"Введите значение элемента расположенного в {i + 1} строке, {j + 1} столбце, {k+1} ряда трехмерного массива: ");
                array[i, j, k] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    Console.WriteLine();

    return array;
}

void ShowArray(int[,,] arr, string phrase1)
{
    Console.WriteLine(phrase1);

    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]}   ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("--------");
    }

    Console.WriteLine();
}

void ShowValuesOfArrayWithTheirIndexes(int[,,] arr1, string phrase2)
{
    Console.WriteLine(phrase2);

    for (int k = 0; k < arr1.GetLength(2); k++)
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                Console.Write($"{arr1[i, j, k]}({i},{j},{k})  ");
            }

            Console.WriteLine();
        }

        Console.WriteLine("---------------------");
    }
}

int longRow = InitialData("Введите первое измерение трехмерного массива (колличество строк двухмерного массива): ");
int longColomn = InitialData("Введите второе измерение трехмерного массива (колличество столбцов двухмерного массива): ");
int longWidth = InitialData("Введите третье измерение трехмерного массива (колличество двумерных массивов): ");

int[,,] newArray = new int[longRow, longColomn, longWidth];
newArray = CreateArrayNumbers(longRow, longColomn, longWidth);

ShowArray(newArray, "Введен трехмерный массив, содержащий следующте элементы:");

ShowValuesOfArrayWithTheirIndexes(newArray, "Элементы трехмерного массива, имеют следующие индексы:");