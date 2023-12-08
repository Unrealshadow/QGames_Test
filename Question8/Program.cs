using Plotly.NET;
using Plotly.NET.LayoutObjects;
using static Plotly.NET.StyleParam.SubPlotId;

namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define control points for Bezier curve
            PointF p0 = new PointF(0, 0);
            PointF p1 = new PointF(1, 2);
            PointF p2 = new PointF(3, 3);
            PointF p3 = new PointF(4, 0);

            // Generate points along the Bezier curve
            List<double> xValues = new List<double>();
            List<double> yValues = new List<double>();

            for (float t = 0; t <= 1; t += 0.01f)
            {
                PointF point = BezierCurve.GetPointOnCurve(p0, p1, p2, p3, t);
                xValues.Add(point.X);
                yValues.Add(point.Y);
            }

            // Create a line chart
            var chart = Chart2D.Chart.Line<double, double, string>(xValues, yValues);


            // Display the chart
            chart.Show();
        }
    }
}
