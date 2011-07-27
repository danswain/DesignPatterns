namespace Builder
{
    public class CarManufacturer
    {        
        public void Build(CarBuilder builder)
        {            
            builder.BuildCarBody();
            builder.AddEngine();
            builder.AddDoors();
            builder.PaintColor();            
        }
    }
}