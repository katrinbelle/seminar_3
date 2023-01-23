/* написать программу , которая принимает на вход  координаты точки (x,y), 
причем х не равен 0 и y не равно 0, и выдает номер ч
етверти плоскости ,в которой находится точка. */




// void TempFunction(int x)
// {
//     x*=100;
   
// }
// void AnotherTempFunction(MyClass item)
// {
//     item.X =item.X * 1000;
// }
// // int numberSecond=12;
// // TempFunction(numberSecond);
// var item =new MyClass{X=10};
// AnotherTempFunction(item);
// Console.Write(item.X);
// class MyClass
// {
//     public int X{get;set;}
// }
int GetNumber( string message)
{int result =0;
    Console.Write(message);
    while(true) 
    if (int.TryParse(Console.ReadLine(), out result) && result !=0) break;
    else Console.WriteLine("Ввели не число или не правильное число. Пожалуйста, повторите ввод: \n");
    return result;
}
int GetQuarter(int x, int y)
{
if (x>0 && y >0 ) return 1;
else if (x<0 && y >0 ) return 2;
else if (x<0 && y <0 ) return 3;
else   return 4;
}
int x = GetNumber(" Введите координату Х ->");
int y = GetNumber(" Введите координату Y ->");
int result = GetQuarter(x,y);
 Console.WriteLine("Это " +result +" четверть");