using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public struct Vector3
    {
        public float x, y, z;

        public float Magnitude
        {
            get
            {
                return MathF.Sqrt(x * x + y * y + z * z);
            }
        }

        public void Normalize()
        {
            float m = Magnitude;
            x /= m;
            y /= m;
            z /= m;
        }

        public Vector3 Normalized
        {
            get
            {
                return this / Magnitude;
            }
        }

        public void Scale(Vector3 rhs)
        {
            x *= rhs.x;
            y *= rhs.y;
            z *= rhs.z;
        }
        public Vector3 Scaled(Vector3 rhs)
        {
            return Scaled(new Vector3(x * rhs.x, y * rhs.y, z * rhs.z));
        }

        public float Dot(Vector3 rhs)
        {
            return(x * rhs.x + y * rhs.y + z * rhs.z);
        }

       public Vector3 Cross(Vector3 rhs)
       {
           return new Vector3(y * rhs.z - z * rhs.y,  z * rhs.x - x * rhs.z,  x * rhs.y - y * rhs.x);
       }

        public Vector3(float x, float y, float z) /*float vX, float vY, float vZ*/ //this can be used instead if the 'this.' format
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            Vector3 sum;
            sum.x = lhs.x + rhs.x;
            sum.y = lhs.y + rhs.y;
            sum.z = lhs.z + rhs.z;
            return sum;
        }
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        public static Vector3 operator -(Vector3 rhs)
        {
            return new Vector3(-rhs.x, -rhs.y, -rhs.z);

        }

        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }

        public static Vector3 operator *(float lhs, Vector3 rhs)
        {
            return new Vector3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        }

        public static Vector3 operator /(Vector3 lhs, float rhs)
        {
            return new Vector3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }

        public bool Equals(Vector3 other)
        {
            if (MathF.Abs(x - other.x) < 0.0001 &&
                MathF.Abs(y - other.y) < 0.0001 &&
                MathF.Abs(z - other.z) < 0.0001)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj != null && this.Equals((Vector3)obj);
        }

        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return !(lhs == rhs);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();

            hash.Add(x);
            hash.Add(y);
            hash.Add(z);

            return base.GetHashCode();
        }

        public override string ToString()
       {
            return x.ToString(); y.ToString(); z.ToString();
       }

    }
}
    