//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
int SumElements(int m, int n)
{    
    if(m < n)
      return n + SumElements(m, n - 1);
    else
      return m;
}

Console.Write("Input m: ");  
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumElements(m, n));
*/

//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
//453 -> 3
//45 -> 2

int CountNumbers(int num)
{
    int count = 1;
    if(num < 10 && num > -10)
       return 1;
    else
       return CountNumbers(num / 10) + count;
}

Console.Write("Input num: ");  
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CountNumbers(num));
