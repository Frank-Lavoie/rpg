using rpg.Entities;
using rpg.Generic;

namespace rpg
{
    public partial class Main : Form
    {
        private Game game;
        private Player player;
        public Main()
        {
            InitializeComponent();
            game = new Game();

            player = new Player();
            PictureBox pcbPlayer = new PictureBox() { Name = "pcbPlayer" };
            game.UpdatePcbWithEntity(player, pcbPlayer);
            Controls.Add(pcbPlayer);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            Vector vector = new Vector(0,0);
            switch (e.KeyCode)
            {
                case Keys.A: vector = new Vector(-10,   0);break;
                case Keys.W: vector = new Vector(  0, -10);break;
                case Keys.D: vector = new Vector( 10,   0); break;
                case Keys.S: vector = new Vector(  0,  10); break;
            }
            player.Position += vector;
            game.UpdatePcbWithEntity(player, (PictureBox)Controls.Find("pcbPlayer", false)[0]);
        }
    }
}