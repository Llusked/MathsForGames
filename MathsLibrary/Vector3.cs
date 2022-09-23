using System;
using System.Collections.Generic;
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
            Vector3 sum;
            sum.x = lhs.x - rhs.x;
            sum.y = lhs.x - rhs.y;
            sum.z = lhs.x - rhs.z;
            return sum;
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

        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            if (MathF.Abs(lhs.x - rhs.x) < float.Epsilon && MathF.Abs(lhs.y - rhs.y) < float.Epsilon && MathF.Abs(lhs.x - rhs.x) < float.Epsilon)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return !(lhs == rhs);
        }

       //public override string ToString()
       //{
       //    return ;
       //}

    }


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

        public Vector4(float x, float y, float z, float w) /*float vX, float vY, float vZ*/ //this can be used instead if the 'this.' format
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
            Vector4 sum;
            sum.x = lhs.x - rhs.x;
            sum.y = lhs.x - rhs.y;
            sum.z = lhs.x - rhs.z;
            sum.w = lhs.x - rhs.w;
            return sum;
        }

        public static Vector4 operator -(Vector4 rhs)
        {
            return new Vector4(-rhs.x, -rhs.y, -rhs.z, -rhs.w);
        }


        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        }

        public static Vector4 operator *(float lhs, Vector4 rhs)
        {
            return new Vector4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        }

        public static Vector4 operator /(Vector4 lhs, float rhs)
        {
            return new Vector4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        }

        public static bool operator ==(Vector4 lhs, Vector4 rhs)
        {
            if (MathF.Abs(lhs.x - rhs.x) < float.Epsilon && MathF.Abs(lhs.y - rhs.y) < float.Epsilon && MathF.Abs(lhs.x - rhs.x) < float.Epsilon && MathF.Abs(lhs.w - rhs.w) < float.Epsilon)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vector4 lhs, Vector4 rhs)
        {
            return !(lhs == rhs);
        }

        //    public override string ToString()
        //    {

        //    }

        //}
    }


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
            Vector2 sum;
            sum.x = lhs.x - rhs.x;
            sum.y = lhs.x - rhs.y;
            return sum;
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

        //    public override string ToString()
        //    {

        //    }

        //}
    }
}
    