/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] GenerateArray(int length)
{
    string[] resultArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = Convert.ToString(Console.ReadLine());
    }
    return resultArray;
}
void printArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine("]");
}
string[] NewArray = GenerateArray(5);
string[] SecondArray = new string[NewArray.Length];
void SortArray(string[] NewArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
    if(NewArray[i].Length <= 3)
        {
        SecondArray[count] = NewArray[i];
        count++;
        }
    }
}
printArray(NewArray);
SortArray(NewArray, SecondArray);
printArray(SecondArray);