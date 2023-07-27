class Ammo
{
    public Ammo(string typeOfAmmo)
    {
        TypeOfAmmo = typeOfAmmo;
    }
    public string TypeOfAmmo { get; }

    public override string ToString() => $"Type of Ammo is {TypeOfAmmo}";
}