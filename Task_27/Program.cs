/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Amount(int num)
{
    int result = 0;

    while (num > 0)
    {
        result = result + num % 10;   // result += num % 10;

        num = num / 10;
    }
    return result;
}

int number = InputNum(" Введите целое число: ");
int result = Amount(number);
Console.Write(" Суммма цифр в числе: " + result);
