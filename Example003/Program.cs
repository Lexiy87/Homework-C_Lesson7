// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] InitMatrix()
{
    int[,] array = new int[4, 5];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 20);
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

            System.Console.Write($"{array[i, j]} ");

        }
        System.Console.WriteLine();
    }
}

void FindArithmeticMean(int[,] array)
{
    
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            average = sum / array.GetLength(0);
            
        }
        
        System.Console.Write(" " + average);
    }
    
    
}

int[,] array = InitMatrix();
PrintArray(array);
System.Console.WriteLine($"Среднее арифметическое каждого столца ");
FindArithmeticMean(array);



