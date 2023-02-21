//Задача 19
//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите любое пятизначнон число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a5= number% 10;
int a1= number/10000;
int a2= number/1000%10;
int a4=number%100/10;
if(a1==a5 && a2==a4)
{
Console.WriteLine("это число палиндром");
}
else
Console.Write("это число не  палиндром");
