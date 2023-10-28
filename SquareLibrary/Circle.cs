namespace SquareLibrary
{
    public class Circle : IFigure
    {
        public double Radius;

        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
