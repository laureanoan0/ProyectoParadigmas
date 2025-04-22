using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Tao.Sdl;



namespace MyGame
{

    class Program
    {

        public static float deltaTime;
        public static DateTime startTime;
        private static float lastFrameTime;

        private static Image pj = Engine.LoadImage("assets/player.png");
        private static Image background = Engine.LoadImage("assets/fondo.png");

        private static Player player;



        static void Main(string[] args)
        {
            Engine.Initialize();

            startTime = DateTime.Now;

            while (true)
            {
                {
                    var currentTime = (float)(DateTime.Now - startTime).TotalSeconds;
                    deltaTime = currentTime - lastFrameTime;
                    lastFrameTime = currentTime;
                }//Time Manager


              



                Engine.Clear();               
                Engine.Draw(background, 0, 0);
                Engine.Draw(pj, 0, 0);
                Engine.Show();
            }
        }
    }
}