// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumRec(int n, int m)
{
    if (m < n) return string.Empty;
    else return $"{m} " + NumRec(n, m - 1);
}

Console.WriteLine(NumRec(1, 8));