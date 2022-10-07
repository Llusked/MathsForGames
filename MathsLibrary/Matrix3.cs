using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public struct Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        public Matrix3(float m1, float m2, float m3,
                       float m4, float m5, float m6,
                       float m7, float m8, float m9)
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
        }

        public readonly static Matrix3 Identity = new Matrix3(1, 0, 0,  0, 1, 0,  0, 0, 1);

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3(lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3,
                               lhs.m2 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m8 * rhs.m3,
                               lhs.m3 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m9 * rhs.m3,

                               lhs.m1 * rhs.m4 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m6,
                               lhs.m2 * rhs.m4 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m6,
                               lhs.m3 * rhs.m4 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m6,

                               lhs.m1 * rhs.m7 + lhs.m4 * rhs.m8 + lhs.m7 * rhs.m9,
                               lhs.m2 * rhs.m7 + lhs.m5 * rhs.m8 + lhs.m8 * rhs.m9,
                               lhs.m3 * rhs.m7 + lhs.m6 * rhs.m8 + lhs.m9 * rhs.m9);
        }

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
           return new Vector3(lhs.m1 * rhs.x + lhs.m4 * rhs.y + lhs.m7 * rhs.z,
                              lhs.m2 * rhs.x + lhs.m5 * rhs.y + lhs.m8 * rhs.z,
                              lhs.m3 * rhs.x + lhs.m6 * rhs.y + lhs.m9 * rhs.z);
        }
  
        public static Matrix3 operator *(Matrix3 lhs, float scalar)
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

            return lhs;
        }
        
        public static Matrix3 operator *(float scalar, Matrix3 rhs)
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

            return rhs;
        }

        public static Matrix3 CreateTransation(float x, float y)
        {

            //Matrix3 mat = Identity;

            //mat.m7 = x;
            //mat.m8 = y;

            //return mat;

            Matrix3 m = new Matrix3();
            m.m1 = 1; m.m4 = 0; m.m7 = x;
            m.m2 = 0; m.m5 = 1; m.m8 = y;
            m.m3 = 0; m.m6 = 0; m.m9 = 1;

            return m;
        }

        public static Matrix3 CreateTranslation(Vector3 vec)
        {
            Matrix3 m = new Matrix3();
            m.m1 = 1; m.m4 = 0; m.m7 = vec.x;
            m.m2 = 0; m.m5 = 1; m.m8 = vec.y;
            m.m3 = 0; m.m6 = 0; m.m9 = vec.z;

            return m;
        }

        public static Matrix3 CreateRotateX(float a)
        {

            //return new Matrix3(
                
            //    1,
            //    0,
            //    0,
                 
            //    0,
            //    MathF.Cos(a),
            //    MathF.Sin(a),
                
            //    0,
            //    -MathF.Sin(a),
            //     MathF.Cos(a)
            //    );

            Matrix3 m = new Matrix3();
            m.m1 = 1; m.m4 = 0; m.m7 = 0;
            m.m2 = 0; m.m5 = (float)MathF.Cos(a); m.m8 = (float)MathF.Sin(a);
            m.m3 = 0; m.m6 = (float)(-MathF.Sin(a)); m.m9 = (float)MathF.Cos(a);
            return m;
        }

        public static Matrix3 CreateRotateY(float a)
        {
            Matrix3 m = new Matrix3();
            m.m1 = (float)MathF.Cos(a); m.m4 = 0; m.m7 = (float)(-MathF.Sin(a));
            m.m2 = 0; m.m5 = 1; m.m8 = 0;
            m.m3 = (float)MathF.Sin(a); m.m6 = 0; m.m9 = (float)MathF.Cos(a);
            return m;
        }

        public static Matrix3 CreateRotateZ(float a)
        {
            Matrix3 m = new Matrix3();
            m.m1 = (float)Math.Cos(a); m.m4 = (float)Math.Sin(a); m.m7 =0;
            m.m2 = (float)(-Math.Sin(a)); m.m5 = (float)Math.Cos(a); m.m8 =0;
            m.m3 = 0; m.m6 = 0; m.m9 = 1;
            return m;
        }

        public static Matrix3 Euler(float pitch, float yaw, float roll)
        {
            return new Matrix3();
        }

        public static Matrix3 CreateScale(float xScale, float yScale)
        {

            //Matrix3 mat = Identity;

            //mat.m1 = xScale;
            //mat.m4 = yScale;

            //return mat;

            Matrix3 m = new Matrix3();
            m.m1 = xScale; m.m4 = 0; m.m7 = 0;
            m.m2 = 0; m.m5 = yScale; m.m8 = 0;
            m.m3 = 0; m.m6 = 0; m.m9 = 1;
            return m;
        }
        public static Matrix3 CreateScale(float xScale, float yScale, float zScale)
        {

            //Matrix3 mat = Identity;
            //mat.m1 = xScale;
            //mat.m4 = yScale;
            //mat.m9 = zScale;

            //return mat;

            Matrix3 m = new Matrix3();
            m.m1 = xScale; m.m4 = 0; m.m7 = 0;
            m.m2 = 0; m.m4 = yScale; m.m8 = 0;
            m.m3 = 0; m.m5 = 0; m.m9 = xScale;
            return m;

        }
        public static Matrix3 CreateScale(Vector3 scale)
        {



            Matrix3 m = new Matrix3();
            m.m1 = scale.x; m.m4 = 0; m.m7 = 0;
            m.m2 = 0; m.m4 = scale.y; m.m8 = 0;
            m.m3 = 0; m.m5 = 0; m.m9 = scale.z;
            return m;
        }

        public void SetTranslation(float x, float y)
        {
            m7 = x;
            m8 = y;
        }

        public void Translate(float x, float y)
        {

        }

        public Vector3 GetTranslation()
        {
            return new Vector3(m7, m8, m9);
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

        }
    

    // scales the existing matrix by a certain amount on each axis
        public void Scale(Vector3 v)
        {

        }

        public bool Equals(Matrix3 other)
        {
            if (MathF.Abs(m1 - other.m1) < 0.0001 &&
                MathF.Abs(m2 - other.m2) < 0.0001 &&
                MathF.Abs(m3 - other.m3) < 0.0001 &&
                MathF.Abs(m4 - other.m4) < 0.0001 &&
                MathF.Abs(m5 - other.m5) < 0.0001 &&
                MathF.Abs(m6 - other.m6) < 0.0001 &&
                MathF.Abs(m7 - other.m7) < 0.0001 &&
                MathF.Abs(m8 - other.m8) < 0.0001 &&
                MathF.Abs(m9 - other.m9) < 0.0001)
            {
                return true;
            }
            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj != null && this.Equals((Matrix3)obj);
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

            return hash.GetHashCode();
        }

        public override string ToString()
        {
            return m1.ToString(); m2.ToString(); m3.ToString(); m4.ToString(); m5.ToString(); m6.ToString(); m7.ToString(); m8.ToString(); m9.ToString();
        }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return m1;
                    case 1:
                        return m2;
                    case 3:
                        return m3;
                    case 4:
                        return m4;
                    case 5:
                        return m5;
                    case 6:
                        return m6;
                    case 7:
                        return m7;
                    case 8:
                        return m8;
                    case 9:
                        return m9;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        m1 = value;
                        break;
                    case 1:
                        m2 = value;
                        break;
                    case 3:
                        m3 = value;
                        break;
                    case 4:
                        m4 = value;
                        break;
                    case 5:
                        m5 = value;
                        break;
                    case 6:
                        m6 = value;
                        break;
                    case 7:
                        m7 = value;
                        break;
                    case 8:
                        m8 = value;
                        break;
                    case 9:
                        m9 = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
