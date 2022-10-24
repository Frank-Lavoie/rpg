using rpg.Entities;
using rpg.Generic;
using System.Linq;

namespace rpg
{
    public partial class Main : Form
    {
        private Game game;
        private Player player;
        private List<Collidable> map;

        public Main()
        {
            InitializeComponent();

            Size = new Size(Toolbox.CanvasWidth + Toolbox.CanvasWidthBuffer, Toolbox.CanvasHeight + Toolbox.CanvasHeightBuffer);
            game = new Game();

            player = new Player();
            map = game.GenerateMap();

            CreateCollidable(player, Toolbox.PlayerPcbName);

            for(int i = 0; i < map.Count; i++)
                CreateCollidable(map[i], $"mapObject{i}");
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
            int buffer = 300;
            //List<Collidable> possibleCollidables = map.Where(x => x.Position.X > player.Position.X - buffer &&
            //x.Position.X < player.Position.X + buffer).ToList();
            player.Move(vector, map);
            game.UpdatePcbWithCollidable(player, Controls.OfType<PictureBox>().Where(x => x.Name == Toolbox.PlayerPcbName).First());
            //MessageBox.Show(player.Collides(wall).ToString());
        }
    }
}