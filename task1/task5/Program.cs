/* Напишите программу, которая на вход принимает два числа и выдает, какое
число большее, а какое меньшее.
*/
int userNumber1 = new int();
int userNumber2 = new int();
Console.WriteLine("Введите число");
userNumber1 = Convert.ToInt32(Console.ReadLine());
userNumber2 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 > userNumber2)
{
    Console.Write(userNumber1);
    Console.WriteLine(" - наибольшее");
    Console.Write(userNumber2);
    Console.Write(" - наименьшее");
}
else
{
    Console.Write(userNumber2);
    Console.WriteLine(" - наибольшее");
    Console.Write(userNumber1);
    Console.Write(" - наименьшее");
}
