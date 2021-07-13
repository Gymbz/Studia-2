using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektJPWPv2
{
    /// <summary>
    /// Klasa reprezentująca postać, którą steruje gracz podczas gry.
    /// </summary>
    public class Player 
    {
        /// <summary>
        /// Pole przechowujące szerokość gracza.
        /// </summary>
        public int width = 150;

        /// <summary>
        /// Pole przechowujące wysokość gracza.
        /// </summary>
        public int height = 410;

        /// <summary>
        /// Pole przechowujące punkt, w którym znajduje się gracz.
        /// </summary>
        public Point point = new Point(440, 500);

        /// <summary>
        /// Pole przechowujące życia gracza.
        /// </summary>
        public int lives = 3;

        Image img = global::ProjektJPWPv2.Properties.Resources.awatar;

        /// <summary>
        /// Metoda ta rysuje postać za każdym razem gdy jest wywoływana w klasie Game.
        /// </summary>
        public void Draw(Graphics g)
        {
            Size dimensions = new Size(width, height);
            Rectangle hitbox = new Rectangle(point, dimensions);
            g.DrawImage(img, hitbox);
        }

        /// <summary>
        /// Metoda sprawdzająca, czy gracz stracił wszystkie punkty życia.
        /// </summary>
        public bool LostAllLifePoints()            
        {
            if (lives == 0) return true;            //jeżeli 0 żyć, zwróć true
            else return false;                      //jeżeli nie 0 żyć, zwróć false
        }
    }
}
