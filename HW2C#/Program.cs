/*
//задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Deсade(int num)
{
    
 int a=(num / 10)%10; 

 return a;
}
Console.WriteLine("Введите трехзначное число");
int num=Convert.ToInt32(Console.ReadLine());
int res=Deсade(num);
Console.WriteLine($"Вторая цифра из введенного трехзначного числа {res}");
*/
/*
//Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Week(int num)

{ bool result;
    if (num<6) 
   {result=(false);}
else result=true;
return result;
}
Console.WriteLine("Input number of the weekday ");
int num = Convert.ToInt32(Console.ReadLine());
bool res=Week(num);
Console.WriteLine($"It's {res}, that {num} day of the week is a weekend");
*/

/*

//задача 2. Вариант 1. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdDigit(int num)
{
int res;
if (num<100&&num>-100) 
    {Console.WriteLine("Число состоит менее чем из трех цифр");}
else 
    {while (num>999||num<-999) {num=num/10;}  
    res=Math.Abs(num%10);
    Console.WriteLine($"Третья цифра введеного числа равна {res}");}
}

Console.WriteLine("Ввведите целое число");
int num = Convert.ToInt32(Console.ReadLine());

ThirdDigit(num);

*/
/*

// Задача 2. Вариант 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void XDigit(int num, int length)
{
    int x=3;
   int step=Convert.ToInt32(Math.Pow(10,length-x));
if (length>=x)
    {int res= num/step%10;
Console.WriteLine($"{x} цифра введеного числа равна {res}");}
else
    {Console.WriteLine($"Число состоит менее чем из {x} цифр");}
}

Console.WriteLine("Ввведите целое положительное число");
int num = Convert.ToInt32(Console.ReadLine());
string str =Convert.ToString(num);
int length=str.Length;

XDigit(num,length);

*/
