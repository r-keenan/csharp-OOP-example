using Csharp_OOP.Models;

// See https://aka.ms/new-console-template for more information
public class EntryPoint
{
    public static void Main()
    {
        Warrior localWarrior = CreateWarrior(190, 80, "Jeff"); 
        
        Greetings(localWarrior);
    }

    public static Warrior CreateWarrior(int height, int weight, string name) {
        Warrior warrior = new Warrior();
        
        warrior.Height = height;
        warrior.Weight = weight;
        warrior.Name = name;

        Console.WriteLine(warrior.Height);
    
        return warrior;
    }

    public static void Greetings(Warrior warrior)
    {
        Console.WriteLine($"Greetings, {warrior.Name}!");
    }
}



