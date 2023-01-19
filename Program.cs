//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int dayNumber = RedInt("Введите число от 1 до 7: ");
Console.WriteLine("Рабочий день ("dayNumber) ");
int RedInt(string message)
{
    Console.Write(message);
}
string Рабочий день(int a);
{
    if (a > 0 && a < 8)
}
{
    if(a ==7 || a ==6)
}
Console.Write("Под цифрой " + a +" -Выходной");
