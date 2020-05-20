namespace spiral
{
    class Cell
    {
        internal int I { get; set; }
        internal int X { get; set; }
        internal int Y { get; set; }

        public static Cell operator +(Cell a, Cell b)
        {
            return new Cell
            {
                I = a.I,
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }
    }
}
