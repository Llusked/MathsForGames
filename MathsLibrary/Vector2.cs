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

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.x * scalar, lhs.y * scalar);
        }


        public static Vector2 operator *(float scalar, Vector2 rhs)
        {
            return new Vector2(scalar * rhs.x, scalar * rhs.y);
        }

        public static Vector2 operator /(Vector2 lhs, float rhs)
        {
            return new Vector2(lhs.x / rhs, lhs.y / rhs);
        }

        public bool Equals(Vector2 other)
        {
            if (MathF.Abs(x - other.x) < 0.0001 && 
                MathF.Abs(y - other.y) < 0.0001)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object? obj)
        {
            return obj != null && this.Equals((Vector2)obj);
        }

        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return !(lhs == rhs);
        }
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();

            hash.Add(x);
            hash.Add(y);

            return hash.GetHashCode();
        }

        public override string ToString()
        {
            return x.ToString() + "," + y.ToString();
        }
    }

}
