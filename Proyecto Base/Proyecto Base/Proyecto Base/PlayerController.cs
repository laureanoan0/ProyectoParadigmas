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
        private float speed = 4;
        private float gravity = 2;

        public PlayerController(Transform playerTransform)
        {
            this.playerTransform = playerTransform;
          
        }

        public void update()
        {

            playerTransform.translate(0, 1, gravity);

            if (Engine.GetKey(Engine.KEY_A))
            {
                playerTransform.translate(-1 , 0, speed);

            }
            if (Engine.GetKey(Engine.KEY_D))
            {
                playerTransform.translate(1 , 0, speed);
            }
            if (Engine.GetKey(Engine.KEY_ESP))
            {
                playerTransform.translate(0, -1, speed);

            }






        }


    }
}
