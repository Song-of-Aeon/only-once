using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.objects
{
    class Danmaku : GameObject
    {
        Action<Danmaku> danmakuStep;
        Action<Danmaku,SpriteBatch> danmakuDraw;
        public float rotation;
        public static Texture2D sprite;
        public float speed = 3;
        public Vector2 realPos;

        public static void LoadContent()
        {
            sprite = Game1.game.Content.Load<Texture2D>("damnMaku");
        }
        public Danmaku(int x, int y, Action<Danmaku> s, Action<Danmaku,SpriteBatch> d) : base(x, y)
        {
            realPos.X = x;
            realPos.Y = y;
            Create(s, d);
        }
        

        public Danmaku(Action<Danmaku> s,Action<Danmaku,SpriteBatch> d) //just having fun
        {
            Create(s, d);
        }

        private void Create(Action<Danmaku> s, Action<Danmaku,SpriteBatch> d)
        {
            danmakuStep = s;
            danmakuDraw = d;
            scale = new Vector2(sprite.Width, sprite.Height);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            danmakuDraw(this,spriteBatch);
            spriteBatch.Draw(sprite, position,Color.White);
            base.Draw(spriteBatch);
        }
        public override void Step()
        {
            
            if(!GameObject.checkCollision(this,new Microsoft.Xna.Framework.Rectangle(0, 0, 800, 600)))
            {
                Game1.RemoveFromStepList(this);
            }
            danmakuStep(this);
            base.Step();
        }
    }
}
