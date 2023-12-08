public class HeightField
{
    private readonly float[,] heights; // 2D array of heights

    public HeightField(float[,] heights)
    {
        this.heights = heights;
    }

    public float GetHeight(float x, float y)
    {
        // Grid cell coordinates
        int gridX = (int)Math.Floor(x);
        int gridY = (int)Math.Floor(y);

        // Ensure the point is within the bounds of the height field
        if (gridX < 0 || gridX >= heights.GetLength(0) - 1 || gridY < 0 || gridY >= heights.GetLength(1) - 1)
            throw new ArgumentOutOfRangeException("The point is outside the height field.");

        // Heights at the corners of the cell
        float hA = heights[gridX, gridY];     // Height at A
        float hB = heights[gridX + 1, gridY]; // Height at B
        float hC = heights[gridX + 1, gridY + 1]; // Height at C
        float hD = heights[gridX, gridY + 1]; // Height at D

        // Relative position within the cell
        float dx = x - gridX;
        float dy = y - gridY;

        // Determine the triangle and interpolate
        if (dx + dy <= 1)
        {
            // Point is in triangle ABC
            return hA + dx * (hB - hA) + dy * (hD - hA);
        }
        else
        {
            // Point is in triangle ACD
            return hC + (1 - dx) * (hD - hC) + (1 - dy) * (hB - hC);
        }
    }
}
