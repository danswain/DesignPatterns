namespace AbstractFactory
{
    internal class FordFocusConvertible : FordFocus
    {
        public override string BodyType
        {
            get { return "Convertible"; }
        }
    }
}