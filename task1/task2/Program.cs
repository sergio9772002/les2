/* Напишите программу, которая принимает на вход три числа и выдает максимальное
из этих чисел.
*/
int userNumber1 = new int();
int userNumber2 = new int();
int userNumber3 = new int();
Console.WriteLine("Введите число");
userNumber1 = Convert.ToInt32(Console.ReadLine());
userNumber2 = Convert.ToInt32(Console.ReadLine());
userNumber3 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 > userNumber2)
{
    if (userNumber1 > userNumber3)
    {
      Console.Write("-> ");
      Console.Write(userNumber1);  
    }
    else
    {
      Console.Write("-> ");
      Console.Write(userNumber3);
    }
}
else
{
   if (userNumber2 > userNumber3) 
   {
      Console.Write("-> ");
      Console.Write(userNumber2);
   }
   else
   {
      Console.Write("-> ");
      Console.Write(userNumber3);
   }
}