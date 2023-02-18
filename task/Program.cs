/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна трем символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, обойтись ислючительно массивами. */

string[] Prompt(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine().Split(" ");
}

string[] GetArray(string[] array)
{
    int count = 0;
    string[] result = new string[count];
    string[] resultOut = result;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            result = new string[count];
            for (int j = 0; j < result.Length - 1; j++)
            {
                result[j] = resultOut[j];
            }
            result[count - 1] = array[i];
            resultOut = result;
        }
    }
    return resultOut;
}

void PrintArray(string[] array)
{
    string mass = "[";
    if (array.Length > 0)
    {
        mass += "\"" + array[0] + "\"";
        for (int i = 1; i < array.Length; i++)
        {
            mass += ", \"" + array[i] + "\"";
        }
    }
    mass += "]";
    Console.WriteLine(mass);
}

string[] arrOfString = Prompt("Введите элементы массива строк, отделяя каждый элемент массива пробелом: ");
string[] arrOfSymbol = GetArray(arrOfString);
Console.Write("Сформированный массив из элементов введенного массива ");
PrintArray(arrOfString);
Console.Write("Длина которых меньше или равна 3 символам, равен ");
PrintArray(arrOfSymbol);