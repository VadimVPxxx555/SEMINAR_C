// Напишите программу, которая принимает на вход число 
// и выдает количество цифр в числе.
Console.Clear();
int DataSchet(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Schetnumb(int numberSchet)
{
  //int nunb = numberSchet;
  int i = 0;
  for(i = 0; numberSchet > 0; i++)
  {
    numberSchet = numberSchet / 10;
  }
  return i;
}

int numberSchet = DataSchet("Введите число ");

int i = Schetnumb(numberSchet);

Console.WriteLine(i);