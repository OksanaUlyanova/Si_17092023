// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29

 
Console.Write("Введите число M: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.Write("Введите число N: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write($"Результат: m = {m}, n = {n} - > A(m,n) = {Akk(m, n)}"); 
}
Console.WriteLine();

// функция Аккермана
int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));
    }
}
