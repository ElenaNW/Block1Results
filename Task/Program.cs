// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string [] firstArray = CreateArrayString();
PrintArray(firstArray);
Console.Write(" -> ");
int count = CountElements(firstArray);
string[] secondArray = SecondArray(count, firstArray);
PrintArray(secondArray);


string [] CreateArrayString()
{
    string[] arr = new string[] { "Sunday", "1", "day", "Wednesday", "Th", "Friday", "Sat" };
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int CountElements(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] SecondArray(int size, string[] arr)
{
    string[] secArr = new string[size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        { 
            secArr[j] = arr[i];
            j++;
        }
    }
    return secArr;
}
