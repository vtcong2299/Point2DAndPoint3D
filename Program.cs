using System;

namespace Point2DAndPoint3D
{
    class Program
    {
        static void Main(string [] args)
        {
            Point2D point2D = new Point2D(3,2.5f);
            Console.WriteLine(point2D);
            Point3D point3D = new Point3D(1.5f,3,2.5f);
            Console.WriteLine(point3D);
        }
    }
}