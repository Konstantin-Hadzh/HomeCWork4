/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, 
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/


Console.Write("Введите значение длины массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[userNumber];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 99);
}
Console.Write($"{userNumber} -> ");

PrintArray(array);

void PrintArray(int[] array) // "метод", который будет печатать массив //
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

Console.WriteLine();