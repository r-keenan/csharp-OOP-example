using Csharp_OOP.Models.Characters;

// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        Warrior localWarrior = CreateWarrior("Jeff",35, 190, 80);
        Warrior youngWarrior = CreateYoungWarrior(170, 70);

        Greetings(localWarrior);
        
        try
        {
            localWarrior.Age = 38;
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
        Console.WriteLine(warrior.SwordWeapon.Damage);
    
        return warrior;
    }

    public static Warrior CreateYoungWarrior(int height, int weight)
    {
        Warrior warrior = new Warrior(height, weight);

        Console.WriteLine("Young warrior created");
        
        return warrior;
    }

    public static void Greetings(Warrior warrior)
    {
        Console.WriteLine($"Greetings, {warrior.Name}!");
    }
}



