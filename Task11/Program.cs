/*11. Напишите программу, которая выводит 
случайное трёхзначное число и удаляет 
вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/
int num = new ReadLine(100, 1000);
Console.WriteLine($"На вход получаем число -> {num}");
/*int first_num = num / 100;
int last_num = num % 100;
int result = first_num *10 + last_num;
Console.WriteLine($"Двухзначное число -> {result}");*/


int DeleteSecondDigit(int number)
{
    int firstnum = number / 100;
    int lastnum = number % 10;
    return firstnum *10 + lastnum;
}
int res = DeleteSecondDigit(num);
Console.WriteLine(res);