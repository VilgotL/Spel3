using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
    class Player : BaseClass
    {
        protected float speed = 4f;
        protected List<Bullet> bulletList = new List<Bullet>();
        public Player(Texture2D t, Vector2 p, Rectangle r): base(t, p, r)
        {
            texture = t;
            posision = p;
            rectangle = r;
        }

        public List<Bullet> BList
        {
            get { return bulletList; }
        }

        public override void Update()
        {
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.D))
                posision.X += speed;
            if (kstate.IsKeyDown(Keys.A))
                posision.X -= speed;
            rectangle.Location = posision.ToPoint();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
