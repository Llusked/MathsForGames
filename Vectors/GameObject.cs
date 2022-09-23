using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raylib_cs;

using MathsLibrary;

namespace Vectors
{
     public class GameObject
    {
        public Vector3 position;

        public virtual void Update()
        {
            if (position.x < 0f)
            {
                position.x = Raylib.GetScreenWidth();

            }
            if (position.x > Raylib.GetScreenWidth())
            {
                position.x = 0f;

            }
            if (position.y < 0f)
            {
                position.y = Raylib.GetScreenHeight();

            }
            if (position.y > Raylib.GetScreenHeight())
            {
                position.y = 0f;

            }
        }

        public virtual void Draw()
        {
            Raylib.DrawCircle((int)position.x, (int)position.y, 10, Color.BLACK);
        }
    }
}
