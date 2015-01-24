using System;
//Write an expression that checks for given point (x, y) if it is within the 
//circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter X coordinate of Point: "); //input X of our Point 
        float xCoordinate = float.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate of Point: "); //input Y of our Point
        float yCoordinate = float.Parse(Console.ReadLine());
        float a;            //страна а от правоъгълният триъгълник чрез който намираме разстоянието от точката до центъра
        float b;            //страна а от правоъгълният триъгълник чрез който намираме разстоянието от точката до центъра
        double c;           //разстоянието от точката до центъра на окръжността
        if (xCoordinate < 0)  
        {
            a = Math.Abs(xCoordinate) + 1;
        }
        else
        {
            a = Math.Abs(1 - xCoordinate);
        }
        if (yCoordinate < 0)
        {
            b = Math.Abs(yCoordinate) + 1;
        }
        else
        {
            b = Math.Abs(1 - yCoordinate);
        }
        c = Math.Sqrt(a * a + b * b);
        if (c <= 1.5 && yCoordinate > 1) //защото сечението на правоъгълника и окръжността е полуокръжност от y <= 1( Или горната страна на правоъгълника
            //съдържа съдържа в себе си диаметър успореден на абсцисата, а ние искаме там където не е сечение на двете фигури)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}   