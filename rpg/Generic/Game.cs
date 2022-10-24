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

        public List<Collidable> GenerateMap()
        {
            List<Collidable> map = new List<Collidable>();
            int tileSize = 100;
            Vector size = new Vector(tileSize);

            for (int k = 0; k < 25; k++)
            {
                for (int i = 0; i < Toolbox.CanvasWidth / tileSize; i++)
                {
                    map.Add(new Wall(new Vector(i * tileSize, 0), size));
                    map.Add(new Wall(new Vector(i * tileSize, Toolbox.CanvasHeight - tileSize), size));
                }
                for (int i = 0; i < Toolbox.CanvasHeight / tileSize; i++)
                {
                    map.Add(new Wall(new Vector(0, i * tileSize), size));
                    map.Add(new Wall(new Vector(Toolbox.CanvasWidth - tileSize, i * tileSize), size));
                }
            }
            return map;
        }
    }
}
