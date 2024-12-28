namespace Pharmacy;

public class Pharmacy
{
    private Medicament[] _medicament;

    public string Name { get; init; }
    public TimeOnly StartWorkTime { get; }
    public TimeOnly EndWorkTime { get; }
    public Pharmacy(Medicament[] medicament, TimeOnly startWorkTime, TimeOnly endWorkTime)
    {
        _medicament = medicament;
        StartWorkTime = startWorkTime;
        EndWorkTime = endWorkTime;
    }

    public (decimal change, Medicament medicament) BuyMedicament(string name, decimal price)
    {
        /*
        Medicament? medicament = null;
        foreach (var m in _medicament)
        {
            if (m.Name == name)
            {
                medicament = m;
                break;
            }
        }
        */
        throw new NotImplementedException();
    }

    private bool CheckExpiredAt(Medicament medicament)
    {
        throw new NotImplementedException();
    }
}