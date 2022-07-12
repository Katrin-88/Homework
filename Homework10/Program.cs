//Задача 1: Задайте массив строк. Напишите программу, которая считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
/*
string[] CreateStringArray(int size)//на вход берем размер символов, который нас интересует
{
    string[] words = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    } 

    return words;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}

int FirstVowel(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    if(array[i][0] == 'a' || array[i][0] == 'e' || array[i][0] == 'i' || array[i][0] == 'o' || array[i][0] == 'u' || array[i][0] == 'y')
        count++;
    return count;
}

Console.Write("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);
Console.WriteLine(" " + FirstVowel(names));
*/

//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя
// элементы исходного массива попарно.
//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
string[] PairsOfElements(string[] array)
{
    int num = 0;
    if(array.Length % 2 != 0) num = 1;    
    string[] newArray = new string [array.Length / 2 + num];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i * 2 + 1 < array.Length) newArray[i] = array[i * 2] + array[i * 2 + 1];
        else newArray[i] = array [i * 2];
    }
    return newArray;
}

string [] array = {"qwe", "wer", "ert", "rty", "tyu", "yui"};
ShowArray(array);
Console.WriteLine();
string [] newArray = PairsOfElements(array);
ShowArray(newArray);