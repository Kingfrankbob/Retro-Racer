namespace Retro_Racer
{
    class trackHandler
    {
        public string[,] currentTrack = new string[,] { };
        public string[,] currentShownTrack = trackReference.bufferStart;
        public string[,] previouShownTrack = trackReference.bufferStart;
        private int _height;
        private int _width;
        private int _trackHeight;
        private int _trackWidth;
        private int _cMidX;
        private int _cMidY;
        public trackHandler(string[,] track, int consoleHeight, int consoleWidth, int consoleMidX, int consoleMidY)
        {
            currentTrack = track;
            System.Console.WriteLine("Track Height: " + track.GetLength(0) + " Track Width: " + track.GetLength(1));
            _height = consoleHeight;
            _width = consoleWidth;
            _trackHeight = track.GetLength(0);
            _trackWidth = track.GetLength(1);
            _cMidX = consoleMidX;
            _cMidY = consoleMidY;
        }

        public void drawTrackSection(int x, int y, int midx, int midy)
        {
            // var checkedHeight = 0; //int (int y) => { y + _height > _trackHeight ? y - _trackHeight : _height};
            // var checkedWidth = 0;
            // if (y + _height > _trackHeight) checkedHeight = y - _trackHeight;
            // else checkedHeight = _height;
            // if (x + _width > _trackWidth) checkedWidth = x - _trackWidth;
            // else checkedWidth = _width;

            var startx = midx - 75;
            var starty = midy - 24;

            var xcounter = startx;
            var ycounter = starty;

            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    if (previouShownTrack[i, j] != currentTrack[ycounter, xcounter])
                    {
                        Console.SetCursorPosition(j, i);
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write(' ');
                        Console.SetCursorPosition(j, i);
                        // System.Console.Write(currentTrack[i, j]);
                        switch (currentTrack[ycounter, xcounter])
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
                        }
                        System.Console.Write(' ');

                        // System.Console.WriteLine(xcounter + " " + ycounter + " " + currentTrack[ycounter, xcounter]); // Debugging
                        previouShownTrack[i, j] = currentTrack[ycounter, xcounter];

                    }
                    xcounter++;
                }
                ycounter++;
                xcounter = startx;
            }
            // Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);
            // System.Console.WriteLine("X: " + x + " Y: " + y + " MidX: " + midx + " MidY: " + midy);

        }
    }
}