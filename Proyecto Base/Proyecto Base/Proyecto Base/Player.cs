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
        private Image playerSprite = Engine.LoadImage("assets/player.png");

        public Transform PlayerTransform => playerTransform;



       

        public Player(float posX, float posY)
        {
      
            
           playerTransform = new Transform(posX, posY);
           playerController = new PlayerController(playerTransform);
            
        }

        public void update()
        {
       
            playerController.update();

        }

        public void renderer()
        {

            Engine.Draw(playerSprite, PlayerTransform.PosX, PlayerTransform.PosY);

        }



    }
}
