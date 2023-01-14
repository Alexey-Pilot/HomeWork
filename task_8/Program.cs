Console.Clear();
Console.Write("Insert the number: ");
int x = Convert.ToInt32(Console.ReadLine());
int n = 2;
while (n <= x)
{
  Console.Write($"{n} ");
  n += 2;
}