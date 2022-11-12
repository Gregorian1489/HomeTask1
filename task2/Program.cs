Console.WriteLine("Введите первое число");
int namber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int namber2 = Convert.ToInt32(Console.ReadLine());

if (namber1 > namber2)
{
    Console.WriteLine($"Max = {namber1}, Min = {namber2}");
}
else if (namber2 > namber1)
{
    Console.WriteLine($"Max = {namber2}, Min = {namber1}");
}
else if (namber2 == namber1)
{
    Console.WriteLine("Числа равны");
}