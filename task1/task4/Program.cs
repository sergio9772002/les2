/* Напишите программу, которая на вход принимает число (N), а на
выходе показывает все четные числа от 1 до N.
*/
int userNumber1 = new int();
Console.WriteLine("Введите число");
userNumber1 = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= userNumber1)
{
    Console.WriteLine(i);
    i = i + 2;
}


