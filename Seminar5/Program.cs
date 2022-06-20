/*
//Задача 1. Задайте массив из 12 элементов, заполненный случайными ччислами из промежутка[-9,9]. Найдите сумму отрицательных и положительных элементов в массиве
//1метод для создания массива из случайных чисел
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

//находим сумму + чисел
int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

//находим сумму - чисел
int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

int[] myArray = CreateRandomArray(12, -9, 9);
//это пример. Мы сами просим ввести длину массива, мин диапазон, мах диапазон)
Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray));

*/

//Задача2. Напишите программу, заменить элементы массива: полож на отриц и наоборот
bool FindNumberInArray(int[] array, int aa)
{
for(int i = 0; i < array.Length; i++)
    {
      if(array[i] == aa) return true;
    }
    return false;
}

//Задача 3. Задайте массив.Напишите программу, которая определяет присутствует ли заданне число в массиве
int[] ReverseElementsArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    array[i] *= -1;
    }
    return array;
}
//Задача 4.ЗАдайте одномерный массив из 12 случайных чисел.Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
int FindCountElemensInRange( int[] array, int min, int max)
{
   int count = 0;
   for( int i=0; i < array.Length; i++)
   {
   if( array[i] >= min && array[i] <= max ) count++;
   }
   return count;
}

string OutputArrayConsole(int[] array)
{
  string ss = "";
  for(int i = 0; i < array.Length; i++)
  {
  ss += array[i] + ", ";
  }
  return ss;
}

//программа
Console.WriteLine("Работаем");
int[] myArray = CreateRandomArray(20,-20,20);
//Задача2
Console.WriteLine("reverse array " + OutputArrayConsole( ReverseElementsArray(myArray)) );
//Задача3
int find = 16;
Console.WriteLine("В массиве число "+ find + ( (FindNumberInArray(myArray,find)) ? "присутствует" : " не присутствует" ) );
//Задача4
int minnum = 10;
int maxnum = 99;
Console.WriteLine("количество цифр в отрезке " + minimum + " до " + maximum + " = " + FindCountElemensInRange(myArray, minimum, maximum));