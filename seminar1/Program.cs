int i = 0;
int y = 0;

if (int.TryParse(Console.ReadLine(), out i) && int.TryParse(Console.ReadLine(), out y))
{
  if (i%y == 0)
  {
    Console.WriteLine("Yes");
  }
  else
  {
    Console.WriteLine("No");
  }
}
else
{
Console.WriteLine("OOps");
}