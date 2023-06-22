/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int EnterTwoNumbers(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int TwoNumber(int num1, int num2)
{
    int degree = num1;
    for (int i = 1; i < num2; i++)
    {
        degree = degree * num1;
    }
    return degree;
}


int num1 = EnterTwoNumbers("Введите первое число: ");
int num2 = EnterTwoNumbers("Введите второе число: ");

int result = TwoNumber(num1, num2);
Console.WriteLine(result);
