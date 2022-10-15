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
        public void UpdatePcbWithEntity(Entity entity, PictureBox pcb)
        {
            pcb.Location = new Point(entity.Position.X, entity.Position.Y);
            pcb.Image = entity.Sprite;
            pcb.Size = new Size(entity.Size.X, entity.Size.Y);
        }
    }
}
