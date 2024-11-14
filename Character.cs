using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading;
using Game10003;

namespace Game10003;

public class Character
{
    static Game game = new Game();

    public float x = 50f;
    public float y = 300f;
    public float radius = 30f;
    public float circleCenterX = 50f;
    public float circleCenterY = 300f;
    public float circleradius = 30f;
    
    public void PlayerDraw()
    {
        Draw.FillColor = Color.Blue;
        Draw.Circle(x, y, radius);
    }

    public void Jump()
    {
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
        {
            y = y - 50f;
        }
        else if (Input.IsKeyboardKeyReleased(KeyboardInput.Space))
        {
            y = y + 50f;
        }
    }
    public void Collison()
    {
        //if (x > game.TX1 && mouseX < rectX + rectWidth && mouseY > rectY && mouseY < rectY + rectHeight
    }
}

       
      
    
