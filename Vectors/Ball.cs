using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raylib_cs;

using MathsLibrary;

namespace Vectors
{
    public class Ball: GameObject
    {
        public Vector3 velocity;

        public override void Update()
        {
            base.Update();

            position += velocity * Raylib.GetFrameTime();
        }
    }
}
