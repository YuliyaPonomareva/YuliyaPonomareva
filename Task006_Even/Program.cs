// // Напишите программу, которая на вход принимает число 
// и выдает, является ли число чётным

Console.Write ("Число ");
int number = new Random().Next(-100,100);
Console.Write (number + " ");
if (number % 2 == 0)
{
    Console.Write ("Чётное");
}
else
{
    Console.Write ("Нечётное");
}
