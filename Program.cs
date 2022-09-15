public class Program 
{
    public static void Main() 
    {
        Console.WriteLine("Skriv in bredden: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Skriv in höjden: ");
        int height = int.Parse(Console.ReadLine());

        Triangle t = new Triangle (width, height);
        Rectangle r = new Rectangle (width, height);

        Console.WriteLine("Arean på rektangeln är " + r.Area() + "m");
    }
}