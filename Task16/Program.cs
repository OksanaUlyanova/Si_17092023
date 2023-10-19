// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool MultipleNumbers(int num, int num1, int num2,)
{
    return num % num1 == 0 &&num % num2 ==  0;
}

Console.WriteLine("Введите первое число:   ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число:   ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool IsSquareTowNumber(int num1, int num2)
{
    return num1 + num2 == || num2 * num2 == num1;
}
bool result = IsSquareToNumber (firstNum, secondNum);
Console.WriteLine(result ? $"{firstNum}, {secondNum} - > ДА" : $"{firstNum}, {secondNum} - > Нет");

