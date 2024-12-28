namespace Pharmacy;

class Program
{
    static void Main(string[] args)
    {
        Medicament medicament = new Pills("nise", DateOnly.FromDateTime(DateTime.Now.AddDays(180)))
        {
            RecommendedPillsCount = 2, 
            BlocksCount = 4,
            PillForm = PillForm.Circle,
            PillsCountInBlock = 30
        };

        var pharmancy = new Pharmacy(new[] { medicament },
            new TimeOnly(9, 0, 0), new TimeOnly(18, 0, 0));
        
        UseMedicament(medicament);
        
        pharmancy.BuyMedicament("nise", 100);
    }


    public static void UseMedicament(Medicament medicament)
    {
        
    }
}