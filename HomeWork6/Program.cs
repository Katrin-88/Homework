//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Massive = new int[M];

void Numbers(int M)
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    Massive[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int CountOfNumbers(int[] Massive)
{
  int count = 0;
  for (int i = 0; i < Massive.Length; i++)
  {
    if(Massive[i] > 0 ) count ++; 
  }
  return count;
}

Numbers(M);
Console.WriteLine("Количество чисел больше 0 равно " + CountOfNumbers(Massive));



//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}
Console.WriteLine("My array:");
int[] myArray = CreateRandomArray(5,1,11);
Console.WriteLine("Copy of array:");
myArray = CopyArray(myArray);
*/