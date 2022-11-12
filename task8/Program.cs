Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = 0;

while (number1 < number-1)
{
    number1 =  number1+2;
    Console.Write($"{number1} ");
} 
if (number <= 0)
{
    Console.WriteLine("По условиям задачи нужно только положительное число");
}