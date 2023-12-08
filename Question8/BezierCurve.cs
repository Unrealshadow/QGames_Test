using System;

public class BezierCurve
{
    public static PointF GetPointOnCurve(PointF p0, PointF p1, PointF p2, PointF p3, float t)
    {
        // Cubic Bezier curve formula
        float cx = 3 * (p1.X - p0.X);
        float cy = 3 * (p1.Y - p0.Y);
        float bx = 3 * (p2.X - p1.X) - cx;
        float by = 3 * (p2.Y - p1.Y) - cy;
        float ax = p3.X - p0.X - cx - bx;
        float ay = p3.Y - p0.Y - cy - by;
        float Cube = t * t * t;
        float Square = t * t;

        float resX = (ax * Cube) + (bx * Square) + (cx * t) + p0.X;
        float resY = (ay * Cube) + (by * Square) + (cy * t) + p0.Y;

        return new PointF(resX, resY);
    }
}

public struct PointF
{
    public float X, Y;

    public PointF(float x, float y)
    {
        X = x;
        Y = y;
    }
}
