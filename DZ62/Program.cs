// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillSpiral (int size)
{
    int[,] array = new int[size, size];
    int number = 1;

    for (int i = 1; i < size; i++) // заполняем по спирали
    {
        for (int j = i - 1; j < size - i + 1; j++)
        {
            array[i - 1, j] = number++;
        }
        for (int j = i; j < size - i + 1; j++)
        {
            array[j, size - i] = number++;
        }
        for (int j = size - i - 1; j >= i - 1; j--)
        {
            array[size - i, j] = number++;
        }
        for (int j = size - i - 1; j >= i; j--)
        {
            array[j, i - 1] = number++;
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
            if (input[i, j] < 10)
                Console.Write("{0,3}", "0" + input[i, j]);
            else
                Console.Write("{0,3}", input[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Programm to fill in the square array under spiral line");
Console.Write("Input the array size:\t");

int size;

while (!int.TryParse(Console.ReadLine()!, out size) || size <= 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input the array size:\t");
}

int[,] array = FillSpiral(size);
PrintArray(array);
