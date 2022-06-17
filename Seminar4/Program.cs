//Программа принимает на вход число. Нужно найти сумму цифр этого числа
/*
int FindSumOfDigit(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num % 10;// sum += sum % 10 в старое значение записываем новое значение.также можно записать
        num = num / 10; // num /= 10
    }
    return sum;
} 

int n = 234;
int result = FindSumOfDigit(n); // пример
Console.WriteLine($"сумма цифо в числе {n} равна {result}");
*/

//Задача 2
//Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А   Доработать
/*
int Summa(int a)
{
    int result = 0;
    int count = 1;
    while(count <= a)
    {
        result = result + count; // result += count
        count ++;
    }
    return result;
}
Console.WriteLine("Enter your natural number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum is: " + Summa(num));
*/

//Задача 3. Программа принимает на вход число и выдает произведение чисел от 1 до N. Доработать
/*
int Fact(int a)
{
    int result = 1;
    int count = 1;
    while(count <= a)
    {
        result *= count;
        count ++;
    }
    return result;
}
Console.WriteLine("Enter your natural number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Fact(num));
*/

//Задача 4. Напишите программу, которая принимает на вход число и выдает количество цифр в числе
/*
void Count(int a)
{
    int counter = 0;
    while( a > 0);
    {
        a = a / 10;
        counter ++;
    }
    Console.WriteLine("Count of digits of your number is: " + counter);
}
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Count(a);
*/

//Задача 5. Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

int size = 8;
int[] array = new int[size];
for(int i = 0; i < size; i ++)
{
    array[i] = new Random().Next(0,2);
}

for(int i = 0; i < size; i ++)
{
    Console.Write(array[i] + " ");
}