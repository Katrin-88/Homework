int num1, num2;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.Write("First number is max, second number is min");
}
else
{
    Console.Write("Second number is max, first number is min");
}