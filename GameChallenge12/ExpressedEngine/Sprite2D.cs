using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ExpressedEngine.ExpressedEngine
{ 
public class Sprite2D
{
        public Vector2 postition = null;
        public Vector2 Scale = null;
        public string Directory = "Sprites/Characters/correct/character_0001";
        public string Tag = "";
        public Bitmap Sprite = null;
        private Vector2 vector21;
        private Vector2 vector22;
        private string v;

        public Sprite2D(Vector2 vector21, Vector2 vector22, string v)
        {
            this.vector21 = vector21;
            this.vector22 = vector22;
            this.v = v;
        }

        public Sprite2D(Vector2 postition, Vector2 scale, string Directory, string tag)
        {  
        this.postition = postition;
        this.Scale = scale;
        this.Directory = Directory;
        this.Tag = tag;

        Image tmp = Image.FromFile($"Sprites/{Directory}.png");


        Bitmap Sprite = new Bitmap(tmp,(int)this.Scale.X,(int) this.Scale.Y);
        Sprite = Sprite;

        Log.Info($"[SHAPE2D]({Tag}) - Has Been Registerd");
        ExpressedEngine.RegisterSprite(this);
        Tag = tag;
        }
    public void DestroySelf()
        {
        ExpressedEngine.UnRegisterSprite(this);
        }
    }
}