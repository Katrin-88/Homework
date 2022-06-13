// Программа, которая принимает на вход координаты точки (х и y), причем х не равен 
// и У не равен 0 и выдает номер четверти плоскости, в которой находитсся эта точка.
/*
int FindQuard(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if( x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return -1;
}
// Вводить надо как обычно через ReadLine
int result = FindQuard(-4,0);
if(result == -1) Console.WriteLine("Данная точка расположена на осях");
else Console.WriteLine($"Точка находится в {result} четверти");

*/

//Найти расстояние между 2 точками
//Гипотенуза^2 = катет^2 + катет^2 
//AB^2 = (Xb - Xa)^2 +(Yb - Ya)^2)
//Расстояние АВ = корень из (Хb - Xa^2) + (Yb - Ya^2)
//Готовая функция Math.Sqrt(AB)

//double(в отличие от int хранит вещественные числа,т.е. не целы, а int только целые)

double FindLength(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB - xA)*(yB - yA)) + Math.Pow((yB - yA), 2);
}//Maxth.Pow такое же вычисление, как и в первой части уравнения. 2 в скобках - степень
Сonvert.ToDouble();