namespace OopPrincipal.Strategy;

public class Duck
{
    public IQuackBehaviour QuackBehaviour { get; set; }
    public IFlyBehaviour FlyBehaviour { get; set; }

    public Duck(IQuackBehaviour quackBehaviour, IFlyBehaviour flyBehaviour)
    {
        QuackBehaviour = quackBehaviour;
        FlyBehaviour = flyBehaviour;
    }
    public void Fly()
    {
        FlyBehaviour.Fly();
    }
    
    public void Quack()
    {
        QuackBehaviour.Quack();
    }
    
    
}