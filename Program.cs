// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void CompletionArray(string[] array1, string[] array2)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[i] = array1[i];
            Console.Write($"“{array2[i]}”, ");
        }
    }
    Console.Write("]");
}

string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science"};
string[] array_result = new string[array.Length];
CompletionArray(array, array_result);