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
        public trackHandler(string[,] track, int consoleHeight, int consoleWidth)
        {
            currentTrack = track;
            // Console.WriteLine("Track Height: " + track.GetLength(0) + " Track Width: " + track.GetLength(1));
            _height = consoleHeight;
            _width = consoleWidth;
            _trackHeight = track.GetLength(0);
            _trackWidth = track.GetLength(1);
            // Console.WriteLine(
            //     "Console Height: " + consoleHeight + " Console Width: " + consoleWidth + " MidX " + ((consoleWidth / 2))
            // );
            _cMidX = (consoleWidth / 2);
            _cMidY = (consoleHeight / 2);
        }

        public void drawTrackSection(int x, int y, int midx, int midy)
        {

            var startx = midx - _cMidX;
            var starty = midy - _cMidY;
            if (startx < 0) startx = 0;
            if (starty < 0) starty = 0;
            if (midx + _cMidX > _trackWidth)
            {
                var difference = midx + _cMidX - _trackWidth;
                startx -= difference;
            }
            if (midy + _cMidY > _trackHeight)
            {
                var difference = midy + _cMidY - _trackWidth;
                starty -= difference;
            }

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
                        // Console.Write(currentTrack[i, j]);
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
                        Console.Write(' ');

                        // Console.WriteLine(xcounter + " " + ycounter + " " + currentTrack[ycounter, xcounter]); // Debugging
                        previouShownTrack[i, j] = currentTrack[ycounter, xcounter];

                    }
                    xcounter++;
                }
                ycounter++;
                xcounter = startx;
            }
            // Console.BackgroundColor = ConsoleColor.Black;
            // Console.SetCursorPosition(0, 0);
            // Console.WriteLine("X: " + x + " Y: " + y + " MidX: " + midx + " MidY: " + midy);

        }
        public string getTrackSection(int x, int y)
        {
            return currentTrack[y, x];
        }

    }
}