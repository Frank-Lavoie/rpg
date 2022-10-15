using rpg.Generic;

namespace rpg.Entities
{
    internal class Wall : Collidable
    {
        //Methods
        public Wall() : this(new Vector(0, 0), new Vector(100, 100)) { }


        public Wall(Vector position, Vector size): base(position, size)
        {
            Sprite = Image.FromFile("Sprites/player.jpg");
        }
    }
}
