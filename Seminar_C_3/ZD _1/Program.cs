Console.Clear();
int DataEntruXY(string str)
{
   Console.Write(str);
   int number = int.Parse(Console.ReadLine());
   return number;
}
void FindQvadrant(int x, int y)
{
    if ((x > 0) && (y > 0)) Console.WriteLine("это первый квадрант");
    if ((x < 0) && (y > 0)) Console.WriteLine("это второрй квадрант");
    if ((x < 0) && (y < 0)) Console.WriteLine("это третий квадрант");
    if ((x > 0) && (y < 0)) Console.WriteLine("это четвертый квадрант");
}

int x = DataEntruXY("введите координаты x = ");

int y = DataEntruXY("введите координаты y = ");

FindQvadrant(x, y);
