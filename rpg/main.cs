using rpg.Entities;
using rpg.Generic;
using System.Linq;

namespace rpg
{
    public partial class Main : Form
    {
        private Game game;
        private Player player;
        private Wall wall;

        public Main()
        {
            InitializeComponent();

            Size = new Size(Toolbox.CanvasWidth, Toolbox.CanvasHeight);
            game = new Game();

            player = new Player();
            wall = new Wall(new Vector(300, 300), new Vector(100, 100));

            CreateCollidable(player, Toolbox.PlayerPcbName);
            CreateCollidable(wall, Toolbox.WallPcbName);
        }

        private void CreateCollidable(Collidable collidable, string name)
        {
            PictureBox pcb = new PictureBox() { Name = name };
            game.UpdatePcbWithCollidable(collidable, pcb);
            Controls.Add(pcb);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Vector vector = new Vector(0,0);
            switch (e.KeyCode)
            {
                case Keys.A: vector = new Vector(-10,   0); break;
                case Keys.W: vector = new Vector(  0, -10); break;
                case Keys.D: vector = new Vector( 10,   0); break;
                case Keys.S: vector = new Vector(  0,  10); break;
            }
            player.Position += vector;
            game.UpdatePcbWithCollidable(player, Controls.OfType<PictureBox>().Where(x => x.Name == Toolbox.PlayerPcbName).First());
        }
    }
}