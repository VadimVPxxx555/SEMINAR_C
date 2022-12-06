Console.Clear();
Console.Write("введите число ");
int number = int.Parse(Console.ReadLine());

//if ((number % 7 == 0) && (number % 23 == 0))

if (number % 7 == 0 && number % 23 == 0)
{
    Console.Write($"{number} -> кратно 7 и 23");
}
else
{
    Console.Write($"{number} -> не кратно 7 и 23");
}