using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public struct Vector4
    {
        public float x, y, z, w;

        public float Magnitude
        {
            get
            {
                return MathF.Sqrt(x * x + y * y + z * z + w * w);
            }
        }

        public void Normalize()
        {
            float m = Magnitude;
            x /= m;
            y /= m;
            z /= m;
            w /= m;
        }

        public Vector4 Normalized
        {
            get
            {
                return new Vector4(x, y, z, w);
            }
        }


        public void Scale(Vector4 rhs)
        {
            x *= rhs.x;
            y *= rhs.y;
            z *= rhs.z;
            w *= rhs.w;
        }
        public Vector4 Scaled(Vector4 rhs)
        {
            return Scaled(new Vector4(rhs.x, rhs.y, rhs.z, rhs.w));
        }

        public float Dot(Vector4 rhs)
        {
            return (x * rhs.x + y * rhs.y + z * rhs.z);
        }

        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(y * rhs.z - z * rhs.y, z * rhs.x - x * rhs.z, x * rhs.y - y * rhs.x, w = 0);
        }

        public Vector4(float x, float y, float z, float w) /*float vX, float vY, float vZ*/ //this can be used insteadifth'this.' format
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            Vector4 sum;
            sum.x = lhs.x + rhs.x;
            sum.y = lhs.y + rhs.y;
            sum.z = lhs.z + rhs.z;
            sum.w = lhs.w + rhs.w;
            return sum;
        }
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        public static Vector4 operator -(Vector4 rhs)
        {
            return new Vector4(-rhs.x, -rhs.y, -rhs.z, -rhs.w);
        }


        public static Vector4 operator *(Vector4 lhs, float scalar)
        {
            return new Vector4(lhs.x * scalar, lhs.y * scalar, lhs.z * scalar, lhs.w * scalar);
        }

        public static Vector4 operator *(float scalar, Vector4 rhs)
        {
            return new Vector4(scalar * rhs.x, scalar * rhs.y, scalar * rhs.z, scalar * rhs.w);
        }

        public static Vector4 operator /(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        }

        public bool Equals(Vector4 other)
        {
            if (MathF.Abs(x - other.x) < 0.0001 &&
                MathF.Abs(y - other.y) < 0.0001 &&
                MathF.Abs(z - other.z) < 0.0001 &&
                MathF.Abs(w - other.w) < 0.0001)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj != null && this.Equals((Vector4)obj);
        }

        public static bool operator ==(Vector4 lhs, Vector4 rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Vector4 lhs, Vector4 rhs)
        {
            return !(lhs == rhs);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();

            hash.Add(x);
            hash.Add(y);
            hash.Add(z);
            hash.Add(w);

            return hash.GetHashCode();
        }

        public override string ToString()
        {
            return x.ToString() + "," + y.ToString() + "," + z.ToString() + "," + w.ToString();
        }


    }


}
