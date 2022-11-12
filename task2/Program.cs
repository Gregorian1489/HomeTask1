Console.WriteLine("Введите первое число");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namber2 = Convert.ToInt32(Console.ReadLine());

if (namber1 > namber2)
{
    Console.WriteLine("Первое число больше");
}
else if (namber2 > namber1)
{
    Console.WriteLine("Второе число больше");
}
else if (namber2 == namber1)
{
    Console.WriteLine("Числа равны");
}