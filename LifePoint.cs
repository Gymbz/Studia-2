using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektJPWPv2
{
    /// <summary>
    /// Klasa zawierająca serca, które można zbierać podczas gry, które odnawiają jedno życie.
    /// </summary>
    public class LifePoint
    {
        /// <summary>
        /// Pole zawierające wymiary serca.
        /// </summary>
        public Size dimensions = new Size(75, 75);

        /// <summary>
        /// Pole zawierające punkt, w którym znajduje się serce.
        /// </summary>
        public Point point = new Point(1600, 0);

        /// <summary>
        /// Pole przechowujące grafikę serca.
        /// </summary>
        Image img = global::ProjektJPWPv2.Properties.Resources._6Tr5eLnjc;

        /// <summary>
        /// Metoda rysująca serce na podstawie jego wymiarów i obrazka.
        /// </summary>
        public void Draw(Graphics g)
        {
            Rectangle hitbox = new Rectangle(point, dimensions);
            g.DrawImage(img, hitbox);
        }

        /// <summary>
        /// Pole generujące punkt, w którym pojawi się serce.
        /// </summary>
        public void GenerateSpawnPoint()
        {
            var gen = new Random();                                          
            point.X = gen.Next(250, 650);
            point.Y = 0;
        }
    }


}
