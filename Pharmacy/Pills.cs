namespace Pharmacy;

public class Pills: Medicament
{
    public required uint BlocksCount { get; init; }
    public required uint PillsCountInBlock { get; init; }
    public required uint RecommendedPillsCount { get; init; }

    public required PillForm PillForm { get; init; }
    
    private uint _pillsCount;
    
    public Pills(string name, DateOnly expireDate) : base(name, expireDate)
    {
        _pillsCount = PillsCountInBlock * BlocksCount;
        TypeOfUse = TypeOfUse.Oral;
        Illness = Illness.Head;
        Cost = 100;
    }

    public override void Use()
    {
        throw new NotImplementedException();
    }
    
}