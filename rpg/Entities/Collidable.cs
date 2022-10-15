using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg.Generic;

namespace rpg.Entities
{
    internal abstract class Collidable
    {
        //atributes
        private Vector position;
        private Vector size = new Vector(0, 0);
        private Image sprite;

        //properties
        public Vector Position 
        {
            get { return position; }
            set
            {
                int x = Math.Min(Toolbox.CanvasWidth - size.X, Math.Max(0, value.X));
                int y = Math.Min(Toolbox.CanvasHeight - size.Y, Math.Max(0, value.Y));
                position = new Vector(x, y);
            }
        }
        public Vector Size { get { return size; } set { size = value; } }
        public Image Sprite { get { return sprite; } set { sprite = value; } }

        //methods
        protected Collidable(int posX, int posY, int width, int height): this(new Vector(posX, posY), new Vector(width, height)){}

        protected Collidable() : this(0, 0, 100, 100) { }

        protected Collidable(Vector position, Vector size)
        {
            Size = size;
            Position = position;
        }
    }
}
