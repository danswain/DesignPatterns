namespace Builder
{
    public class Car
    {
        public string CarBody { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public string Engine { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} door Ford {2} {3} litre", Color, Doors, CarBody, Engine);
        }
    }
}