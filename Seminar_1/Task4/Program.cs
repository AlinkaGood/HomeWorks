﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4/ 8 -> 2, 4, 6, 8

int n = 1;
int N = 8;

while (n <= N)
{
    if (n % 2 == 0)
        Console.Write(n + ", ");
    n = n + 1;
}