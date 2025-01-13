namespace unity_labs;

public class CastingOperator
{
    public static void Print()
    {
        const double PI = 3.14;
        int number = 0;
        number = (int)PI;
        
        Console.WriteLine("PI(3.14)를 int로 형변환 : {0}", number);
    }
}