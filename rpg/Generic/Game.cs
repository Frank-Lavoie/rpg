using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg.Entities;

namespace rpg.Generic
{
    internal class Game
    {
        public void UpdatePcbWithCollidable(Collidable collidable, PictureBox pcb)
        {
            if (collidable == null || pcb == null)
                return;
            pcb.Location = new Point(collidable.Position.X, collidable.Position.Y);
            pcb.Image = collidable.Sprite;
            pcb.Size = new Size(collidable.Size.X, collidable.Size.Y);
        }
    }
}
