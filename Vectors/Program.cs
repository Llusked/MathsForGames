using Raylib_cs;
using Vectors;
using MathsLibrary;
//using System.Drawing;

public class Program
{
    public static int Main()
    {
        //Initialize - Load things
        const int screenW = 800;
        const int screenH = 450;

        Raylib.InitWindow(screenW, screenH, "Trigonomety in Raylib");
        Raylib.SetTargetFPS(60);

        List<GameObject> gameObjects = new List<GameObject>();
        gameObjects.Add(new GameObject());
        gameObjects.Add(new Person());
        //gameObjects.Add(new Player());

        Ball ball = new Ball();
        ball.velocity = new Vector3(15, 30, 0);

        //Game loop - THE game
        while (!Raylib.WindowShouldClose())
        {
            foreach(GameObject gamObj in gameObjects)
            {
                gamObj.Update();
            }
            ball.Update();

            //Draw
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.RAYWHITE);

            foreach (GameObject gamObj in gameObjects)
            {
                gamObj.Draw();
            }
            ball.Draw();

            Raylib.EndDrawing();
        }

        //Deinitialize - Cleaning up
        Raylib.CloseWindow();

        return 0;
    }
}