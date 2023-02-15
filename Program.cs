// Напишите программу, которая на вход принимает два 
// числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число  ");
string inputValue1 = Console.ReadLine();

Console.WriteLine("Введите второе число  ");
string inputValue2 = Console.ReadLine();

int value1 = Convert.ToInt32(inputValue1);
int value2 = Convert.ToInt32(inputValue2);

if (value1 > value2)
{
    System.Console.WriteLine ($"Число {value1} больше {value2}");
}
else
{
     System.Console.WriteLine ($"Число {value1} меньше  {value2}");
}
/   