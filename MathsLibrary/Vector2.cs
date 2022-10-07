using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public struct Vector2
    {
        public float x, y;
        public float Magnitude
        {
            get
            {
                return MathF.Sqrt(x * x + y * y);
            }
        }
        public void Normalize()
        {
            float m = Magnitude;
            x /= m;
            y /= m;
        }
        public Vector2 Normalized
        {
            get
            {
                return new Vector2(x, y);
            }
        }
        public void Scale(Vector2 rhs)
        {
            x *= rhs.x;
            y *= rhs.y;
        }
        public Vector2 Scaled(Vector2 rhs)
        {
            return Scaled(new Vector2(rhs.x, rhs.y));
        }
        public float Dot(Vector2 rhs)
        {
            return (x * rhs.x + y * rhs.y);
        }
        public Vector2(float x, float y) /*float vX, float vY, float vZ*/ //this can be sedinstead if the 'this.' format
        {
            this.x = x;
            this.y = y;
        }
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            Vector2 sum;
            sum.x = lhs.x + rhs.x;
            sum.y = lhs.y + rhs.y;
            return sum;
        }
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.x - rhs.y);
        }

        public static Vector2 operator -(Vector2 rhs)
        {
            return new Vector2(-rhs.x, -rhs.y);
        }

        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            if (MathF.Abs(lhs.x - rhs.x) < float.Epsilon && MathF.Abs(lhs.y - rhs.y) < float.Epsilon)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return !(lhs == rhs);
        }

        public override string ToString()
        {
            return x.ToString(); y.ToString();
        }


    }

}
