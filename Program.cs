public class Program {
    public static void Main (string[] args) {
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();
        Console.Write("Hi " + name + ", how is your day? ");
        string? day = Console.ReadLine();
        if (day == "good") {
            Console.WriteLine("Nice, my day was good too.");
        }
        if (day == "Good") {
            Console.WriteLine("Nice, my day was good too.");
        }
        if (day == "bad") {
            Console.WriteLine("That sucks, hope it gets better.");
        }
        if (day == "Bad") {
            Console.WriteLine("That sucks, hope it gets better.");
        }
        //end of code//
        Console.WriteLine("\nPress Any Key To Close");
        Console.ReadKey();
    }
}