System.Console.WriteLine("Введите координыту точки Х");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координыту точки Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
	System.Console.WriteLine(" В первой координатной четверти");
}
else if (x < 0 && y > 0)
{
	System.Console.WriteLine(" Во второй координатной четверти");
}
else if (x < 0 && y < 0)
{
	System.Console.WriteLine(" В третьей координатной четверти");
}
else if (x > 0 && y < 0)
{
	System.Console.WriteLine(" В четвертой координатной четверти");
}
else
{
	System.Console.WriteLine("Координатную четверть невозможно определить.");
}