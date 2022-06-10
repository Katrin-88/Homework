/*
// Задача: программа принимает на вход двузначное число и выводит большую из ее цифр.
//Сначала указываем тип данных возвращаемый (н-р, int или string), далее даем название функции

int FindMaxPart(int num)//число состоит из десятков и единиц
{
    int dec, ed; // у нас есть десятки и единицы
    if(num >=10 && num <= 99)//показываем, что число двузначное
    {
        dec = num / 10;
        ed = num % 10;

        if(dec > ed)
        {
            return dec; // возвращаем цифру из разряда десятков
        }
        else
        {
            return ed; // возвращаем цифру из единиц
        }
    }
    else //если н-р, число не двузначное
    {
        return -1;
    }
}

// c = a % b
// 5 % 2 -> 1 показывает остаток от деления
// 5 / 2 -> 2 делит число до целого

// 1234 

// 1234 / 10 -> 123 % 10 -> 3
// 1234 % 10 -> 4
// 1234 % 100 -> 34
// 1234 / 100 -> 12
// 12 % 10 -> = 2
// 35 % 10 = 5
// 123 % 10 = 3
// 1234 % 100 = 34

Console.Write("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a); 

if(result == -1)
{
    Console.WriteLine("Your number is not two-digit!");
}
else
{
Console.WriteLine("Bigger number of " + a + " is " + result);
//можно записать так: Console.WriteLine($"Bigger number of {a} is {result}")
}
*/

//Задача 1: Программа принимает случайное трехзначное число, удаляет среднюю цифру и выводит два крайних (123->13)

int CutNumber()
{
    int num = new Random().Next(10,1000);//генерируем случайное трехзначное число(100,1000)
    
    int sot = num / 100;
    int ed = num % 10; 

    int result = sot * 10 + ed;
    return result;
}
int b = CutNumber();
Console.WriteLine(b);

//Задача 2: программа принимает2 числа и является ли второе число кратным первому. Если второе не кратно, то программа выводит омтаток от деления.
string IsAliquout(int num1, int num2)
{
    if(num2 / num1 == 0) return "True";
    else return ("False, rest num is " + (num2 / num1));
}

Console.WriteLine(IsAliquout(a,b));//пример a,b

//Задача 3: проверить делится ли число одновременно на 7 и 23
bool IsAliquot2(int num)
{
    if(num % 23 == 0 && num % 7 == 0) return true;
    else return false;
}
if(IsAliquot2(10)) Console.WriteLine("Число кратно");
else Console.WriteLine("Число не кратно");
//можно записать сразу команду return (num % 23 == 0 && num % 7 == 0);
// bool определяет тру или фолс