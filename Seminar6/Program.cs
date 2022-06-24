// Задача на разворот массива
/*int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1; //индекс последнего элемента
    for(int i = 0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
/*
//второй вариант записи
int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1, i = 0; //индекс последнего элемента
    while(i < j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
    }
    return array;
}

int[] myArray = {2, 4, 6, 8};
 
 myArray = ReverseArray(myArray);
 for(int i = 0; i < myArray.Length; i++)
 {
    Console.Write(myArray[i] + " ");
 }
 

// 2.Программа принимает 3 числа и проверяет может ли существовать треугольник
//со сторонами такой длины (сумма любых 2 сторон > 3 стороны, a + b > c)
void TriAngle(int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a) Console.WriteLine("Такой треугольник возможен");
    else Console.WriteLine("Такой треугольник не возможен");
}

int a = 3;
int b = 5;
int c = 7;

TriAngle(a, b, c);


//3.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//f(n) = f(n-1) + f(n - 2)
void Fibonacci(int n)
{
    int[] Array = new int[n];
    Array[0] = 0;
    Array[1] = 1;
    Console.Write(Array[0] + " " + Array[1] + " ");
    for(int i = 2; i < n; i++)
    {
        Array[i] = Array[i - 1] + Array[i - 2];
        Console.Write(Array[i] + " ");
    }
}
int n = 5;
Fibonacci(n);
*/

//4.Напишите программу, которая будет преображать десятичное число в двоичное
string BinaryNumber(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}
Console.WriteLine(BinaryNumber(45));