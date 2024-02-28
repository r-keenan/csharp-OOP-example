using Csharp_OOP.Models.Weapons;

namespace Csharp_OOP.Models.Characters;

public class Warrior
{
    private string _name;
    private int _age;
    private int _height;
    private int _weight;
    private Sword _swordWeapon;

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
                throw new ArgumentOutOfRangeException(string.Empty, $"The age must be between 18 and 45. The Warrior, {_name}, has an age of {value}.");
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
            if (value > 0)
            {
                _height = value;    
            }
            else
            {
                throw new ArgumentOutOfRangeException(String.Empty, "Height must be greater than 0.");
            }
        }
    }

    public int Weight
    {
        get
        {
            return _weight;
        }
        set
        {
            if (value > 0)
            {
                _weight = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(String.Empty, "Weight must be greater than 0.");
            }
        }
    }

    public Sword SwordWeapon
    {
        get
        {
            return _swordWeapon;
        }
        set
        {
            _swordWeapon = value;
        }
    }

    // Parameterless constructor
    // calls constructor below it and assigns the default values for height and weight
    // it will take the default values from the constructor as well
    public Warrior() : this(170, 70)
    {
    }
    
    // First constructor
    // calling next constructor
    public Warrior(int _height, int _weight) : this(_height, _weight, "Young Warrior", 18)
    {
    }
    
    // Second constructor
    public Warrior(int _height, int _weight, string _name, int _age )
    {
        Name = _name;
        Height = _height;
        Weight = _weight;
        Age = _age;
        SwordWeapon = new Sword();
    }
}