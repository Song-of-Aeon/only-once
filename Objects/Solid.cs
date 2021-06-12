using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.objects
{
    class Solid : GameObject
    {
        public static Texture2D sprite;
        public Solid(int x, int y) : base(x, y)
        {
            Create();
        }
        
        private void Create()
        {

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, Color.White);
        }
        public override void Step()
        {
            base.Step();
        }
        public static void LoadContent()
        {
            ContentManager content = TestGame.Game1.game.Content;
            sprite = content.Load<Texture2D>("solid");
        }
    }
}