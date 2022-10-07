using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public struct Color
    {
        public UInt32 color;

        public Color (byte red, byte green, byte blue, byte alpha)
        {
            color = ((UInt32)red << 24) | ((UInt32)green << 16) | ((UInt32)blue << 8) | alpha;
        }

        public byte Red
        {
            get
            {
                return (byte)(color >> 24);
            }
            set
            {
                color = (color & 0x00ffffff) | ((UInt32)value << 24);
            }
        }

        public byte Green
        {
            get
            {
                return (byte)(color >> 16);
            }
            set
            {
                color = (color & 0xff00ffff) | ((UInt32)(value << 16));
            }
        }

        public byte Blue
        {
            get
            {
                return (byte)(color >> 8);
            }
            set
            {
                color = (color & 0xffff00ff) | ((UInt32)(value << 8));
            }

        }

        public byte Alpha
        {
            get
            {
                return (byte)color;
            }
            set
            {
                color = color & 0xffffff00;
                color = color | value;
            }
        }
    }

}
