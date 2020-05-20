using System;
using System.Linq;

namespace spiral
{
    internal static class Spiral
    {
        private static Cell[] _direction = new Cell[]
            {
                new Cell { X = 1, Y = 0 },
                new Cell { X = 0, Y = 1 },
                new Cell { X = -1, Y = 0 },
                new Cell { X = 0, Y = -1 }
            };

        internal static Cell[] Build(int n)
        {
            var cells = new Cell[n];
            var current = new Cell();
            var steps = 1;
            var d = 0;
            var hor = true;
            var i = 0;
            do
            {
                for (var j = 0; j < steps; j++)
                {
                    if (i >= n) break;
                    cells[i] = new Cell { I = i + 1 } + current;
                    current += _direction[d];
                    i++;
                }
                hor = !hor;
                if (hor) steps++;
                d++;
                if (d >= _direction.Length) d = 0;
            } while (i < n);
            return cells;
        }

        internal static void Print(Cell[] cells)
        {
            cells = cells.OrderBy(p => p.Y).ThenBy(p => p.X).ToArray();
            var minx = cells.Select(p => p.X).Min();
            for (var i = 0; i < cells.Length; i++)
            {
                if (i > 0 && cells[i].Y != cells[i - 1].Y)
                {
                    Console.WriteLine();
                }
                if (i == 0 || cells[i].Y != cells[i - 1].Y)
                {
                    for (var j = minx; j < cells[i].X; j++)
                        Console.Write("    ");
                }
                Console.Write(cells[i].I.ToString().PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}
