using System;
using Raylib_cs;

namespace Grafik
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(1800, 1000, "Hello TE!");

            Image xWing = Raylib.LoadImage(@"XWing.png");
            Texture2D xWingTexture = Raylib.LoadTextureFromImage(xWing);

            float x = 0;
            float y = 0;

            while (!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    x+= 1f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    x-= 1f;
                }

                if(Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    y+= 1f;
                }

                if(Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    y-= 1f;
                }

                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawCircle(400, 300, 100, Color.GRAY);
                Raylib.DrawCircle(400, 300, 50, Color.DARKGRAY);

                
                Raylib.DrawTexture(xWingTexture, (int) x, (int) y, Color.WHITE);
                Raylib.EndDrawing();

            }
        }
    }
}
