// Задача: Написать программу,которая из имеющегося массива строк формирует массив из
// строк, длина которых меньше, либо равна 3 символа. Первоначальный массив, можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры: ["hello", "2", "world", ":-)"]               ->    ["2", ":-)"]
//          ["1234", "1567", "-2", "computer science"]   ->    ["-2"]
//          ["Russia", "Denmark", "Kazan"]               ->    []


Console.WriteLine("Введите целое число, которому будет равна длина входящего массива:");
int number = Convert.ToInt32(Console.ReadLine());

String[] inputArray = new String[number];
int count = 0;
while(count < number)
{
   Console.WriteLine("Введите строку, элемент входящего массива: "); 
   inputArray[count] = Convert.ToString(Console.ReadLine());
   count += 1;
}
Console.Write("Входящий массив -> :");
PrintArray(inputArray);
int sizeNewArray = FindSizeNewArray(inputArray);
String [] outputArray = GetNewArray(inputArray, sizeNewArray);
Console.Write("Полученный массив -> :");
PrintArray(outputArray);

String[] GetNewArray(String[] arr, int num)
{
    String [] newArr = new String [num];
    num = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[num] = arr[i];
            num += 1;
        } 
    }
    return newArr;
}

int FindSizeNewArray(String [] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) size += 1;
    }
    return size;
}

void PrintArray(String[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
