using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

using MathsLibrary;

namespace Vectors
{
    public class Player: GameObject
    {
        public override void Update()
        {
            base.Update();

            if(Raylib.IsKeyDown(KeyboardKey.KEY_W))
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

            if(position.x < 0f)
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

            if(Raylib.IsKeyPressed(KeyboardKey.KEY_F))
            {
                float dotted = direction.Dot(Program.enemy.direction);

                Console.WriteLine(dotted);
            }
        }
    }
}
