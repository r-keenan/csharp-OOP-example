using Csharp_OOP.Models;

// See https://aka.ms/new-console-template for more information
public class EntryPoint
{
    public static void Main()
    {
        Warrior localWarrior = CreateWarrior("Jeff",190, 80); 
        
        Greetings(localWarrior);
    }

    public static Warrior CreateWarrior(string name, int height, int weight) {
        Warrior warrior = new Warrior(height, weight, name);
        
        Console.WriteLine(warrior.Height);
    
        return warrior;
    }

    public static void Greetings(Warrior warrior)
    {
        Console.WriteLine($"Greetings, {warrior.Name}!");
    }
}



