using System;

namespace Point2DAndPoint3D
{
    class Point3D:Point2D
    {
        protected float z = 0.0f;        
        public float Z
        {
            get => z; set => z =value;
        }
        public Point3D(){}
        public Point3D(float z,float x, float y):base(x,y)
        {
            this.z=z;            
        }
        public float[] GetXYZ()
        {
            return new float[] { x, y , z};
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}