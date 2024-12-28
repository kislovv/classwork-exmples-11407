namespace OopPrincipal.Strategy;

public class RubberDuck: Duck
{
    public RubberDuck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour) : base(quackBehaviour, flyBehaviour)
    {
    }
}