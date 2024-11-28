using System.Drawing;

namespace Banner
{
    public abstract class Banner
    {
        const int MAX_ROW = 30;
        const int MAX_COL = 1000;
        const int MIN_ROW = 8;
        const int MIN_COL = 20;

        private Color[,] _pixel;
        protected Banner(int row, int col)
        {
            if (row < MIN_ROW || row > MAX_ROW
                || col > MAX_COL || col < MIN_COL)
                throw new ArgumentException("Error");
                _pixel = new Color[row, col];
        }
        protected Banner() : this(MIN_ROW, MIN_COL) { }

        public int RowNum => _pixel.GetLength(0);
        public int ColNum => _pixel.GetLength(1);

        public Color this[int row, int col]
        {
            get
            {
                if (row < MIN_ROW || row > MAX_ROW
                || col > MAX_COL || col < MIN_COL)
                    throw new ArgumentException("Error");
                    return _pixel[row, col];
            }
            set
            {
                if (row < MIN_ROW || row > MAX_ROW
                || col > MAX_COL || col < MIN_COL)
                    throw new ArgumentException("Error");
                _pixel[row, col] = value;

            }
        }
    }
}
