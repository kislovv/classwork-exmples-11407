namespace OopPrincipal.Strategy;

public class CityDuck: Duck
{
    public CityDuck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour) : base(quackBehaviour, flyBehaviour)
    {
    }
}