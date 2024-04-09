
/// <summary>
/// This class represents a Axe. An Axe is 
/// considered to be a weapon.
/// </summary>
public class Axe : Weapon
{
    public const int InitialAxeMinDamage = 20;
    public const int InitialAxeMaxDamage = 50;
    private const int _damageDropper = 3;

    #region Constructor
    public Axe(string description)
        : base(description, InitialAxeMinDamage, InitialAxeMaxDamage)
    {
        MinDamage = InitialAxeMinDamage;
        MaxDamage = InitialAxeMaxDamage;
    }
    #endregion

    public int DamageFromAxe()
    {
        MinDamage -= MinDamage <= 0 
            ? 0 
            : _damageDropper;
        MaxDamage -= MaxDamage <= 0 
            ? 0 
            : _damageDropper;
        return CalculateDamage();
    }

    public void Sharpen()
    {
        MinDamage = InitialAxeMinDamage;
        MaxDamage = InitialAxeMaxDamage;
    }
}