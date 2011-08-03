namespace AbstractFactory
{
    public interface ICar
    {
        string Make { get;  }
        string Model { get;  }
        string BodyType { get; }
        void Drive();
    }
}