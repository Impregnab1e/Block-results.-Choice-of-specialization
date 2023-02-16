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

