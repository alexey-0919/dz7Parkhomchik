/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int InputNumber()
{
    Console.WriteLine("Input number");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}


int m = InputNumber();
int n = InputNumber();

int[,] array = new int[m, m];
FillArrayRandomNumbers(array);
PrintArray(array);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(15));
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine("");
    }
}

Console.WriteLine();


int z = InputNumber();
int y = InputNumber();



if (z < m && y < n)
    Console.WriteLine(array[z,y]);
else
    Console.WriteLine($"{z} {y} -> такого числа в массиве нет");

   
