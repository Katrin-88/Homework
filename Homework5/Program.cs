//1.Задайте массив со случайными полож трёхзнач числами.Пр-ма, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}
/*
int CountOfEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("My array");
int[] myArray = CreateRandomArray(10,100,999);

Console.WriteLine("Count of even numbers is: " + CountOfEvenNumbers(myArray));

*/
//2.Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int SumOfOddNumbers(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i]; 
    }
    return sum;
}
Console.WriteLine("My array");
int[] myArray = CreateRandomArray(10,1,30);

Console.WriteLine("Sum of odd numbers is: " + SumOfOddNumbers(myArray));
*/


//3.Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел.Найти разницу между макс и мин эл-тов массива.
//[3 7 22 2 78] -> 76


double[] CreateDoubleRandomArray(int size, double min, double max)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble() * ((max - min) + min);
        Console.Write(Math.Round(newArray[i],0) +  " ");
    }
    Console.WriteLine();
    return newArray;
}


double MaxElement(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}


Console.WriteLine("My array" );
double[] myArray = CreateDoubleRandomArray(10,10,50);

Console.WriteLine("Max element is: " + Math.Round(MaxElement(myArray),0));
Console.WriteLine("Min element is: " + Math.Round(MinElement(myArray),0));
Console.WriteLine("Substraction of elements is: " + Math.Round((MaxElement(myArray) - MinElement(myArray))),0);

