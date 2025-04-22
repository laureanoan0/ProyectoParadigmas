using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Transform
    {

        private int posX;
        private int posY;

        public int PosX => posX;
        public int PosY => posY;

     
        public Transform(int posX, int posY)
        {
        
            this.posX = posX;
            this.posY = posY;

        }

        public void translate(int valueX, int valueY)
        {

            this.posX += valueX;
            this.posY += valueY;

        }


    }
}
