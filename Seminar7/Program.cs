//Задача1. Сгенерировать двумерный массив на основании 2 чисел, который
//задаст пользователь и сгенерировать случайными числами
/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(4,5,1,10);


//Задача2ю ЗАдайте двумерный массив, размера MxN, каждый элемент в массиве находится по формуле: Aij = i + j.
//Выведите полученный массив на экран

int[,] CreateArray(int a, int b)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    for(int j = 0; j < b; j++)
    newMatrix[i,j] = i + j;

    return newMatrix;
}

void ShowTwoDimArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateRandomTwoDemArray(4,5);


//Задача3. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените
//эти элементы на их квадраты.

int[,] UpdateArrayEvenIndexQuad(int[,] array)
{
    int step = 2;
    for(int i = 0; i < array.GetLength(0); i += step)
    for(int j = 0; j < array.GetLength(1); j += step)
    array[i,j] *= array[i,j];

    return array;
}

int[,] myArray = CreateRandomTwoDemArray(4,5,2,15);

Console.WriteLine();

UpdateArrayEvenIndexQuad(myArray);
*/

//Задача4. Задайте двумерный массив. Найдите сумму элементов, нахлдящихся на главной
//диагонали с индексами (0,0); (1,0) и т.д.

int SumOfDiagonal(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    sum += array[i,i];

    return sum;
}

int[,] myArray = CreateRandomTwoDemArraySquare(7,2,15);

Console.WriteLine(SumOfDiagonal(myArray));