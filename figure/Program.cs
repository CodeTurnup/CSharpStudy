namespace figure
{
    enum Figures
    {
        Romb,
        Circle,
        Rect
    }
    struct FData
    {
        public int X0, Y0;      // координаты
        public int Color;   // цвет фигуры
        public Figures Type;	// тип фигуры

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FData fd;
            fd.X0 = 1; 
            fd.Y0 = 1;
            fd.Color = 0x2727FF;
            fd.Type = Figures.Romb;
            Console.WriteLine($"({fd.X0}, {fd.Y0}) {fd.Color} {fd.Type}");

        }
    }
}
