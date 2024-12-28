namespace OopPrincipal;

public static class CurrencyConverterExt
{
    public static string PluralizeRubles(this int amount)
    {
        if (amount % 10 == 1 && amount % 100 != 11)
        {
            return $"{amount} рубль";
        }
        if (amount % 10 > 1 && amount % 10 < 5 &&
            amount % 100 > 11 && amount % 100 < 15)
        {
            return $"{amount} рубля";
        }
        
        return $"{amount} рублей";
    }
}