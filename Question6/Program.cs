namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] heightData = new float[10, 10]
{
    { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
    { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 },
    { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 },
    { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 },
    { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
    { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 },
    { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 },
    { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 },
    { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }
};


            // Create a HeightField instance
            HeightField heightField = new HeightField(heightData);

            // Coordinates where you want to find the height
            float x = 3.5f;
            float y = 7.2f;

            // Get the height at the specified point
            float heightAtPoint = heightField.GetHeight(x, y);

            // Print the height to the console
            Console.WriteLine($"The height at point ({x}, {y}) is {heightAtPoint}");

        }
    }
}
