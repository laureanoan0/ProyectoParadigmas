using System;
using System.Collections.Generic;
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

        private static List<Image> floors = new List<Image>();

        private static List<Enemy> enemies = new List<Enemy>();



        //private static Enemy newEnemy = new Enemy(200, 600);
        private static Image leftFloor = new Image("assets/piso.png");


        private static Image background = Engine.LoadImage("assets/fondo.png");
        private static Image floor = Engine.LoadImage("assets/piso.png");


        private static Player player;



        static void Main(string[] args)
        {
            Engine.Initialize();

            player = new Player(40, 500);

            enemies.Add(new Enemy(200, 600));
            enemies.Add(new Enemy(100, 600));
            // enemies.Add(new Enemy (100, 600));

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
            Engine.Draw(leftFloor, 10, 700);
            player.renderer();

            for (int i = 0; i < enemies.Count; i++)

            {
                enemies[i].renderer();
            }

            
            Engine.Show();

        }
    }
}