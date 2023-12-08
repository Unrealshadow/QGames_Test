using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Explanation of the approach
 * Encapsulation: The x, y, and z components are private, ensuring they cannot be modified directly from outside the class.
 * Instead, they are accessed through public properties.
 * 
 * Operator Overloading: The +, -, *, and / operators are overloaded to provide a natural way to perform vector 
 * addition, subtraction, scalar multiplication, and scalar division.
 * 
 * Static Methods for Dot and Cross Products: These operations are implemented as static methods since 
 * they involve two vectors and return either a scalar (dot product) or a new vector (cross product).
 * 
 * Efficiency: The methods use direct access to private fields, which is efficient in terms of performance. 
 * Also, by overloading operators, vector operations can be chained in a performant way.
 * 
 * Immutability Aspect: Each operation results in a new Vector3D instance, ensuring that vectors are immutable. 
 * This is a design choice that can contribute to safer and more predictable behavior in a multithreaded environment.
 * 
 * Debugging: Overriding the ToString method helps in debugging by providing an easy way to view vector contents.
 */
namespace Question4
{
    internal class Vector3D
    {

        // Private member variables to store the components of the vector
        private double x;
        private double y;
        private double z;

        // Public properties for accessing the vector components
        public double X { get { return x; } }
        public double Y { get { return y; } }
        public double Z { get { return z; } }

        // Constructor
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Addition of two vectors
        public static Vector3D operator +(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        // Subtraction of two vectors
        public static Vector3D operator -(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        // Scalar multiplication
        public static Vector3D operator *(Vector3D v, double scalar)
        {
            return new Vector3D(v.x * scalar, v.y * scalar, v.z * scalar);
        }

        // Scalar division
        public static Vector3D operator /(Vector3D v, double scalar)
        {
            if (scalar == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return new Vector3D(v.x / scalar, v.y / scalar, v.z / scalar);
        }

        // Dot product
        public static double Dot(Vector3D a, Vector3D b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        // Cross product
        public static Vector3D Cross(Vector3D a, Vector3D b)
        {
            return new Vector3D(
                a.y * b.z - a.z * b.y,
                a.z * b.x - a.x * b.z,
                a.x * b.y - a.y * b.x
            );
        }

        // Override ToString for easy debugging
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }


    }
}
