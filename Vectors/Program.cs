using Raylib_cs;
using Vectors;
using MathsLibrary;
//using System.Drawing;

public class Program
{
    public static Enemy enemy = new Enemy();
    public static int Main()
    {


        //Initialize - Load things
        const int screenW = 800;
        const int screenH = 450;

        Raylib.InitWindow(screenW, screenH, "Trigonomety in Raylib");
        Raylib.SetTargetFPS(60);

        List<GameObject> gameObjects = new List<GameObject>();
        gameObjects.Add(new GameObject());
        gameObjects.Add(new Player());
        gameObjects.Add(enemy);

        enemy.position = new Vector3(356, 67, 0);
        enemy.direction = new Vector3(1, 0, 0);


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

            Raylib.ClearBackground(Raylib_cs.Color.RAYWHITE);

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