using Csharp_OOP.Models.Characters;

// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        Warrior firstWarrior = CreateFirstWarrior();
        
        Warrior secondWarrior = CreateSecondWarrior("Jeff",35, 190, 80);
        
        Warrior thirdWarrior = CreateThirdWarrior(170, 70);

        Greetings(firstWarrior);
        
        try
        {
            firstWarrior.Age = 38;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static Warrior CreateFirstWarrior()
    {
        Warrior warrior = new Warrior();

        Console.WriteLine("Created first warrior");

        return warrior;
    }
    
    public static Warrior CreateSecondWarrior(string name, int age, int height, int weight) {
        Warrior warrior = new Warrior(height, weight, name, age);
        
        Console.WriteLine(warrior.Height);
        Console.WriteLine(warrior.Age);
        Console.WriteLine(warrior.SwordWeapon.Damage);

        Console.WriteLine("Created second warrior");
    
        return warrior;
    }

    public static Warrior CreateThirdWarrior(int height, int weight)
    {
        Warrior warrior = new Warrior(height, weight);

        Console.WriteLine("Created third warrior");
        
        return warrior;
    }

    public static void Greetings(Warrior warrior)
    {
        Console.WriteLine($"Greetings, {warrior.Name}!");
    }
}



