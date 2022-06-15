//Задача 1.Является ли число палиндромом.
/*
void NumPalindrom(int num)
{
    if(num > 999 && num <= 99999)
    {
        if(num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10)
        {
           Console.Write("Your number is palindrome");
        }
        else
        {
            Console.Write("Your number is not palindrome");
        }
    }
    else Console.WriteLine("False! Please input 5-digit number.");
}
Console.Write("Input your 5-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
NumPalindrom(num);
*/

//Задача 2. Расстояние между 2 точками в 3Д пространстве
/*
double FindLength(double xA, double xB, double yA, double yB, double zA, double zB)
{
    return Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));
}

Console.Write("Input xA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB: ");
double zB = Convert.ToDouble(Console.ReadLine());

double result = FindLength(xA, xB, yA, yB, zA, zB);
Console.WriteLine("Distance is " + result);
*/

//Задача 3.Вывести таблицу кубоов чисел от 1 до N
/*
void Qub(int num)
{
    int current = 1;
    if(num <= 1)
    {
       Console.WriteLine("False! Please input correct number");
    }
    while(current <= num)
    if(num > 1)
    {
        Console.Write((current * current * current) + " ");
        current ++;
    }
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Qub(num);
*/