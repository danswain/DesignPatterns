namespace Builder
{
    public abstract class CarBuilder
    {
        protected string _make;
        protected string _model;
        protected bool _mp3Player;
        protected string _carBody;
        protected string _colour;
        protected int _numberOfDoors;
        protected string _engineSize;
        protected bool _sunroof;
        protected bool _satNav;
        protected bool _alarm;

        public CarBuilder Make(string make)
        {
            _make = make;
            return this;
        }

        public CarBuilder Model(string model)
        {
            _model = model;
            return this;
        }

        public CarBuilder AddAlarm(bool alarm)
        {
            _alarm = alarm;
            return this;
        }
        public CarBuilder AddSatNav(bool satNav)
        {
            _satNav = satNav;
            return this;
        }
        public CarBuilder AddSunroof(bool sunroof)
        {
            _sunroof = sunroof;
            return this;
        }
        public  CarBuilder Mp3Player(bool mp3Player)
        {
            _mp3Player = mp3Player;
            return this;
        }
        public  CarBuilder CarBody(string carBody)
        {
            _carBody = carBody;
            return this;
        }
        public  CarBuilder PaintColor(string colour)
        {
            _colour = colour;
            return this;
        }
        public  CarBuilder AddDoors(int numberOfDoors)
        {
            _numberOfDoors = numberOfDoors;
            return this;
        }
        public  CarBuilder AddEngine(string engineSize)
        {
            _engineSize = engineSize;
            return this;
        }

        public Car Build()
        {
            return new Car(_make, _model, _mp3Player, _carBody, _colour, _numberOfDoors, _engineSize, _sunroof, _satNav,
                           _alarm);
        }
    }
}