using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {

        private Transform enemyTransform;
        private EnemyController enemyController;

        private Image enemySprite = Engine.LoadImage("assets/enemy.png");



        public Enemy(float posX, float posY) 
        {

            enemyTransform = new Transform(posX, posY);
            enemyController = new EnemyController(enemyTransform);
        }

        public void Update()
        {


        }

        public void renderer()
        {

            Engine.Draw(enemySprite, enemyTransform.PosX, enemyTransform.PosY);

        }
    }
}
