/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

double sum = 0;
double SrArif = 1;

for (int j = 0; j < array.GetLength(1); j++)
    {
         
    for (int i = 0; i < array.GetLength(0); i++)
        {
            
            sum = sum + array[i,j];
        }
        SrArif = sum / array.GetLength(0);
        Console.Write($"{Math.Round(SrArif, 2)}  ");
        sum = 0;
    }
    Console.ReadLine();