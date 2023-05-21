// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные от 1 до N

int count = 1;
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
    count++;
}
