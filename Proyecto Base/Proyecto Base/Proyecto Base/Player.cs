using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Player
    {
       
        private PlayerController playerController;
        private Transform playerTransform;

        private float posX, posY;

        public Player(float posX, float posY)
        {
           this.posX = posX;
           this.posY = posY;

              
            
        }

        private void update()
        {
       
            playerController.update();

        }



    }
}
