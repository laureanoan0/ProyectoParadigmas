using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class PlayerController
    {
        private Transform playerTransform;
        private int speed = 4;

        public PlayerController(Transform playerTransform)
        {
            this.playerTransform = playerTransform;
          
        }

        public void update()
        {

            if (Engine.GetKey(Engine.KEY_A))
            {
                playerTransform.translate(-1 * speed, 0);

            }
            if (Engine.GetKey(Engine.KEY_D))
            {
                playerTransform.translate(1 * speed, 0);
            }
            if (Engine.GetKey(Engine.KEY_ESP))
            {
                playerTransform.translate(0, -1 * speed);

            }






        }


    }
}
