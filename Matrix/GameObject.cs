using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using Raylib_cs;
using MathsLibrary;

namespace GameFramework
{
    public class GameObject
    {
        public Vector3 LocalPosition { get; set; }
        public float LocalRotation { get; set; }
        public Vector3 LocalScale { get; set; }

        protected GameObject parent = null;

        public GameObject Parent
        {
            get
            {
                return parent;
            }
            set
            {
                if(parent != null)
                {
                    parent.children.Remove(this);
                }

                if(value != null)
                {
                    value.children.Add(this);
                }
                parent = value;
            }
        }

        protected List<GameObject> children = new List<GameObject>();
        public int ChildCount
        {
            get
            {
                return children.Count;
            }
        }

        public GameObject GetChild(int index)
        {
            return children[index];
        }



        public Matrix3 LocalTransform
        {
            get
            {
                return Matrix3.CreateTranslation(LocalPosition) *
                       Matrix3.CreateRotateZ(LocalRotation) *
                       Matrix3.CreateScale(LocalScale.x, LocalScale.y);
            }
        }

        public Matrix3 GlobalTransform
        {
            get
            {
                if(parent != null)
                {
                    
                }
                else
                {
                    return LocalTransform;
                }
            }
        }

        public void Translate(float x, float y)
        {
            LocalPosition += new Vector3(x, y, 0);
        }

        public void Rotate(float rot)
        {
            LocalRotation += rot;
        }

        public void Scale(float xScaler, float yScaler)
        {
            LocalScale += new Vector3(xScaler, yScaler, 0);
        }

        // 
        // Gameplay Systems
        // 

        // FOR ENGINE USE - infrastructure etc. etc.
        public void Update(float deltaTime)
        {
            // TODO: if we had more stuff to do on Update, we'd do it here ...
            OnUpdate(deltaTime);

            foreach (var child in children)
            {
                child.Update(deltaTime);
            }
        }

        // FOR GAMEPLAY USE - gameplay mechanics
        protected virtual void OnUpdate(float deltaTime)
        {
            // TODO - override this in your types
        }

        public void Draw()
        {
            // TODO: if we had more stuff to do on Draw, we'd do it here ...
            OnDraw();
            foreach (var child in children) {child.Draw();}
                

        }

        protected virtual void OnDraw()
        {
            // TODO - override this in your types
        }
    }
}
