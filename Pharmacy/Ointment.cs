namespace Pharmacy;

public class Ointment:Medicament
{
    public Ointment(string name, DateOnly expireDate) : base(name, expireDate)
    {
    }

    public override void Use()
    {
        throw new NotImplementedException();
    }
}