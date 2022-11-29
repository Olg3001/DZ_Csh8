// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray()
{
    int[,] input = new int[2, 2];

    for (var i = 0; i < 2; i++)
    {
        for (var j = 0; j < 2; j++)
        {
            Console.Write($"Input the array element [{i}, {j}]:\t");
            input[i, j]  = int.Parse(Console.ReadLine()!);
        }
    }
    Console.WriteLine("The inputed array:");
    return input;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write("{0,6}", input[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GetProductOfArrays(int[,] array1, int[,] array2)
{
    int[,] resultedArray = new int[2, 2];
    
    resultedArray[0,0] = array1[0,0] * array2[0,0] + array1[0,1] * array2[1,0];
    resultedArray[0,1] = array1[0,0] * array2[0,1] + array1[0,1] * array2[1,1];
    resultedArray[1,0] = array1[1,0] * array2[0,0] + array1[1,1] * array2[1,0];
    resultedArray[1,1] = array1[1,0] * array2[0,1] + array1[1,1] * array2[1,1];

    return resultedArray;
}

Console.WriteLine("Programm to get the product of two arrays");

Console.WriteLine("The 1st array:");
int[,] array1 = CreateArray();
PrintArray(array1);

Console.WriteLine("\nThe second array:");
int[,] array2 = CreateArray();
PrintArray(array2);

int[,] productOfArrays = GetProductOfArrays(array1, array2);
Console.WriteLine("\nThe product of arrays:");
PrintArray(productOfArrays);
