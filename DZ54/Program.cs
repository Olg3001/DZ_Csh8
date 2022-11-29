// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Programm to sort the elements in array rows from max to min");

Console.Write("Input the rows number: ");
int rows;

while (!int.TryParse(Console.ReadLine()!, out rows) || rows <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input the rows number: ");
}

Console.Write("Input the columns number: ");
int columns;

while (!int.TryParse(Console.ReadLine()!, out columns) || columns <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input the columns number: ");
}

int[,] array = CreateArray(rows, columns);

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();

    int[,] array = new int[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }

    return array;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            for (var k = 0; k < input.GetLength(1); k++)
            {
                if (input[i, j] > input[i, k])
                {
                    int temp = input[i, j];
                    input[i, j] = input[i, k];
                    input[i, k] = temp;
                }
            }
        }
    }
    return input;
}

CreateArray(rows, columns);
Console.WriteLine("\nCreated array:");
PrintArray(array);
SortArray(array);
Console.WriteLine("\nSorted array:");
PrintArray(array);