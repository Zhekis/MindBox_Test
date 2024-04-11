namespace AreaFigureLib
{
    public abstract class Form
    {
        private readonly double area;
        public double GetArea => area;
        protected Form(double area) => this.area = area;
        public override string ToString() =>
            $"Area = {area:F3}";
    }

    public class Circle : Form
    {
        public Circle(double r) : base(Math.PI * r * r)
        {
            if (r <= 0.0)
                throw new ArgumentException("Radius is not corrected");
        }
    }

    public class Triangle : Form
    {
        readonly double[] Sides;
        public Triangle(double a, double b, double c) : base
            (Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)))
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Side length is not corrected");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Sides is not form a triangle");

            Sides = new double[3] { a, b, c };
        }
        public bool IsRight(double eps = 1E-6)
        {
            Array.Sort(Sides);
            return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2)) <= eps;
        }
    }
}
