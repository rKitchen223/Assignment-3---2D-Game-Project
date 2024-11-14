// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;
using System.Xml.Schema;

// The namespace your code is in.
namespace Game10003
{    /// <summary>
     ///     Your game code goes inside this class!
     /// </summary>
    public class Game
    {
        // Place your variables here:

        
        Vector2 circleLoaction = new Vector2(200, 400);
        Vector2 LineSize = new Vector2(200, 100);
        Vector2 circleLastPosition;
        //float radius = 100;
        Vector2 forceOfGravity = new Vector2(200, 500);
        public int score = 0;
        public int ObstaclesSpeed = 25;
        //public float x;
        //public float y;
        Character character = new Character();
        Obstacles ob = new Obstacles();
        float TopX = 800;
        float UpperLeftX = 830;
        float UpperRightX = 815;
        float BottomLeftY = 331;
        float BottomRightY = 331;
        float BottomY = 316;


        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Shape Runner");

            TopX = 800;

            //Vector2 circleLoaction = Random.Vector2


        }



        public void Update()
        {
            //MouseVector = Input.GetMousePosition();
            Window.ClearBackground(Color.OffWhite);

            character.PlayerDraw();
            character.Jump();

            //x = 50;
            //y = 300;
            //radius = 30f;

            ob.DrawObstacles(TopX, BottomLeftY, UpperLeftX, BottomRightY, UpperRightX, BottomY);
            TopX -= 10;
            UpperLeftX -= 10;
            UpperRightX -= 10;

           
            
            Draw.FillColor = Color.Black;
            Draw.Line(0, 331, 800, 331);




            float leftSide = TopX;
            float rightSide = TopX + UpperLeftX;
            


        }

  

    }
}   



                       
            
        
    


                    

            

        
                












        
    



    











        




