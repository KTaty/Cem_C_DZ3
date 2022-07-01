// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите N =  ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int cube_i = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write(cube_i);
    Console.Write(' ');
}