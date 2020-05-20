namespace areyesram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1) return;
            int n;
            if (!int.TryParse(args[0], out n)) return;

            var cells = Spiral.Build(n);
            Spiral.Print(cells);
        }
    }
}