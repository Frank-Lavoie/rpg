using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg.Generic;

namespace rpg.Entities
{
    internal abstract class Entity: Collidable
    {
        //attributes
        private Vector velocity;

        //properties
        public Vector Velocity { get; set; }

        //methods
        public Entity(Vector position, Vector size, Vector velocity):base(position, size)
        {
            Velocity = velocity;
        }

        public void Move(Vector movement, List<Collidable> collidables)
        {
            Vector oldPosition = Position;
            Position += movement;
            List<Collidable> inCollision = collidables.Where(x => x.Collides(this)).ToList();
            if (inCollision.Count > 0)
                Position = oldPosition;
        }
    }
}
