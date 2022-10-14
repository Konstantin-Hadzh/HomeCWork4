/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber); // функция определения модуля числа, чтобы код работал с отрицательным числом на входе
int result = 1; // так как минимальое количество цифр в числе не может быть меньше одной, чтобы код работал с 0
if (userNumber != 0)
{
    result = (int) Math.Log10(userNumber) + 1; // число проверяем логорифмом. Например, логорифм 100 = 2
}
int len = result;
Console.WriteLine($"Количество цифр в числ равно {result}");

SumNumbers(userNumber, len);

void SumNumbers(int userNumber, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += userNumber % 10; // += - оператор присваивания сложения. Например, x += y то же, что и x = x + y
        userNumber /= 10; // /= - оператор присваивания деления. Разделить переменную на значение и ответ присвоить этой же переменной x /= y то же, что и  x = x / y
    }
    Console.WriteLine($"сумма цифр равна {sum}");
}
