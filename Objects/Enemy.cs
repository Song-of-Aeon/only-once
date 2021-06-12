using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.objects
{
    class Enemy : GameObject
    {
        int count = 0; //.learn enumerators and never do this again.
        public Enemy() : base()
        {
            Create();
        }

        public Enemy(int x, int y) : base(x, y)
        {
            Create();
        }

        private void Create()
        {

        }
        static Texture2D sprite;
        public static void LoadContent()
        {
            ContentManager content = TestGame.Game1.game.Content;
            sprite = content.Load<Texture2D>("enemy");
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position,Color.White);
            //base.Draw(spriteBatch);
        }
        public override void Step()
        {
            if(count == 4)
            {
                count = 0;
                float amount = 12;
                for (float i = 0.0f; i < amount; i++) {
                    Danmaku obj = new Danmaku((int)position.X, (int)position.Y, (me) =>
                    {
                        me.position.X += (float)(Math.Cos(me.rotation) * 4.0f);
                        me.position.Y += (float)(Math.Sin(me.rotation) * 4.0f);
                    },
                    (me, batch) =>
                    {/*
#pragma warning disable CS0618 // Type or member is obsolete
 batch.Draw(texture: Danmaku.sprite, destinationRectangle: new Rectangle(me.position.ToPoint(), me.scale.ToPoint()), color: Color.White, rotation: 0);//me.rotation);
#pragma warning restore CS0618 // Type or member is obsolete*/

                    });
                    obj.rotation = (float)(((i / amount) * ((float)Math.PI * 2.0f)) + (Math.Cos(Game1.framesSinceStart / 150.0f))*10.0f);
                }
            }
            count++;
            base.Step();
        }
    }
}
