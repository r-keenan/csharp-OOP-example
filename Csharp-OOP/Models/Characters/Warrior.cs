namespace Csharp_OOP.Models;

public class Warrior
{
    private string _name;
    private int _age;
    private int _height;
    private int _weight;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value >= 18 && value <= 45)
            {
                _age = value;    
            }
            else
            {
                Console.WriteLine($"The age must be between 18 and 45. The Warrior, {_name}, has an age of {value}.");
            }
            
        }
    }

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
    public Warrior(string _name, int _age, int _height, int _weight)
    {
        Name = _name;
        Age = _age;
        Height = _height;
        Weight = _weight;
    }
}