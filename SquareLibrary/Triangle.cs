namespace SquareLibrary
{
    public class Triangle : IFigure
    {
        public double A;
        public double B;
        public double C;

        public double GetSquare()
        {
            double hypotenuse = 0.0;
            //катеты
            double leg1 = 0.0;
            double leg2 = 0.0;
            if (A > B && A > C)
            {
                hypotenuse = A;
                leg1 = B;
                leg2 = C;
            }
            else if (B > A && B > C)
            {
                hypotenuse = B;
                leg1 = A;
                leg2 = B;
            }
            else if (C > A && C > B)
            {
                hypotenuse = C;
                leg1 = A;
                leg2 = B;
            }
            if (hypotenuse * hypotenuse == leg1 * leg1 + leg2 * leg2)
            {
                return (leg1 * leg2) * 0.5;
            }
            else
            {
                double semiperimeter = (A + B + C) * 0.5;
                return Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
            }
        }
    }
}