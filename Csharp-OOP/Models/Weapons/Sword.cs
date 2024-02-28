namespace Csharp_OOP.Models.Weapons;

public class Sword
{
    private int _damage;

    public int Damage
    {
        get
        {
            return this._damage;
        }
        private set
        {
            _damage = value;
        }
    }

    public Sword()
    {
        Damage = 10;
    }
}