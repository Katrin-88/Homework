//Задача1.Создайте двумерный массив и напишите программу, которая поменяет местами первую и последнюю строки этого массива

int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m,n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = new Random().Next(min, max + 1);
        
    return array;
} 

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
           Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;

    for(int j = 0; j < array.GetLength(1); j ++)
    {
        temp = array[strIndex1, j];
        array[strIndex1,j] = array[strIndex2,j];
        array[strIndex2,j] = temp;
    }

    return array;
}
int m, n , min, max;

do
{
    Console.WriteLine("Число строк должно быть равно числу столбцов. Введите данные: ");
     m = Convert.ToInt32(Console.ReadLine());
     n = Convert.ToInt32(Console.ReadLine());
     min = Convert.ToInt32(Console.ReadLine());
     max = Convert.ToInt32(Console.ReadLine());
}
while(m != n);

int[,] myArray = CreateTwoDimArray(m,n,min,max);

ShowArray(myArray);
myArray = ChangeLines(myArray,0,myArray.GetLength(0) - 1);
Console.WriteLine();
ShowArray(myArray);


//Задача2.Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
int[,] ChangeRowsColumns(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
    }
     return array;
}

int[,] myArray = CreateTwoDimArray(4,4,1,9);
ShowArray(myArray);
Console.WriteLine();
myArray = ChangeRowsColumns(myArray);
ShowArray(myArray);


//Задача3. Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.
/*
int[,] DeleteRowColumn(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[minRow,minColumn];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < min) 
            {
                min = array[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }
for(int i = 0; i < array.GetLength(0); i++)
{
    array[i,minColumn] = 0;
}
for(int j = 0; j < array.GetLength(1); j++)
{
    array[minRow,j] = 0;
}
return array;
}

int[,] myArray = CreateTwoDimArray(4,5,1,100);
ShowArray(myArray);
Console.WriteLine();
myArray = DeleteRowColumn(myArray);
ShowArray(myArray);

*/