﻿// Итоги блока. Выбор специализации. IT-специалист

string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
// решение
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// результат
SecondArrayWithIF(array1, array2);
PrintArray(array2);
