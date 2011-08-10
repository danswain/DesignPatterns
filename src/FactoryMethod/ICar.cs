namespace FactoryMethod
{
    public interface ICar
    {
        string Make { get;  }
        string Model { get;  }
        void Drive();
    }
}