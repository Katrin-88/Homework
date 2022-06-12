//Задача 1: Программа принимает трехзначное число и на выходе показывает вторую цифру этого числа
/*
int SecondNumber(int num)
{
int dec, ed, result;
if(num > 99 && num < 1000)
{
  dec = num % 100;
  ed = num % 10;
  result = (dec - ed) / 10;
   return result;
}
else
{
    return -1;
}
}
Console.Write("Input your three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SecondNumber(a);
if(result == -1)
{
    Console.WriteLine("Your number is not three-digit!");
}
else
{
    Console.WriteLine($"Second number of {a} is: {result}");
}
*/

//Задача 2: Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int ThirdNumber(int num)
{
    int sot;
    while(num > 999) num = num / 10;
    if(num > 99 && num < 1000)
    {
        return (num % 10);
    }
    else
    {
        return -1;
    }
}
Console.Write("Input your number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = ThirdNumber(a);
if(result == -1)
{
    Console.WriteLine("Your number doesn't have third number");
}
else
{
    Console.WriteLine("Third number is: " + result);
}
*/

//Задача 3: Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string DayOffOrNot(int num)
{
    if(num < 6) return "This day is not a day off.";
    else return "This day is a day off!";
}

Console.Write("Input the day's number: ");
int a = Convert.ToInt32(Console.ReadLine());

string result = DayOffOrNot(a);
Console.WriteLine(DayOffOrNot(a));
