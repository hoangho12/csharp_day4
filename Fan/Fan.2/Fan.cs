namespace Fan._2
{
    class Fan
    {
        public const int Slow = 1;
        public const int Medium = 2;
        public const int Fast = 3;

        private int speed;
        private bool on;
        private double radius;
        private string color;

        public Fan()
        {
            speed = Slow;
            on = false;
            radius = 5;
            color = "blue";
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string GetFanInfo()
        {
            if(on)
                return $"Speed: {speed} , Color: {color}, Radius: {radius}, Status: Fan is on";
            else
                return $"Speed: {speed} , Color: {color}, Radius: {radius}, Status: Fan is off";

        }

    }
}
