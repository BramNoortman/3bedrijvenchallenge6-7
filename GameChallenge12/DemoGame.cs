using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ExpressedEngine.ExpressedEngine;
using System.Windows.Forms;

namespace ExpressedEngine
{
    class DemoGame : ExpressedEngine.ExpressedEngine
    {
        Shape2D Player1;

        bool left;
        bool right;
        bool up;
        bool down;
        bool P;

        public DemoGame() : base(new Vector2(815,715),"Expressed Engine Demo"){}

        public override void Onload()
        {
            BackgroundColour = Color.Black;

            

            Player1 = new Shape2D(new Vector2(10, 10), new Vector2(20, 20), "Test");
        }

        public override void OnDraw()
        {

        }
        
        float x = 0.1f;
        float y = 0.1f;
        public override void OnUpdate()
        {
            if (up)
            {
                Player1.postition.Y -= 5f;
            }
            if (down)
            {
                Player1.postition.Y += 5f;
            }
            if (left)
            {
                Player1.postition.X -= 5f;
            }
            if (right)
            {
                Player1.postition.X += 5f;
            }
            if (P)
            {
                Console.WriteLine("What is the capital of France? ");
                Console.WriteLine("A. Paris");
                Console.WriteLine("B. London");
                Console.WriteLine("C. Rome");

                string userAnswer = Console.ReadLine();

                if (userAnswer == "A" || userAnswer == "a")
                {
                    Console.WriteLine("Correct! The capital of France is Paris.");
                }
                else if (userAnswer == "B" || userAnswer == "b")
                {
                    Console.WriteLine("Incorrect. The capital of France is not London.");
                }
                else if (userAnswer == "C" || userAnswer == "c")
                {
                    Console.WriteLine("Incorrect. The capital of France is not Rome.");
                }
                else
                {
                    Console.WriteLine("Invalid answer. Please select A, B or C.");
                    return;
                }
            }


        }
        

        

        public override void GetKeyDown(KeyEventArgs e)
        {
           if (e.KeyCode == Keys.W) { up = true; }
           if (e.KeyCode == Keys.S) { down = true; }
           if (e.KeyCode == Keys.A) { left  = true; }
           if (e.KeyCode == Keys.D) { right = true; }
           if (e.KeyCode == Keys.E) { P = true;  }
        }

        public override void GetKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { up = false; }
            if (e.KeyCode == Keys.S) { down = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.D) { right = false; }
            if (e.KeyCode == Keys.E) { P = false; }
        }
    }
}
