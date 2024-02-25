using Csharp_OOP.Models;

// See https://aka.ms/new-console-template for more information
public class EntryPoint
{
    static void Main()
    {
        CreateWarrior(190, 80);    
    }

    static Warrior CreateWarrior(int height, int weight) {
        Warrior warrior = new Warrior();
        warrior.Height = height;
        warrior.Weight = weight;

        Console.WriteLine(warrior.Height);
    
        return warrior;
    }
}



