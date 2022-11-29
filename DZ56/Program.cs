// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.WriteLine("Programm to find the row with minimal elements sum.");

Console.Write("Input the rows number: ");
int rows;

while (!int.TryParse(Console.ReadLine()!, out rows) || rows <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input the rows number: ");
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

if (rows == columns)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Array should be rectangular");
    Console.ResetColor();
}
else
{
    int[,] array = CreateArray(rows, columns);
    int[] sumOfRows = GetSumOfRowsArray(array, rows);

    int[,] CreateArray(int rows, int columns)
    {
        Random random = new Random();
        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 11);
            }
        }

        return array;
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,6}", array[i, j]);
            }
        
            Console.WriteLine();
        }
    }

    int[] GetSumOfRowsArray(int[,] array, int rows) // получаем новый массив из сумм
    {
        int[] sumOfRows = new int[rows];
   
        for (int i = 0; i < sumOfRows.Length; i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumOfRows[i] += array[i, j];
            }

        return sumOfRows;
    }

    void GetMinimumSum(int[] sumOfRows)// определяем индекс строки
    {
        int minSum = sumOfRows[0];
        int minSumIndex = 0;

        for (int i = 0; i < sumOfRows.Length; i++)
        {
            if(sumOfRows[i] < minSum)
            {
                minSum = sumOfRows[i];
                minSumIndex = i;
            }
        }
    // Console.WriteLine($"Minimal elements sum in a row is {minSum} "); // для проверки
    Console.WriteLine($"\nThe minimal elememts sum is in the {minSumIndex + 1} row");
}

CreateArray(rows, columns);
Console.WriteLine("\nCreated array:");
PrintArray(array);
GetSumOfRowsArray(array, rows);
GetMinimumSum(sumOfRows);
}