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
            player.Position += new Vector(10, 10);
            game.UpdatePcbWithEntity(player, (PictureBox)Controls.Find("pcbPlayer", false)[0]);
        }
    }
}