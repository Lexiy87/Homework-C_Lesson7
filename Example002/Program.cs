// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int GetNumber(string message)
{
    int number = 0;
    System.Console.WriteLine(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        else System.Console.WriteLine("Неверное значение, повторите ввод");
    }
    return number;
}

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
void FindIndexToArray(int[,] array, int cols, int rows)
{
    for (int i = cols; i <array.GetLength(0); )
    {
        for (int j = rows; j <array.GetLength(1); j++)
        {
            if (i == cols && j == rows)
            {
                System.Console.WriteLine($"Искомое число {array[i, j]}");
                break;
            }
            else System.Console.WriteLine("Такого числа с таким индексом  в массиве нет");
        }
        break;
    }
  
}


int cols = GetNumber("Введите позицию в столбце");
int rows = GetNumber("Введите позицию в строке");
int[,] array = InitMatrix();
PrintArray(array);
FindIndexToArray(array, cols, rows);

