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

        private Animation currentAnimation;


       

        public Player(float posX, float posY)
        {
      
            
           playerTransform = new Transform(posX, posY);
           playerController = new PlayerController(playerTransform);

            List<Image> images= new List<Image>();

            for (int i = 0; i < 15; i++)
            {
                Image imagen = Engine.LoadImage($"assets/runAnimation/{i}.png");
                images.Add(imagen);
            }

            currentAnimation = new Animation("runAnimation", images , 0.1f, true);
            
        }

        public void update()
        {
       
            playerController.update();
            currentAnimation.update();

        }

        public void renderer()
        {

            Engine.Draw(currentAnimation.CurrentImage, PlayerTransform.PosX, PlayerTransform.PosY);

        }



    }
}
