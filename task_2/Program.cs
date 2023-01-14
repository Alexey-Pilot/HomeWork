Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
  Console.Write($"Максимальное число: {a} \nМинимальное чило: {b}");
}
else if (b > a)
{
Console.Write($"Максимальное число: {b} \nМинимальное чило: {a}");
}
else 
{
  Console.Write("Числа равны");
}