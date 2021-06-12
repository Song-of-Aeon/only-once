
namespace TestGame
{
    using Microsoft.Xna.Framework.Graphics;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Collections;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Content;
    
    public abstract class GameObject 
    {
        //Type[] gameObjects;
        public Vector2 position;
        public Vector2 scale;
        public bool persistent = false;
        ArrayList gameObjects = new ArrayList();
        public GameObject()
        {
            Create();
            Game1.AddToStepList(this);
            position = new Vector2(0, 0);
        }
        
        public GameObject(int x, int y)
        {
            Create();
            Game1.AddToStepList(this);
            position = new Vector2(x, y);

        }
        
        private void Create()
        {
            //Console.Out.WriteLine(this.GetType());
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(Game1.padoru, position, Color.White);
        }

        public virtual void Step()
        {
            //should be nothing
        }

        public static Type getType()
        {
            return getType();
        }
        public static bool checkCollision(GameObject a, Rectangle b)
        {
            if (a.position.X < b.X + b.Width &&
            a.position.X + a.scale.X > b.X &&
            a.position.Y < b.Y + b.Height &&
            a.position.Y + a.scale.Y > b.Y)
            {
                // collision detected!
                return true;
            }
            return false;
        }
        public static bool checkCollision(GameObject a, GameObject b)
        {
            if (a.position.X < b.position.X + b.scale.X &&
            a.position.X + a.scale.X > b.position.X &&
            a.position.Y < b.position.Y + b.scale.Y &&
            a.position.Y + a.scale.Y > b.position.Y)
            {
                // collision detected!
                return true;
            }
            return false;
            //thanks mozilla for the code :)
        }
      
        public static bool checkCollision(GameObject a, Vector2 b) 
        {
            bool xCol = false;
            bool yCol = false;

            if (b.X > a.position.X && b.X < a.position.X + a.scale.X) { xCol = true; }
            if (b.Y > a.position.Y && b.Y < a.position.Y + a.scale.Y) { yCol = true; }


            if (xCol && yCol)
            {
                return true;
            }
            return false;
        }
        public static Vector2 GetCenter(GameObject obj)
        {
            return obj.position + (obj.scale / 2);
        }
       
    }
}

