namespace Pharmacy;

public abstract class Medicament : IUsable
{
    protected Medicament(string name, DateOnly expireDate)
    {
        Name = name;
        ExpireDate = expireDate;
    }

    public string Name { get; }
    public DateOnly ExpireDate { get; }
    public decimal Cost { get; protected set; }
    public Illness Illness { get; protected set; }
    public TypeOfUse TypeOfUse { get; protected set; }

    public abstract void Use();
}