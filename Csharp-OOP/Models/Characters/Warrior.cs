namespace Csharp_OOP.Models;

public class Warrior
{
    private string _name;
    private int _height;
    private int _weight;
    
    public string Name { get; set; }

    // Read-only when there is no longer an option to set
    public int Height
    {
        // Read
        get
        {
            return _height;
        }
        // Write
        set
        {
            _height = value;
        }
    }

    public int Weight { get; set; }

    // Constructor
    public Warrior(int _height, int _weight, string _name)
    {
        Name = _name;
        Height = _height;
        Weight = _weight;
    }
}