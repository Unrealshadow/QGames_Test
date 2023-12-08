namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointF p0 = new PointF(0, 0);
            PointF p1 = new PointF(1, 2);
            PointF p2 = new PointF(3, 3);
            PointF p3 = new PointF(4, 0);

            int width = 50;  // Console width
            int height = 20; // Console height

            for (float t = 0; t <= 1; t += 0.01f)
            {
                PointF point = BezierCurve.GetPointOnCurve(p0, p1, p2, p3, t);

                // Scale the point to fit in the console window
                int x = (int)(point.X / 4 * width);
                int y = (int)(point.Y / 3 * height);

                // Invert y for console drawing (as y increases downwards in console)
                y = height - y;

                if (x >= 0 && x < width && y >= 0 && y < height)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                }
            }

            Console.SetCursorPosition(0, height);
        }
    }
}
