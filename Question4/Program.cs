namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two Vector3D instances
            Vector3D vector1 = new Vector3D(1, 2, 3);
            Vector3D vector2 = new Vector3D(4, 5, 6);

            // Perform addition
            Vector3D sum = vector1 + vector2;
            Console.WriteLine("Sum: " + sum);

            // Perform subtraction
            Vector3D difference = vector1 - vector2;
            Console.WriteLine("Difference: " + difference);

            // Perform scalar multiplication
            Vector3D scaled = vector1 * 2;
            Console.WriteLine("Scalar Multiplication (Vector1 * 2): " + scaled);

            // Perform scalar division
            Vector3D divided = vector1 / 2;
            Console.WriteLine("Scalar Division (Vector1 / 2): " + divided);

            // Calculate dot product
            double dotProduct = Vector3D.Dot(vector1, vector2);
            Console.WriteLine("Dot Product: " + dotProduct);

            // Calculate cross product
            Vector3D crossProduct = Vector3D.Cross(vector1, vector2);
            Console.WriteLine("Cross Product: " + crossProduct);
        }
    }
}
