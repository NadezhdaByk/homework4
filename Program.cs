// выдает все четные числа от 1 до n
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int index = 2;
    while (index <= number)
    {
        Console.WriteLine(index);
        index = index + 2;
    }
}

if (number < 0)
{
    int index = -2;
    while (index >= number)
    {
        Console.WriteLine(index);
        index = index - 2;
    }
}

if (number == 0)
{
   Console.WriteLine("вы ввели ноль");
}

