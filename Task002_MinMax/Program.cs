// Напишите программу, которая на вход принимает два числа 
// и выдает, какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write ("max = ");
    Console.WriteLine (numberA);
    Console.Write ("min = ");
    Console.WriteLine (numberB);
}
else
{
    Console.Write ("max = ");
    Console.WriteLine (numberB);
    Console.Write ("min = ");
    Console.WriteLine (numberA);
}