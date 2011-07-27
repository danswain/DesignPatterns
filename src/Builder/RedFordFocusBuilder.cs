namespace Builder
{
    public class RedFordFocusBuilder : CarBuilder
    {
        public override void BuildCarBody()
        {
            car.CarBody = "Focus";
        }

        public override void PaintColor()
        {
            car.Color = "Red";
        }

        public override void AddDoors()
        {
            car.Doors = 5;
        }

        public override void AddEngine()
        {
            car.Engine = "2.0";
        }
    }
}