using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace Template
{
    class EnemyClass : BaseClass
    {
        protected static List<EnemyClass> enemyList = new List<EnemyClass>();
        protected static Stopwatch time = new Stopwatch();
        protected static int spawnTime = 2500;
        public static Texture2D standardEnemyTexture;
        public EnemyClass(Texture2D t, Vector2 p, Rectangle r): base(t, p, r)
        {
            texture = t;
            posision = p;
            rectangle = r;
        }
        
        public static List<EnemyClass> EnemyList
        {
            get { return enemyList; }
        }
        public static void StartTime()
        {
            time.Start();
        }

        public override void Update()
        {
            if (time.ElapsedMilliseconds > spawnTime)
            {
                time.Stop();
                time.Reset();
                enemyList.Add(new StandardEnemy(standardEnemyTexture, new Vector2(300, 0), new Rectangle(300, 0, 50, 50)));
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
