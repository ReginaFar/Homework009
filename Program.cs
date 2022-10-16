//Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N
void Zadacha64()
{
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());
    FindMultiplesOfThree(m, n);
}
void FindMultiplesOfThree(int m, int n)
{
    if (m % 3 == 0)
    {
        Console.WriteLine("Число, кратное трём = " + m);
    }
    m++;
    if (m > n)
    {
        return;
    }
    FindMultiplesOfThree(m, n);
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void Zadacha66()
{
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());
    FindSum(m, n);
}
void FindSum(int m, int n, int sum = 0)
{
    sum = sum + m;
    m++;
    if (m > n)
    {
        Console.WriteLine(sum);
        return;
    }
    FindSum(m, n, sum);
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
void Zadacha68()
{
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());
    int FindAckermanFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return FindAckermanFunction(m - 1, 1);
        }
        if (m > 0 && n > 0)
        {
            return FindAckermanFunction(m - 1, FindAckermanFunction(m, n - 1));
        }
        return FindAckermanFunction(m, n);
    }
    Console.WriteLine($"Функция Аккермана для чисел ({m},{n}) = {FindAckermanFunction(m, n)}");
}
Zadacha64();
Zadacha66();
Zadacha68();
