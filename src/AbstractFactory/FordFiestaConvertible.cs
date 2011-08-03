namespace AbstractFactory
{
    public class FordFiestaConvertible : FordFiesta
    {
        public override string BodyType
        {
            get { return "Convertible"; }
        }
    }
}