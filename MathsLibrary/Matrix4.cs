using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public struct Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        public Matrix4(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9,float m10, float m11, float m12, float m13, float m14, float m15, float m16)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.m4 = m4;
            this.m5 = m5;
            this.m6 = m6;
            this.m7 = m7;
            this.m8 = m8;
            this.m9 = m9;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
            this.m15 = m15;
            this.m16 = m16;
        }

        public readonly static Matrix4 Identity = new Matrix4(1, 0, 0, 0,
                                                              0, 1, 0, 0,
                                                              0, 0, 1, 0,
                                                              0, 0, 0, 1);

        public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
        {
            return new Matrix4(lhs.m1 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m9 * rhs.m3 + lhs.m13  * rhs.m4,
                               lhs.m2 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m10 * rhs.m3 + lhs.m14 * rhs.m4,
                               lhs.m3 * rhs.m1 + lhs.m7 * rhs.m2 + lhs.m11 * rhs.m3 + lhs.m15 * rhs.m4,
                               lhs.m4 * rhs.m1 + lhs.m8 * rhs.m2 + lhs.m12 * rhs.m3 + lhs.m16 * rhs.m4,


                               lhs.m1 * rhs.m5 + lhs.m5 * rhs.m6 + lhs.m9 * rhs.m7 + lhs.m13  * rhs.m8,
                               lhs.m2 * rhs.m5 + lhs.m6 * rhs.m6 + lhs.m10 * rhs.m7 + lhs.m14 * rhs.m8,
                               lhs.m3 * rhs.m5 + lhs.m7 * rhs.m6 + lhs.m11 * rhs.m7 + lhs.m15 * rhs.m8,
                               lhs.m4 * rhs.m5 + lhs.m8 * rhs.m6 + lhs.m12 * rhs.m7 + lhs.m16 * rhs.m8,

                               lhs.m1 * rhs.m9 + lhs.m5 * rhs.m10 + lhs.m9 * rhs.m11 + lhs.m13  * rhs.m12,
                               lhs.m2 * rhs.m9 + lhs.m6 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m14 * rhs.m12,
                               lhs.m3 * rhs.m9 + lhs.m7 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m15 * rhs.m12,
                               lhs.m4 * rhs.m9 + lhs.m8 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m16 * rhs.m12,

                               lhs.m1 * rhs.m13 + lhs.m5 * rhs.m14 + lhs.m9 * rhs.m15 + lhs.m13  * rhs.m16,
                               lhs.m2 * rhs.m13 + lhs.m6 * rhs.m14 + lhs.m10 * rhs.m15 + lhs.m14 * rhs.m16,
                               lhs.m3 * rhs.m13 + lhs.m7 * rhs.m14 + lhs.m11 * rhs.m15 + lhs.m15 * rhs.m16,
                               lhs.m4 * rhs.m13 + lhs.m8 * rhs.m14 + lhs.m12 * rhs.m15 + lhs.m16 * rhs.m16);
        }

        public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
        {
           return new Vector4(lhs.m1 * rhs.x + lhs.m5 * rhs.y + lhs.m9 * rhs.z + lhs.m13  * rhs.w,
                              lhs.m2 * rhs.x + lhs.m6 * rhs.y + lhs.m10 * rhs.z + lhs.m14 * rhs.w,
                              lhs.m3 * rhs.x + lhs.m7 * rhs.y + lhs.m11 * rhs.z + lhs.m15 * rhs.w,
                              lhs.m4 * rhs.x + lhs.m8 * rhs.y + lhs.m12 * rhs.z + lhs.m16 * rhs.w);
        }

        public static Matrix4 CreateTransation(float x, float y, float z, float w)
        {

            Matrix4 mat = Identity;

            mat.m13 = x;
            mat.m14 = y;
            mat.m15 = z;
            mat.m16 = w;

            return mat;


            //Matrix4 m = new Matrix4();
            //m.m1 = 1; m.m5 = 1; m.m9 = 1; m.m13 = 1;
            //m.m2 = 0; m.m6 = 0; m.m10 = 0; m.m14 = 0;
            //m.m3 = 0; m.m7 = 0; m.m11 = 0; m.m15 = 0;
            //m.m4 = 0; m.m8 = 0; m.m12 = 0; m.m16 = 0;

            //return m;
        }

        public static Matrix4 CreateTranslation(Vector4 vec)
        {
            Matrix4 mat = Identity;

            mat.m13 = vec.x;
            mat.m14 = vec.y;
            mat.m15 = vec.z;
            mat.m16 = vec.w;

            return mat;

            //Matrix3 m = new Matrix3();
            //m.m1 = 1; m.m4 = 0; m.m7 = vec.x;
            //m.m2 = 0; m.m5 = 1; m.m8 = vec.y;
            //m.m3 = 0; m.m6 = 0; m.m9 = 1;
            //return m;
        }

        public static Matrix4 CreateRotateX(float a)
        {

            return new Matrix4(1, 0, 0, 0,
                               0, MathF.Cos(a), -MathF.Sin(a), 0,
                               0, MathF.Sin(a), MathF.Cos(a), 0,
                               0, 0, 0, 1);

            //Matrix3 m = new Matrix3();
            //m.m1 = 1; m.m4 = 0; m.m7 = 0;
            //m.m2 = 0; m.m5 = (float)Math.Cos(a); m.m8 = (float)Math.Sin(a);
            //m.m3 = 0; m.m6 = (float)(-Math.Sin(a)); m.m9 = (float)Math.Cos(a);
            //return m;
        }

        public static Matrix4 CreateRotateY(float a)
        {

            return new Matrix4(MathF.Cos(a), 0, MathF.Sin(a), 0,
                               0, 1, 0, 0,
                               -MathF.Sin(a), 0, MathF.Cos(a), 0,
                               0, 0, 0, 1);

            //Matrix3 m = new Matrix3();
            //m.m1 = (float)Math.Cos(a); m.m4 = 0; m.m7 = (float)(-Math.Sin(a));
            //m.m2 = 0; m.m5 = 1; m.m8 = 0;
            //m.m3 = (float)Math.Sin(a); m.m6 = 0; m.m9 = (float)Math.Cos(a);
            //return m;
        }

        public static Matrix4 CreateRotateZ(float a)
        {

            return new Matrix4(MathF.Cos(a), -MathF.Sin(a), 0, 0,
                               MathF.Sin(a), MathF.Cos(a), 0, 0,
                               0, 0, 1, 0,
                               0, 0, 0, 1);

            //Matrix3 m = new Matrix3();
            //m.m1 = (float)Math.Cos(a); m.m4 = (float)Math.Sin(a); m.m7 = 0;
            //m.m2 = (float)(-Math.Sin(a)); m.m5 = (float)Math.Cos(a); m.m8 = 0;
            //m.m3 = 0; m.m6 = 0; m.m9 = 1;
            //return m;
        }

        public static Matrix4 Euler(float pitch, float yaw, float roll)
        {
            Matrix4 mat = new Matrix4();

            mat.m13 = pitch;
            mat.m14 = yaw;
            mat.m15 = roll;

            return mat;
        }

        public static Matrix4 CreateScale(float xScale, float yScale, float zScale)
        {

            Matrix4 mat = Identity;

            mat.m1 = xScale;
            mat.m6 = yScale;
            mat.m11 = zScale;

            return mat;
            
            //Matrix3 m = new Matrix3();
            //m.m1 = xScale; m.m4 = 0; m.m7 = 0;
            //m.m2 = 0; m.m4 = yScale; m.m8 = 0;
            //m.m3 = 0; m.m5 = 0; m.m9 = 1;
            //return m;
        }
        public static Matrix4 CreateScale(float xScale, float yScale, float zScale, float wScale)
        {

            Matrix4 mat = Identity;

            mat.m1 = xScale;
            mat.m6 = yScale;
            mat.m11 = zScale;
            mat.m16 = wScale;

            return mat;

            //Matrix3 m = new Matrix3();
            //m.m1 = xScale; m.m4 = 0; m.m7 = 0;
            //m.m2 = 0; m.m4 = yScale; m.m8 = 0;
            //m.m3 = 0; m.m5 = 0; m.m9 = xScale;
            //return m;

        }
        public static Matrix4 CreateScale(Vector4 scale)
        {

            Matrix4 mat = Identity;

            mat.m1 = scale.x;
            mat.m6 = scale.y;
            mat.m11 = scale.z;
            mat.m16 = scale.w;

            return mat;

            //Matrix3 m = new Matrix3();
            //m.m1 = scale.x; m.m4 = 0; m.m7 = 0;
            //m.m2 = 0; m.m4 = scale.y; m.m8 = 0;
            //m.m3 = 0; m.m5 = 0; m.m9 = scale.z;
            //return m;
        }

        public void SetTranslation(float x, float y, float z)
        {
            m13 = x;
            m14 = y;
            m15 = z;
        }

        public void Translate(float x, float y)
        {
            this.m1 *= x;
            this.m6 *= y;
        }

        public Vector4 GetTranslation()
        {
            return new Vector4(m13, m14, m15, m16);
        }

        // rotates the existing matrix by a certain amount on the X-axis
        public void RotateX(float radians)
        {
            this *= CreateRotateX(radians);
        }

        // rotates the existing matrix by a certain amount on the Y-axis
        public void RotateY(float radians)
        {
            this *= CreateRotateY(radians);
        }

        // rotates the existing matrix by a certain amount on the Z-axis
        public void RotateZ(float radians)
        {
            this *= CreateRotateZ(radians);
        }

        // scales the existing matrix by a certain amount on each axis
        public void Scale(float x, float y, float z)
        {
            m1 *= x;
            m6 *= y;
            m11 *= z;
        }


        // scales the existing matrix by a certain amount on each axis
        public void Scale(Vector4 v)
        {
            m1 = v.x;
            m6 = v.y;
            m11 = v.z;
            m16 = v.w;
        }

        public bool Equals(Matrix4 other)
        {
            if (MathF.Abs(m1 - other.m1) < 0.0001 &&
                MathF.Abs(m2 - other.m2) < 0.0001 &&
                MathF.Abs(m3 - other.m3) < 0.0001 &&
                MathF.Abs(m4 - other.m4) < 0.0001 &&
                MathF.Abs(m5 - other.m5) < 0.0001 &&
                MathF.Abs(m6 - other.m6) < 0.0001 &&
                MathF.Abs(m7 - other.m7) < 0.0001 &&
                MathF.Abs(m8 - other.m8) < 0.0001 &&
                MathF.Abs(m9 - other.m9) < 0.0001 &&
                MathF.Abs(m10 - other.m10) < 0.0001 &&
                MathF.Abs(m11 - other.m11) < 0.0001 &&
                MathF.Abs(m12 - other.m12) < 0.0001 &&
                MathF.Abs(m13 - other.m13) < 0.0001 &&
                MathF.Abs(m14 - other.m14) < 0.0001 &&
                MathF.Abs(m15 - other.m15) < 0.0001 &&
                MathF.Abs(m16 - other.m16) < 0.0001)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj != null && this.Equals((Matrix4)obj);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();

            hash.Add(m1);
            hash.Add(m2);
            hash.Add(m3);
            hash.Add(m4);
            hash.Add(m5);
            hash.Add(m6);
            hash.Add(m7);
            hash.Add(m8);
            hash.Add(m9);
            hash.Add(m10);
            hash.Add(m11);
            hash.Add(m12);
            hash.Add(m13);
            hash.Add(m14);
            hash.Add(m15);
            hash.Add(m16);

            return hash.GetHashCode();
        }

        public override string ToString()
        {
            return m1.ToString() + "," + m2.ToString() + "," + m3.ToString() + "," + m4.ToString() + "," + m5.ToString() + "," + m6.ToString() + "," + m7.ToString() + "," + m8.ToString() + "," + m9.ToString() + "," + m10.ToString() + "," + m11.ToString() + "," + m12.ToString() + "," + m13.ToString() + "," + m14.ToString() + "," + m15.ToString() + "," + m16.ToString();
        }

        public static Matrix4 operator *(Matrix4 lhs, float scalar)
        {
            lhs.m1 *= scalar;
            lhs.m2 *= scalar;
            lhs.m3 *= scalar;
            lhs.m4 *= scalar;
            lhs.m5 *= scalar;
            lhs.m6 *= scalar;
            lhs.m7 *= scalar;
            lhs.m8 *= scalar;
            lhs.m9 *= scalar;
            lhs.m10 *= scalar;
            lhs.m11 *= scalar;
            lhs.m12 *= scalar;
            lhs.m13 *= scalar;
            lhs.m14 *= scalar;
            lhs.m15 *= scalar;
            lhs.m16 *= scalar;

            return lhs;
        }
      
        public static Matrix4 operator *(float scalar, Matrix4 rhs)
        {
            rhs.m1 *= scalar;
            rhs.m2 *= scalar;
            rhs.m3 *= scalar;
            rhs.m4 *= scalar;
            rhs.m5 *= scalar;
            rhs.m6 *= scalar;
            rhs.m7 *= scalar;
            rhs.m8 *= scalar;
            rhs.m9 *= scalar;
            rhs.m10 *= scalar;
            rhs.m11 *= scalar;
            rhs.m12 *= scalar;
            rhs.m13 *= scalar;
            rhs.m14 *= scalar;
            rhs.m15 *= scalar;
            rhs.m16 *= scalar;

            return rhs;
        }

    }
}
