using System;
class Cube
{
    private double edge; 
    public double Edge
    {
        get { return edge; }
        set
        {
            if (value > 0)
                edge = value;
            else
                Console.WriteLine("Ребро куба має бути позитивним числом.");
        }
    }
    public bool Correct()
    {
        return edge > 0;
    }
    public double Area()
    {
        if (Correct())
            return 6 * edge * edge;
        else
            return 0;
    }
    public double Volume()
    {
        if (Correct())
            return edge * edge * edge;
        else
            return 0;
    }
    public void Print()
    {
        Console.WriteLine($"Ребро куба: {edge}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Cube cube = new Cube();
            Console.Write("Введіть довжину ребра куба: ");
            double inputEdge = Convert.ToDouble(Console.ReadLine());
            cube.Edge = inputEdge;         
            cube.Print();          
            if (cube.Correct())
            {           
                Console.WriteLine($"Площа поверхні куба: {cube.Area()}");
                Console.WriteLine($"Об'єм куба: {cube.Volume()}");
            }
            else
            {
                Console.WriteLine("Об'єкт куба некоректний.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}
