//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по возрастанию элементы каждой строки двумерного массива.
//Например, задан массив:      В итоге получается вот такой массив:
//1 4 7 2                        1 2 4 7
//5 9 2 3                        2 3 5 9 
//8 4 2 4                        2 4 4 8
/*
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = new Random().Next(min, max + 1);
        
    return array;
} 
*/
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
/*
int[,] VozrastElement(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,k] < array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}
int[,] myArray = CreateTwoDimArray(m,n,min,max);
ShowArray(myArray);
Console.WriteLine();
ShowArray(VozrastElement(myArray));

*/


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
//будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int RowMinElement(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
     for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];               
        }

        if(sum < minSum)
       {
        minSum = sum;
        minRow = i;
       }
        if(i == 0) minSum = sum;
    }
    return minRow;
}

int[,] myArray = CreateTwoDimArray(m,n,min,max);
ShowArray(myArray);
Console.WriteLine("Номер строки с min суммой элементов: " + RowMinElement(myArray));
*/


//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

int[,] SpiralMatrix()
{
    int side = 4;
    int LastElement = 1;
    int[,] array = new int[side,side];
    int num = 1;

    for (int k = 0; k < side - LastElement * LastElement; k++)
    {
        for(int j = k; j < side - LastElement - k; j++, num++)
        {
            array[k,j] = num;
        }
        for (int i = k; i < side - LastElement - k; i++, num++)
        {
            array[i,side - LastElement - k] = num;
        }
        for (int j = side - LastElement - k; j >= k; j--, num++)
        {
            array[side - LastElement - k,j] = num;
        }
        for (int i = side - LastElement * 2 - k; i > k; i--, num++)
        {
            array[i,k] = num;
        }
    }

    return array;
}

int[,] myArray = SpiralMatrix();
ShowArray(myArray);
