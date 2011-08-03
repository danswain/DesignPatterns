namespace AbstractFactory
{
    internal abstract class FordFocus : FordCar
    {
        public override string Model
        {
            get { return "Focus"; }
        }
    }
}