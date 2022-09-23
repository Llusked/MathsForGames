using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raylib_cs;

using MathsLibrary;

namespace Vectors
{
    public class Person: GameObject
    {
        public Vector3 vector1;
        public Vector3 vector2;

        public override void Update()
        {
            base.Update();

            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                position.y -= 1f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                position.x -= 1f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                position.y += 1f;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                position.x += 1f;
            }
        }
    }
}
