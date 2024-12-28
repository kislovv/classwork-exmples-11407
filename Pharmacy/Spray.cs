namespace Pharmacy;

public class Spray : Medicament
{
    public Spray(string name, DateOnly expireDate) : base(name, expireDate)
    {
    }

    public override void Use()
    {
        throw new NotImplementedException();
    }
}