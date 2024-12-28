namespace OopPrincipal.Strategy;

public class WildDuck: Duck
{
    public WildDuck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour) : base(quackBehaviour, flyBehaviour)
    {
    }
}