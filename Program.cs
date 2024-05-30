using System;

public class Rectangle
{
    private double a, b; 

    public double A 
    {
        set
        {
            if (value > 0) a = value;
            else Console.WriteLine("Сторона a не може бути від'ємною або нульовою");
        }
    }

    public double B 
    {
        set
        {
            if (value > 0) b = value;
            else Console.WriteLine("Сторона b не може бути від'ємною або нульовою");
        }
    }

    public bool Correct() 
    {
        return a > 0 && b > 0;
    }

    public double Area() 
    {
        return a * b;
    }

    public double Perimeter() 
    {
        return 2 * (a + b);
    }

    public void Print() 
    {
        Console.WriteLine($"a = {a}, b = {b}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            
            Rectangle rect = new Rectangle();

            
            Console.Write("Введіть значення сторони a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть значення сторони b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            
            rect.A = a;
            rect.B = b;

            
            rect.Print();

            
            if (rect.Correct())
            {
                
                double area = rect.Area();
                double perimeter = rect.Perimeter();

                
                Console.WriteLine($"Площа прямокутника: {area}");
                Console.WriteLine($"Периметр прямокутника: {perimeter}");
            }
            else
            {
                
                Console.WriteLine("Такий прямокутник не існує");
            }
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("Помилка: " + ex.Message);
        }

        Console.ReadKey();
    }
}
