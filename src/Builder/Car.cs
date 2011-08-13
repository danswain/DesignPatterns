namespace Builder
{
    public class Car
    {


        private string _make;
        private string _model;
        private bool _mp3Player;
        private string _carBody;
        private string _colour;
        private int _numberOfDoors;
        private string _engineSize;
        private bool _sunroof;
        private bool _satNav;
        private bool _alarm;

        public Car(string make,string model,bool mp3Player,string carBody,string colour,int numberOfDoors,string engineSize,bool sunroof,bool satNav,bool alarm)
        {
            _make = make;
            _model = model;
            _mp3Player = mp3Player;
            _carBody = carBody;
            _colour = colour;
            _numberOfDoors = numberOfDoors;
            _engineSize = engineSize;
            _sunroof = sunroof;
            _satNav = satNav;
            _alarm = alarm;
        }

        public string Make
        {
            get { return _make; }
        }

        public string Model
        {
            get { return _model; }
        }

        public bool Mp3Player
        {
            get { return _mp3Player; }
        }

        public string CarBody
        {
            get { return _carBody; }
        }

        public string Colour
        {
            get { return _colour; }
        }

        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
        }

        public string EngineSize
        {
            get { return _engineSize; }
        }

        public bool Sunroof
        {
            get { return _sunroof; }
        }

        public bool SatNav
        {
            get { return _satNav; }
        }

        public bool Alarm
        {
            get { return _alarm; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Make,Model,CarBody,EngineSize);
        }
    }
}