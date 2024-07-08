namespace TypesDemoCSharp_49;

class Program
{
    static void Main(string[] args)
    {
        //This is a comment
        
        //Variables
        
        //type - name - value
        
        //Word types

        string sethsName = "Seth";

        char middleInitial = 'S';

        //Number types

        int sethsAge = 30;

        double average = 97.5;

        decimal money = 500.00m;
        
        //Fact type

        bool hasMoney = true;
        
        //Value and Reference types section
        
        //Value types

        int a = 1;
        int b = a;

        a = 500;

        Console.WriteLine(a);
        Console.WriteLine(b);
        
        //Reference types

        Point p1 = new Point();

        p1.X = 1;

        Point p2 = p1;

        p2.X = 500;

        Console.WriteLine(p1.X);
        Console.WriteLine(p2.X);
    }
}