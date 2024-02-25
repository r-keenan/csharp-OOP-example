namespace Csharp_OOP.Models;

public class Warrior
{
    private string _name;
    private int _height;
    private int _weight;
    
    public string Name { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    public Warrior(int _height, int _weight, string _name)
    {
        Name = _name;
        Height = _height;
        Weight = _weight;
    }
}