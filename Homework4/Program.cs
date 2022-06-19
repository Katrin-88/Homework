//Задача 1. Программа принимает 2 числа. Нужно число А взвести в степень B

/*
int Stepen(int numA, int numB)
{
  int result = 1;
  for(int i = 1; i <= numB; i++)
  {
    result = result * numA;
  }
   return result;
}

  Console.Write("Input number A: ");
  int numA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input number B: ");
  int numB = Convert.ToInt32(Console.ReadLine());

  int ResultAB = Stepen(numA, numB);
  Console.WriteLine("Result is: " + ResultAB);
*/

//Задача 2. Создать массив из 8 элементов

int size = 8;
int[] array = new int [size];
for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1,99);
}
for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
