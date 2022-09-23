using Raylib_cs;
//using System.Drawing;

public class Program
{
    public static void DrawCircle(int centerX, int centerY, int radius, Color color)
    {
        const int lineSegments = 78;

        float stepSize = (MathF.PI * 2) / lineSegments;

        for(int i = 0; i < lineSegments; i++)
        {
            int startX = (int)(radius * MathF.Cos(stepSize * i));
            int startY = (int)(radius * MathF.Sin(stepSize * i));

            //Raylib.DrawCircle(startX + centerX, centerY + startY, radius, color);

            int endX = (int)(radius * MathF.Cos(stepSize * (i+1)));
            int endY = (int)(radius * MathF.Sin(stepSize * (i+1)));

            Raylib.DrawLine(centerX + startX, centerY + startY, centerX + endX, centerY + endY, color);
        }
    }

    public static int[] GetCirclePoints(int centerX, int centerY, int radius, int lineSegments, float offset = 0.0f)
    {
        int[] points = new int[lineSegments * 2];

        float stepSize = (MathF.PI * 2) / lineSegments;

        for (int i = 0;i < lineSegments;i++)
        {
            int startX = (int)(radius * MathF.Cos(stepSize * i + offset));
            int startY = (int)(radius * MathF.Sin(stepSize * i + offset));

            points[i*2] = startX + centerX;
            points[i*2+1] = startY + centerY;


        }
        return points;
    }

    public static int Main()
    {
        //Initialize - Load things
        const int screenW = 800;
        const int screenH = 450;

        Raylib.InitWindow(screenW, screenH, "Trigonomety in Raylib");
        Raylib.SetTargetFPS(60);

        int[] points = GetCirclePoints(200, 200, 60, 8);

        //this is how you can enter a photo into vs

        Texture2D texture = Raylib.LoadTexture(@"res/Circle.png");

        //need to create a 'res' folder and put the image into it
        //photo needs to be in the under the specific folder 
        //this will only work if you move your 'res' folder into the 'bin' folder

        float rectXpos = screenW / 2;
        float rectYpos = screenH / 2;

        float angle = 0.0f;

        //Game loop - THE game
        while(!Raylib.WindowShouldClose())
        {

            //void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);


            //Update
            //if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
            //{
            //    rectXpos -= 1;
            //}
            //if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            //{
            //    rectXpos += 1;
            //}
            //if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            //{
            //    rectYpos -= 1;
            //}
            //if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            //{
            //    rectYpos += 1;
            //}

            angle += Raylib.GetFrameTime() * 4;

            float offsetX = 90 * MathF.Sin(angle);
            float offsetY = 90 * MathF.Cos(angle);

            //Draw
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.RAYWHITE);

            Raylib.DrawTexture(texture, 100, 100, Color.WHITE);
            //to print the texture into the thing

            Raylib.DrawCircleLines(screenW / 2, screenH / 2, 100.0f, Color.BLACK);

            Raylib.DrawRectangle((int)(rectXpos + offsetX), (int)(rectYpos + offsetY), 25, 25, Color.BLACK);

            DrawCircle(200, 200, 60, Color.BLACK);

            for (int i = 0; i < points.Length / 2; i++)
            {
                Raylib.DrawCircle(points[i * 2], points[i * 2 + 1], 8, Color.RED);
            }

            Raylib.EndDrawing();
        }

        //Deinitialize - Cleaning up
        Raylib.CloseWindow();

        return 0;
    }
}