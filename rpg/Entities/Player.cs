using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpg.Generic;

namespace rpg.Entities
{
    internal class Player:Entity
    {
        //Methods
        public Player():base(new Vector(200,200), new Vector(100, 100), new Vector(0, 0)) 
        { 
            Sprite = Image.FromFile("Sprites/player.jpg");
        }
    }
}
