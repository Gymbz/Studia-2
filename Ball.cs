using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektJPWPv2
{
    /// <summary>
    /// Klasa piłek, które pojawiają się w grze.
    /// </summary>
    public class Ball
    {
        /// <summary>
        /// Pole wymiary piłki obrazek.
        /// </summary>
        public Size dimensions = new Size(75, 75);          //latwy dostep do zmiany wymiarow pilki w razie potrzeby

        /// <summary>
        /// Pole przechowujące punkt, w którym piłka się znajduje.
        /// </summary>
        public Point point = new Point(1600, 0);            //ustawiamy zeby pilki sie pojawialy poza mapa, odpowiednie metody beda zmieniac ich startowy punkt
    }

    /// <summary>
    /// Klasa zielona piłka, która dziedziczy po piłce.
    /// </summary>
    public class GreenBall : Ball
    {
        /// <summary>
        /// Pole przechowujące obrazek.
        /// </summary>
        public Image img = global::ProjektJPWPv2.Properties.Resources.green_ball;

        /// <summary>
        /// Metoda rysująca piłkę na podstawie jej wymiarów i obrazka.
        /// </summary>
        public void Draw(Graphics g)
        {
            Rectangle hitbox = new Rectangle(point, dimensions);        //hitbox pilki w postaci prostokatu 
            g.DrawImage(img, hitbox);                                   //funkcja, ktora rysuje nasza pilke
        }

        /// <summary>
        /// Metoda generująca losowy punkt pojawienia się piłki.
        /// </summary>
        public void GenerateSpawnPoint()                                //generujemy losowy punkt, ktory miesci sie w ekranie gry
        {                                                               //przy pozostalych kolorach pilek kody sa identyczne, 
            var generator = new Random();                               //skopiowalem je, poniewaz potrzebowalem osobnych metod do kazdego koloru               
            point.X = generator.Next(50, 850);
            point.Y = 0;
        }

    }

    /// <summary>
    /// Klasa żółta piłka, która dziedziczy po piłce.
    /// </summary>
    public class YellowBall : Ball                                      //analogicznie jak dla pilki zielonej
    {
        /// <summary>
        /// Pole przechowujące obrazek.
        /// </summary>
        public Image img = global::ProjektJPWPv2.Properties.Resources.yellow_ball;

        /// <summary>
        /// Metoda rysująca piłkę na podstawie jej wymiarów i obrazka.
        /// </summary>
        public void Draw(Graphics g)
        {
            Rectangle hitbox = new Rectangle(point, dimensions);
            g.DrawImage(img, hitbox);
        }

        /// <summary>
        /// Metoda generująca losowy punkt pojawienia się piłki.
        /// </summary>
        public void GenerateSpawnPoint()
        {
            var generator = new Random();
            point.X = generator.Next(50, 850);
            point.Y = 0;
        }
    }

    /// <summary>
    /// Klasa czerwona piłka, która dziedziczy po piłce.
    /// </summary>
    public class RedBall : Ball
    {
        /// <summary>
        /// Pole przechowujące obrazek.
        /// </summary>
        public Image img = global::ProjektJPWPv2.Properties.Resources.red_ball;

        /// <summary>
        /// Metoda rysująca piłkę na podstawie jej wymiarów i obrazka.
        /// </summary>
        public void Draw(Graphics g)
        {
            Rectangle hitbox = new Rectangle(point, dimensions);
            g.DrawImage(img, hitbox);
        }

        /// <summary>
        /// Metoda generująca losowy punkt pojawienia się piłki.
        /// </summary>
        public void GenerateSpawnPoint()
        {
            var generator = new Random();
            point.X = generator.Next(50, 850);
            point.Y = 0;
        }
    }

}
