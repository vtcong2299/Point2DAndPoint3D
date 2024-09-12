using System;

namespace Point2DAndPoint3D
{
    class Point2D
    {
        protected float x = 0.0f;
        protected float y = 0.0f;
        public float X
        {
            get => x; set => x =value;
        }
        public float Y
        {
            get => y; set => y =value;
        }
        public Point2D(){}
        public Point2D(float x, float y)
        {
            this.x=x;
            this.y=y;
        }
        public float[] GetXY()
        {
            return new float[] { x, y };
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}