// Напишите программу, которая на вход принимает три числа 
// и выдает максимальное из этих чисел

Console.WriteLine("Введите три числа:");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write ("Максимальное число ");
Console.WriteLine (max);
