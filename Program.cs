public class Program{
    public static void Main(string[] args){
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();
        Console.WriteLine("Hi " + name);
        Console.WriteLine("\nPress Any Key To Close");
        Console.ReadKey();
    }
}