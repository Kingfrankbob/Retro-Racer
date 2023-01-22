namespace Retro_Racer
{
    public class trackHandler
    {
        public string[,] currentTrack = new string[,] { };
        private int[] _startX = new int[] { };
        private int[] _startY = new int[] { };
        public string[,] previouShownTrack = trackReference.bufferStart;
        private int _height;
        private int _width;
        private int _trackHeight;
        private int _trackWidth;
        private int _cMidX;
        private int _cMidY;
        private int _sMidX;
        private int _sMidY;
        public trackHandler(string track, int consoleHeight, int consoleWidth)
        {
            var trackReference = new trackReference();
            try
            {
                var TrackS = trackReference.GetType().GetFields().ToList().Where(f => (f.Name == track)).ToList();
                foreach (var prop in TrackS) currentTrack = prop.GetValue(trackReference) as string[,] ?? new string[,] { };
                // System.Console.WriteLine(prop.Name);
                var TrackSX = trackReference.GetType().GetFields().ToList().Where(f => (f.Name == (track + "StartX")));
                foreach (var prop in TrackSX) _startX = prop.GetValue(trackReference) as int[] ?? new int[] { };

                var TrackSY = trackReference.GetType().GetFields().ToList().Where(f => (f.Name == (track + "StartY")));
                foreach (var prop in TrackSY) _startY = prop.GetValue(trackReference) as int[] ?? new int[] { };
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message + " " + e.StackTrace + "Please dont mess around with the code, it will break things.");
            }
            // foreach (var line in currentTrack) System.Console.WriteLine(line);

            _height = consoleHeight;
            _width = consoleWidth;
            _trackHeight = currentTrack.GetLength(0);
            _trackWidth = currentTrack.GetLength(1);
            _cMidX = (consoleWidth / 2);
            _cMidY = (consoleHeight / 2);

            var itemX = 0L;

            foreach (var item in trackReference.Track1StartX) itemX += item;
            itemX /= trackReference.Track1StartX.Length;
            _sMidX = (int)itemX;
            var itemY = 0L;

            foreach (var item in trackReference.Track1StartY) itemY += item;
            itemY /= trackReference.Track1StartX.Length;
            _sMidY = (int)itemY;

        }

        public void drawTrackSection(int x, int y, int midx, int midy, Racer racer)
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

            var crashStartX = midx - 1;
            var crashStartY = midy - 1;

            var xcounter = startx;
            var ycounter = starty;

            var crashCounterX = crashStartX;
            var crashCounterY = crashStartY;

            for (int i = 0; i < _height - 1; i++)
            {
                for (int j = 0; j < _width; j++)
                {

                    if (previouShownTrack[i, j] != currentTrack[ycounter, xcounter])
                    {
                        Console.SetCursorPosition(j, i);
                        switch (currentTrack[ycounter, xcounter])
                        {
                            case "Track":
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                break;
                            case "Start":
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
                    }

                    previouShownTrack[i, j] = currentTrack[ycounter, xcounter];
                    xcounter++;
                }
                ycounter++;
                xcounter = startx;
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    // Console.BackgroundColor = ConsoleColor.Black;
                    // Console.SetCursorPosition(76 + j, 25 + i);
                    // System.Console.WriteLine(' ');
                    if (currentTrack[crashCounterY, crashCounterX] == "Wall")
                    {
                        racer.Crash();
                    }
                    crashCounterX++;
                }
                crashCounterY++;
                crashCounterX = crashStartX;
            }

        }
        public string getTrackSection(int x, int y)
        {
            return currentTrack[y, x];
        }
        public int StartX
        {
            get
            {
                return _sMidX;
            }
        }
        public int StartY
        {
            get
            {
                return _sMidY;
            }
        }

    }
}