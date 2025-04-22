using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{

    /*struct Vector2
    {

       

        public float X;
        public float Y;

        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;

        }

    }*/

    public class Transform
    {
        private Vector2 position;

        public float PosX => position.X;
        public float PosY => position.Y;

       

     
        public Transform(float posX, float posY)
        {
             
            position = new Vector2(posX, posY);

        }

        public void translate(int valueX, int valueY)
        {

            position.X += valueX;
            position.Y += valueY;

        }


    }
}
