using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TestGame.objects
{
    class Player : GameObject
    {
        float hspd = 0;
        float vspd = 0;
        int hput = 0;
        int vput = 0;
        int speed = 8;
        bool aerial = false;
        static Texture2D playerSprite;
        static Texture2D padoru;
        static List<IEnumerator> coroutineList;

        public Player() : base()
        {
            Create();
        }

        public Player(int x, int y) : base(x, y)
        {
            Create();
        }

        public void Create()
        {
            //coroutineKTest()
            coroutineList = new List<IEnumerator>();
            coroutineList.Add(Test().GetEnumerator());
          scale.X = playerSprite.Width;
            scale.Y = playerSprite.Height;
        }
        public static void LoadContent()
        {
            ContentManager content = TestGame.Game1.game.Content;
            playerSprite = content.Load<Texture2D>("shooty");
            padoru = content.Load<Texture2D>("damnMaku");
            //base.LoadContent(content);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(playerSprite, position, Color.White);
            if (speed == 3)
            {
                spriteBatch.Draw(padoru, position + (scale / 2) - (new Vector2(padoru.Width, padoru.Height) / 2), Color.White);
            }
            //base.Draw(spriteBatch);
        }
        public override void Step()
        {

            foreach (IEnumerator e in coroutineList)
            {
                e.MoveNext();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left)) hput = -1;
            else if (Keyboard.GetState().IsKeyDown(Keys.Right)) hput = 1;
            else hput = 0;
            if (Keyboard.GetState().IsKeyDown(Keys.Up)) vput = -1;
            else if (Keyboard.GetState().IsKeyDown(Keys.Down)) vput = 1;
            else vput = 0;
            hspd = hput * 5;
            aerial = true;
            /*foreach (Solid obj in Game1.stepList.OfType<Solid>())
            {
                int hboxSize = 9999;
                if (GameObject.checkCollision(obj, new Rectangle((position + scale / 2).ToPoint() - new Vector2(hboxSize / 2).ToPoint(), new Point(hboxSize / 2))))
                {
                    aerial = false;
                }
            }*/
            if (position.Y > 500) {
                vspd = 0;
                if (Game1.KeysPressed(Keys.S)) vspd = -7;
            } else {
                vspd += 0.3f;
            }
            
            position.X += hspd;
            position.Y += vspd;
            foreach (Danmaku obj in Game1.stepList.OfType<Danmaku>())
            {
                int hboxSize = 4;
                if (GameObject.checkCollision(obj, new Rectangle((position + scale / 2).ToPoint() - new Vector2(hboxSize / 2).ToPoint(), new Point(hboxSize / 2))))
                {
                    foreach (Danmaku obj2 in Game1.stepList.OfType<Danmaku>())
                    {
                        Game1.RemoveFromStepList(obj2);
                    }
                    break;
                }
            }
            base.Step();
        }
        IEnumerable Test()
        {
            int i = 0;
            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
                yield return 0;
            }
        }
    }
}
