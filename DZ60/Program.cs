// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray(int size1, int size2, int size3)
{
    Random random = new Random();
    int[,,] array = new int[size1, size2, size3];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2);)
            {
                bool isAlreadyExists = false; // проверяем, существует ли число в массиве
                int randomNumber = random.Next(10, 100);
                                
                for (int l = 0; l < size1; l++)
                {
                    for (int m = 0; m < size2; m++)
                    {
                        for (int n = 0; n < size3; n++)
                        {
                            if (array[l, m, n] == randomNumber) 
                            {
                                isAlreadyExists = true;
                                break; 
                            }
                        }
                    }
                }
                if (!isAlreadyExists) 
                {
                    array[i, j, k] = randomNumber;
                    k++;
                }
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }

            Console.WriteLine();
        }
    }
}

Console.WriteLine("Programm to demonstrate the elemets of 3D array with their index.");

Console.WriteLine("Input the 3D array sizes. After every input press 'Enter'.");

int size1;

while (!int.TryParse(Console.ReadLine()!, out size1) || size1 <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input size:\t");
}

int size2;

while (!int.TryParse(Console.ReadLine()!, out size2) || size2 <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input size:\t");
}

int size3;

while (!int.TryParse(Console.ReadLine()!, out size3) || size3 <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.WriteLine("Input size:\t");
}

int[,,] array = CreateArray(size1, size2, size3);

Console.WriteLine("\nThe array elements are:");
PrintArray(array);