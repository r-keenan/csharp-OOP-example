namespace Csharp_OOP.Models.Characters;

public class Character
{
    private int _healthPoints;
    private int _weight;
    private int _age;

    public int HealthPoints
    {
        get
        {
            return _healthPoints;
        }
        set
        {
            _healthPoints = value;
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
            _weight = value;
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
            _age = value;
        }
    }

    // Default/parameterless constructor is required for the base class
    public Character()
    {
        
    }
    
    public Character(int healthPoints, int weight, int age)
    {
        _healthPoints = healthPoints;
        _weight = weight;
        _age = age;
    }
    
}