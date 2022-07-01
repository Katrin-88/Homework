//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] CreateRandomDoubleArray(int m, int n, double min, double max)
{
    double[,] newMatrix = new double[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().NextDouble() * ((max - min) + min);
            Console.Write(Math.Round(newMatrix[i,j],1) + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}


Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(ВВведите min: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите max: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] array = CreateRandomDoubleArray(m,n,min,max);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] newMatrix = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}
int[,] newMatrix = CreateRandomArray(m, n, min, max);

Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

void ShowElement(int[,] newMatrix, int a, int b)
{
    int result = 0;
    if(a < newMatrix.GetLength(0) && b <newMatrix.GetLength(1))
    {
         result += newMatrix[a,b];
         Console.Write("Число " + result);
    }
    else  Console.Write("Такого числа нет");
    
}
 
ShowElement(newMatrix,a,b);




//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
void SumOfAverage(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < newMatrix.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        double average = sum / array.GetLength(0);
        Console.Write(average + " ");
    }

}

int[,] array = CreateRandomArray(m, n, min, max);

SumOfAverage(array);

    */