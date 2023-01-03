using System.IO;

namespace Retro_Racer
{
    class Program
    {
        static void Main(string[] args) // 128x128 = 16384 total entries
        {
            var counter = 0;
            var lines = File.ReadAllText("input.txt").Split(' ');
            StreamWriter sw = new StreamWriter("output.txt");



            sw.Write("{");

            for (int i = 0; i < lines.Length; i++)
            {
                if (counter == 0) sw.Write("{");
                sw.Write(lines[i]);
                if (counter == 263) { sw.Write("},"); sw.WriteLine(); }
                counter++;
                if (counter == 264) counter = 0;

            }
            sw.Write("}");
            sw.Close();





            // Console.Clear();
            // Console.SetWindowSize(151, 51); // Middle 76, 25
            // Console.SetBufferSize(151, 51);
            // var middle = (76, 25);
            // var trackHandlerC = new trackHandler(trackReference.track1, Console.BufferHeight, Console.BufferWidth);
            // trackHandlerC.drawTrackSection(, 0);
            // var counter = 1;
            // var previousCounter = 0;
            // while (true)
            // {
            //     if (Console.ReadKey().Key == ConsoleKey.Enter) { counter++; previousCounter++; }
            //     if (counter > 16) counter = 1;
            //     if (previousCounter > 16) previousCounter = 1;
            //     RacerSprites.showSprite(middle.Item1 + 3, middle.Item2 + 3, counter, previousCounter);
            // }
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
        private int _x;
        private int _y;
        private int _speed;
        private int _direction;
        private int _maxSpeed { get; set; }
        private int _acceleration;


        public Racer(int startX, int startY)
        {
            _x = startX;
            _y = startY;
            _speed = 0;
            _direction = 0;
            _maxSpeed = 10;
            _acceleration = 0;

        }

        public void accelerate()
        {
            if (_speed < _maxSpeed) _speed++;
        }
        public int X
        {
            get { return _x; }
        }
        public int Y
        {
            get { return _y; }
        }


    }
}