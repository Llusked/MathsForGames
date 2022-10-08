using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public static class MathsUtils
    {
        public const float DefaultToterance = 0.0001f;
        public static bool ApproximatelyEqual(float a, float b, float tolerance = DefaultToterance)
        {
            return MathF.Abs(a - b) < tolerance;
        }

        public static float AngleFrom2D(float x, float y)
        {
            return MathF.Atan2(y, x);
        }

        public const float Deg2Rad = MathF.PI * 2.0f / 360.0f;

        public const float Rad2Deg = 1.0f / Deg2Rad;

        public static int Clamp(int value, int min, int max)
        {
            if (value < min)
            {
                return min;
            }
            else if (value > max)
            {
                return max;
            }
            return value;
        }
    }
}
