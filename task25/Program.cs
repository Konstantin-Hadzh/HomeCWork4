/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.Write("Введите значение А: ");
int userNumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение B: ");
int userNumB = Convert.ToInt32(Console.ReadLine());
getNumNaturDegree(userNumA, userNumB);

void getNumNaturDegree(int numA, int numB)
{
    int result = 1; 
    for(int i = 1; i <= numB; i++) 
    {
        result = result * numA; 
    }
    Console.WriteLine($"Возведение {userNumA} в натуральную степень {userNumB} равна {result}");
}
