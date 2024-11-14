using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Game10003
{
    public class Obstacles()
    {


        Vector2 circleLoaction = new Vector2(200, 200);
        int circleRadius = 10;
        Vector2 circleLastPosition;
        float circleDirection = 100f;

        public void DrawObstacles(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            
            int[] numberofTriangles = new int[50];

            for (int i = 0; i < numberofTriangles.Length; i++)
            {
                numberofTriangles[i] = i;
                Draw.Triangle(x1, y1, x2, y2, x3, y3);
                Draw.FillColor = Color.Red;
                

            }
        }
    }
}


        
    




        
        
    






        

        
    

        
    
   




    
    

