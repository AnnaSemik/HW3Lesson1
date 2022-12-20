Console.WriteLine ("Введите число");
string num1=Console.ReadLine();
int number1=int.Parse(num1);
if (number1%2==0)
Console.Write ("Число "+number1+" - четное");
else Console.Write ("Число "+number1+" - нечетное");