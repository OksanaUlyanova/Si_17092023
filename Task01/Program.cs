/* Напишите программу, которая на вход принимает два
числа и проверяет, яволяется ли первое число квадратом второго.
a = 25, b = 5 -> Да
a = 2,  b = 10 -> Нет
a = 9,  b = -3 -> Да
a = -3, b = 9 -> Нет*/ 

int firstNumber, secondNumber;

Console.WriteLine("Введите первое число:  ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine($"Первое число = {firstNumber}, Второе число = {secondNumber} -> Да");
}
else
{
    Console.WriteLine($"Первое число = {firstNumber}, Второе число = {secondNumber} -> Нет");
}