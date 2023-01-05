namespace Retro_Racer
{
    class trackHandler
    {
        public string[,] currentTrack = new string[,] { };
        public string[,] previouShownTrack = new string[102, 53];
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

        public void drawTrackSection(int x, int y, int midy, int midx)
        {
            var checkedHeight = 0; //int (int y) => { y + _height > _trackHeight ? y - _trackHeight : _height};
            var checkedWidth = 0;
            if (y + _height > _trackHeight) checkedHeight = y - _trackHeight;
            else checkedHeight = _height;
            if (x + _width > _trackWidth) checkedWidth = x - _trackWidth;
            else checkedWidth = _width;

            for (int i = y; i < y + checkedHeight; i++)
            {
                for (int j = x; j < x + checkedWidth; j++)
                {
                    if (previouShownTrack[i, j] != currentTrack[i, j])
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

                        previouShownTrack[i, j] = currentTrack[i, j];

                    }
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}