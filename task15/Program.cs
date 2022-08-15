//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели (например: 1 - понедельник... 7 - воскресенье):");
int number = Convert.ToInt32(Console.ReadLine());

if (number<1 || number>7)
{
    Console.WriteLine("Error.Введена неверная цифра.");
}
else if (number>5)
{
    Console.WriteLine("Да, это выходной день"); 
}  
else if (number<=5)
{
Console.WriteLine("Нет, это не выходной день");
}