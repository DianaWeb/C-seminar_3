System.Console.WriteLine("Введите номер четверти от 1 до 4: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
	System.Console.WriteLine("Диапазон координат: x > 0 && y > 0");
}
else if (num == 2)
{
	System.Console.WriteLine(" Диапазон координат: x < 0 && y > 0");
}
else if (num == 3)
{
	System.Console.WriteLine(" Диапазон координат: x < 0 && y < 0");
}
else if (num == 4)
{
	System.Console.WriteLine(" Диапазон координат: x > 0 && y < 0");
}
else
{
	System.Console.WriteLine("Диапазон невозможно определить.");
}
