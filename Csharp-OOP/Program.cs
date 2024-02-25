using Csharp_OOP.Models;

// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        Warrior localWarrior = CreateWarrior("Jeff",18, 190, 80);

        Greetings(localWarrior);
        
        try
        {
            localWarrior.Age = 12;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        
    }

    public static Warrior CreateWarrior(string name, int age, int height, int weight) {
        Warrior warrior = new Warrior(name, age, height, weight);
        
        Console.WriteLine(warrior.Height);
        Console.WriteLine(warrior.Age);
    
        return warrior;
    }

    public static void Greetings(Warrior warrior)
    {
        Console.WriteLine($"Greetings, {warrior.Name}!");
    }
}



