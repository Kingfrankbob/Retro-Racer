namespace Retro_Racer
{
    class Racer
    {
        private double _x;
        private double _y;
        private double _speed;
        private int _direction;
        private int _prevDir;
        private int _maxSpeed { get; set; }
        private double _acceleration;


        public Racer(int startX, int startY)
        {
            _x = startX;
            _y = startY;
            _speed = 0;
            _direction = 1;
            _maxSpeed = 10;
            _acceleration = 0.03;

        }

        public void accelerate()
        {
            if (_speed < _maxSpeed) _speed++;
        }

        public void turnLeft()
        {
            if (_direction == 1) _direction = 16;
            else _direction--;
        }

        public void turnRight()
        {
            if (_direction == 16) _direction = 1;
            else _direction++;
        }

        public void brake()
        {
            if (_speed > (_maxSpeed * -1)) _speed--;
        }

        public void draw()
        {
            RacerSprites.showSprite(76, 25, _direction);
        }

        public double X
        {
            get { return _x; }
        }

        public double Y
        {
            get { return _y; }
        }

        public double Speed
        {
            get { return _speed; }
        }

        public int Direction
        {
            get { return _direction; }
        }

        public void iterateCar()
        {

            var dir = _direction;

            switch (_direction)
            {
                case 1:
                    _y += (_speed * Math.Cos(_direction));
                    break;
                case 2:
                    _y += ((_speed * Math.Cos(_direction)) * 0.75);
                    _x += ((_speed * Math.Sin(_direction)) * 0.25);
                    break;
                case 3:
                    _y += ((_speed * Math.Cos(_direction)) * 0.50);
                    _x += ((_speed * Math.Sin(_direction)) * 0.50);
                    break;
                case 4:
                    _y += ((_speed * Math.Cos(_direction)) * 0.25);
                    _x += ((_speed * Math.Sin(_direction)) * 0.75);
                    break;
                case 5:
                    _x += (_speed * Math.Sin(_direction));
                    break;
                case 6:
                    _y -= ((_speed * Math.Cos(_direction)) * 0.25);
                    _x += ((_speed * Math.Sin(_direction)) * 0.75);
                    break;
                case 7:
                    _y -= ((_speed * Math.Cos(_direction)) * 0.50);
                    _x += ((_speed * Math.Sin(_direction)) * 0.50);
                    break;
                case 8:
                    _y -= ((_speed * Math.Cos(_direction)) * 0.75);
                    _x += ((_speed * Math.Sin(_direction)) * 0.25);
                    break;
                case 9:
                    _y -= (_speed * Math.Cos(_direction));
                    break;
                case 10:
                    _y -= ((_speed * Math.Cos(_direction)) * 0.75);
                    _x -= ((_speed * Math.Sin(_direction)) * 0.25);
                    break;
                case 11:
                    _y -= ((_speed * Math.Cos(_direction)) * 0.50);
                    _x -= ((_speed * Math.Sin(_direction)) * 0.50);
                    break;
                case 12:
                    _y -= ((_speed * Math.Cos(_direction)) * 0.25);
                    _x -= ((_speed * Math.Sin(_direction)) * 0.75);
                    break;
                case 13:
                    _x -= ((_speed * Math.Sin(_direction)) * 0.75);
                    break;
                case 14:
                    _y += ((_speed * Math.Cos(_direction)) * 0.25);
                    _x -= ((_speed * Math.Sin(_direction)) * 0.75);
                    break;
                case 15:
                    _y += ((_speed * Math.Cos(_direction)) * 0.50);
                    _x -= ((_speed * Math.Sin(_direction)) * 0.50);
                    break;
                case 16:
                    _y += ((_speed * Math.Cos(_direction)) * 0.75);
                    _x -= ((_speed * Math.Sin(_direction)) * 0.25);
                    break;
            }




            if (_direction != _prevDir) RacerSprites.showSprite(76, 25, _direction);

            _prevDir = _direction;

        }
        public void crash()
        {
            Console.Clear();
            System.Console.WriteLine("CRASH!");
        }

    }
}