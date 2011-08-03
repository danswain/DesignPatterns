namespace AbstractFactory
{
    internal class FordFocusHatchback : FordFocus
    {
        public override string BodyType
        {
            get { return "Hatchback"; }
        }
    }
}