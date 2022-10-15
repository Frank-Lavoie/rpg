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
        private Vector size;
        private Image sprite;

        //properties
        public Vector Position { get; set; }
        public Vector Size { get; set; }
        public Image Sprite { get; set; }

        //methods
        protected Collidable(int posX, int posY, int width, int height): this(new Vector(posX, posY), new Vector(width, height)){}

        protected Collidable() : this(0, 0, 100, 100) { }

        protected Collidable(Vector position, Vector size)
        {
            Position = position;
            Size = size;
        }
    }
}
