using System;
using System.Data;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using Tao.Sdl;



namespace MyGame
{

    class Program
    {

        public static float deltaTime;
        public static DateTime startTime;
        private static float lastFrameTime;

        
        private static Image background = Engine.LoadImage("assets/fondo.png");

        private static Player player;



        static void Main(string[] args)
        {
            Engine.Initialize();

            player = new Player(40, 500);

            startTime = DateTime.Now;

            while (true)
            {
                {
                    var currentTime = (float)(DateTime.Now - startTime).TotalSeconds;
                    deltaTime = currentTime - lastFrameTime;
                    lastFrameTime = currentTime;
                }//Time Manager


                update();
                render();



                
            }

           
        }

        public static void update()
        {
            player.update();
            

        }

        public static void render()
        {
            Engine.Clear();
            Engine.Draw(background, 0, 0);
            player.renderer();
            Engine.Show();

        }
    }
}