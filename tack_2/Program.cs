/*Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/

int GetDate (string message){
    int result =0;
    Console.Write(message);
    while (true)
    {
if (int.TryParse(Console.ReadLine(),out result) && result >0 && result <5) break;
else Console.WriteLine( "Такой четверти нет , введите четвердь-> \n");
    }
    return result;
}  
    int quarter = GetDate(" Введите четвердь: ");
if (quarter==1) Console.WriteLine("Диапозон "+ quarter+" четверти  х и y равен (0 ,+ ~]");
else if (quarter==2) Console.WriteLine("Диапозон "+ quarter+" четверти  х  равен ( 0 , -~ ] и y равен (0 ,+ ~]");
else if (quarter==3 )Console.WriteLine("Диапозон "+ quarter+" четверти  х и y равен (0 ,- ~]");
else   Console.WriteLine("Диапозон "+ quarter+" четверти  х равен (0 ,+ ~] и y равен (0 ,- ~]");

