/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

int GetDate(string messeng)
{
    int result =0;
    Console.WriteLine(messeng);
    while(true)
    {
if (int.TryParse(Console.ReadLine(), out result)) break;
else Console.Write( "Ввели не число для точек, пожалуйста, введите точку");
    }
    return result;
}
double GetDistation(int ax, int ay, int bx, int by)
{ double result=Math.Sqrt(Math.Pow(bx - ax,2) +Math.Pow(by- ay,2));


    return result;
}
int coordinate_ax = GetDate("Введите первую точку  для х->");
int coordinate_bx = GetDate("Введите вторую точку  для х->");
int coordinate_ay = GetDate("Введите первую точку для y->");
int coordinate_by = GetDate("Введите вторую точку для y->");
double dastation = GetDistation(coordinate_ax,coordinate_ay,coordinate_bx,coordinate_by);
Console.Write("Расстояние между точками ("+ coordinate_ax+ " ,"+ coordinate_bx+" ) и ("+ coordinate_ay+ " ,"+ coordinate_by+" равно "+dastation);