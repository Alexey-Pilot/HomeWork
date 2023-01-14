Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int nMax = a;
if (b > nMax)
{  
  nMax = b;
}
else if (c > nMax)
{  
  nMax = c;
}
int x = 0; // счетчик со списками и циклом for было бы бысрее, но еще не проходили
if (a == nMax)
{
  x ++;
}
if (b == nMax)
{
  x ++;
}
if (c == nMax)
{
  x ++;
}
if (x == 1)
{
  Console.WriteLine($"Наибольшее число: {nMax}");
}
else if (x == 3)
{
  Console.WriteLine("Числа равны");
}
else
{
  Console.WriteLine($"Два наибольших числа равны: {nMax}");
}