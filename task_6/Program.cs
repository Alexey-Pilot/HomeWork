Console.Clear();
Console.Write("Input the number: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
{
  Console.WriteLine($"Number {x} is even");
}
else 
{
  Console.WriteLine($"Nuber {x} is odd");
}