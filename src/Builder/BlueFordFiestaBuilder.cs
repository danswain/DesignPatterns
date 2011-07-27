namespace Builder
{
    public class BlueFordFiestaBuilder : CarBuilder
    {
        public override void BuildCarBody()
        {
            car.CarBody = "Fiesta";
        }

        public override void PaintColor()
        {
            car.Color = "Blue";
        }

        public override void AddDoors()
        {
            car.Doors = 3;
        }

        public override void AddEngine()
        {
            car.Engine = "1.1";
        }
    }
}