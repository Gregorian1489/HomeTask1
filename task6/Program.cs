﻿Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if ((number%2 == 0) || (number == 0))
{
    Console.WriteLine("Это число - чётное");
}
else
{
    Console.WriteLine("Это число - нечётное");
}
