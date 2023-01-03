using System.IO;

namespace Retro_Racer
{
    class Program
    {
        static void Main(string[] args) // 128x128 = 16384 total entries
        {
            Console.Clear();
            Console.SetWindowSize(151, 51); // Middle 76, 25
            Console.SetBufferSize(151, 51);
            // var middle = (76, 25);

            var trackHandlerC = new trackHandler(trackReference.track1, Console.BufferHeight, Console.BufferWidth);
            var curRacer = new Racer(76, 25);

            // trackHandlerC.drawTrackSection(middle.Item1 - 76, middle.Item2 - 25);

            // var counter = 1;
            // var previousCounter = 0;
            // var spriteCounter = 0;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            curRacer.accelerate();
                            break;
                        case ConsoleKey.DownArrow:
                            curRacer.brake();
                            break;
                        case ConsoleKey.LeftArrow:
                            curRacer.turnLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            curRacer.turnRight();
                            break;

                    }
                }

                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.Write(curRacer.X + " " + curRacer.Y + " " + curRacer.Direction + " " + curRacer.Speed + "         ");




                curRacer.iterateCar();
                // RacerSprites.showSprite(middle.Item1 + 3, middle.Item2 + 3, counter, previousCounter);
            }
        }
    }
    class trackHandler
    {
        public string[,] currentTrack = new string[,] { };
        private int _height;
        private int _width;
        private int _trackHeight;
        private int _trackWidth;
        public trackHandler(string[,] track, int consoleHeight, int consoleWidth)
        {
            currentTrack = track;
            _height = consoleHeight;
            _width = consoleWidth;
            _trackHeight = track.GetLength(0);
            _trackWidth = track.GetLength(1);
        }

        public void drawTrackSection(int x, int y)
        {
            var checkedHeight = 0;//int (int y) => { y + _height > _trackHeight ? y - _trackHeight : _height};
            var checkedWidth = 0;
            if (y + _height > _trackHeight) checkedHeight = y - _trackHeight;
            else checkedHeight = _height;
            if (x + _width > _trackWidth) checkedWidth = x - _trackWidth;
            else checkedWidth = _width;

            for (int i = y; i < y + checkedHeight; i++)
            {
                for (int j = x; j < x + checkedWidth; j++)
                {
                    Console.SetCursorPosition(j, i);
                    // System.Console.Write(currentTrack[i, j]);
                    switch (currentTrack[i, j])
                    {
                        case "Track":
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;
                        case "Grass":
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        case "Wall":
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            break;
                    }
                    System.Console.WriteLine(' ');

                }
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }

    class Racer
    {
        private double _x;
        private double _y;
        private double _speed;
        private int _direction;
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
            RacerSprites.showSprite((int)_x, (int)_y, _direction);
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
                    _y += (_speed * Math.Cos(_direction * (Math.PI / 8)));
                    break;
                case 2:
                    _y += ((_speed * Math.Cos(_direction * (Math.PI / 8))) * 0.75);
                    _x += ((_speed * Math.Sin(_direction * (Math.PI / 8))) * 0.25);
                    break;
                case 3:
                    _y += ((_speed * Math.Cos(_direction * (Math.PI / 8))) * 0.50);
                    _x += ((_speed * Math.Sin(_direction * (Math.PI / 8))) * 0.50);
                    break;
                case 4:
                    _y += ((_speed * Math.Cos(_direction * (Math.PI / 8))) * 0.25);
                    _x += ((_speed * Math.Sin(_direction * (Math.PI / 8))) * 0.75);
                    break;
                case 5:
                    _x += ((_speed * Math.Sin(_direction * (Math.PI / 8))));
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
            }







            RacerSprites.showSprite(76, 25, _direction);
        }

    }
}