// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/* Вариант 1
Console.Write("Введите число M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов в промежутке от M = {M} до N = {N} - > {SumNumbers(M, N)}");
Console.ReadLine();
 
int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
    else return N + SumNumbers(M, N + 1);            // Если M>N
}*/
/*Вариант 2*/
Console.Write("Введите число M = ");
int M = Convert.ToInt32(Console.ReadLine());

if (M < 1) M = 1;

Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.Write("В заданном Вами диапазоне отсутствуют натуральные числа");
}
else
{

    SumFromMToN(M, N);

    // вызов функции "сумма чисел от M до N"
    void SumFromMToN(int m, int n)
    {
        Console.Write("Сумма натуральных чисел в заданном диапазоне: " + SumMN(M - 1, N));
    }

    // функция сумма чисел от M до N
    int SumMN(int M, int N)
    {
        int result = M;
        if (M == N)
            return 0;
        else
        {
            M++;
            result = M + SumMN(M, N);
            return result;
        }
    }
}


