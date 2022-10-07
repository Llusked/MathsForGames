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

        public Vector3 direction = new Vector3(1,0,0);

        public virtual void Update()
        {
            
        }

        public virtual void Draw()
        {
            Raylib.DrawCircle((int)position.x, (int)position.y, 10, Raylib_cs.Color.BLACK);
            Vector3 endDirection = direction * 15 + position;
            Raylib.DrawLine((int)position.x, (int)position.y, (int)endDirection.x, (int)endDirection.y, Raylib_cs.Color.DARKBLUE);
        }
    }
}
