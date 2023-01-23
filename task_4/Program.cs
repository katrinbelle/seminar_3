/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */ 

int GetDate(string messeng){
    int result=0;
    Console.Write(messeng);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result >0) break;
        else  Console.Write("Введите число: ");
    }
    return result;
}
// int OutDate(int N)
// {

int i = 1;
int table=GetDate("Введите число для вывода таблицы квардратов ->");
while ( i < table )
{
    Console.Write(Math.Pow(i,2)+" ->");
    i++;
}

Console.Write(i*i);
