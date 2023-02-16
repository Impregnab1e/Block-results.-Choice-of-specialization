/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.Clear();

int GetDataFromUser(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


string[] ArrayFromUser(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите данные: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}


string[] ThreeSymbolArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[n] = array[i];
            n++;
        }
    }
    return newArray;
}

void printArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}


int length = GetDataFromUser($"Задайте длину массива");
string[] FirstArray = ArrayFromUser(length);
Console.WriteLine("");
Console.WriteLine("Заданный массив: ");
printArray(FirstArray);
string[] FilterTreeSymbolArray = ThreeSymbolArray(FirstArray);
Console.WriteLine("");
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
printArray(FilterTreeSymbolArray);