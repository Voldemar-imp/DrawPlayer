using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(10, 10);

            renderer.DrawPlayer(player.PositionX, player.PositionY);
            Console.SetCursorPosition(0, 0);
        }
    }

    class Renderer
    {
        public void DrawPlayer(int positionX, int positionY, char simbol = '@')
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.WriteLine(simbol);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}
