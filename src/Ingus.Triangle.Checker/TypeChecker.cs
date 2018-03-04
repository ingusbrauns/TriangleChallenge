namespace Ingus.Triangle.Checker
{
    public static class TypeChecker
    {
        public static TriangleType GetTriangleType(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || b + c <= a || c + a <= b)
                return TriangleType.None;

            if (a == b && b == c)
                return TriangleType.Equilateral;
            if (a == b || b == c || c == a)
                return TriangleType.Isoseles;
            else
                return TriangleType.Scalene;
        }
    }
}
