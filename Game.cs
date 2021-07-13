using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProjektJPWPv2
{
    /// <summary>
    /// Klasa, w której odbywa się większość gry. Jest to najważniejsza klasa.
    /// </summary>
    public class Game                                   
    {
        private readonly Player player;                 
        private readonly GreenBall greenBall;
        private readonly YellowBall yellowBall;
        private readonly RedBall redBall;
        private readonly LifePoint lifePoint;

        /// <summary>
        /// Pole przechowujące pozostały czas gry.
        /// </summary>
        public int time =10;

        /// <summary>
        /// Pole, które odpowiada za dodawanie czasu podczas łapania piłek, wartość tego pola zmienia się wraz z poziomem trudności.
        /// </summary>
        public int time_add;

        /// <summary>
        /// Pole przechowujące wynik.
        /// </summary>
        public int score = 0;

        /// <summary>
        /// Pole przechowujące końcowy wynik (wynik + serca przemnożone przez odpowiedni współczynnik trudności).
        /// </summary>
        public int final_score;

        /// <summary>
        /// Pole przechowujące szybkość spadania piłek.
        /// </summary>
        public int ball_speed = 3;

        /// <summary>
        /// Pole przechowujące szybkość spadania serc.
        /// </summary>
        public int heart_speed = 1;

        /// <summary>
        /// Pole przechowujące ilość żyć gracza.
        /// </summary>
        public int player_lives = 3;

        /// <summary>
        /// Pole przechowujące treść pytania.
        /// </summary>
        public string question;

        /// <summary>
        /// Pole przechowujące odpowiedź wpisaną przez gracza.
        /// </summary>
        public int answer;

        /// <summary>
        /// Pole przechowujące prawidłową odpowiedź.
        /// </summary>
        public int correct_answer;

        /// <summary>
        /// Pole przechowujące czas na odpowiedź.
        /// </summary>
        public int question_timeleft;

        /// <summary>
        /// Pole przechowujące aktualną serię dobrze odpowiedzianych pytań.
        /// </summary>
        public int streak;

        /// <summary>
        /// Dodanie obiektów.
        /// </summary>
        public Game() 
        {
            player = new Player();
            greenBall = new GreenBall();
            yellowBall = new YellowBall();
            redBall = new RedBall();
            lifePoint = new LifePoint();
        }

        /// <summary>
        /// Metoda rysująca na planszy obiekty.
        /// </summary>
        public void Draw(Graphics g)                    //metoda draw umozliwia pojawianie sie elementow na ekranie
        {
            greenBall.Draw(g);
            yellowBall.Draw(g);
            redBall.Draw(g);
            lifePoint.Draw(g);
            player.Draw(g);
        }

        /// <summary>
        /// Metoda aktualizująca pozycję gracza.
        /// </summary>
        public void UpdatePlayerPostition(int x)
        {
            player.point.X = x;
        }

        /// <summary>
        /// Metoda odpowiadająca za ruch piłek i serc.
        /// </summary>
        public void BallDrop() 
        {
            greenBall.point.Y += ball_speed;
            yellowBall.point.Y += ball_speed;
            redBall.point.Y += ball_speed;
            lifePoint.point.Y += heart_speed;
        }

        /// <summary>
        /// Metoda sprawdzająca, czy złapano zieloną piłkę.
        /// </summary>
        public bool IsGreenBallCatched()
        {
            return (greenBall.point.X >= player.point.X && greenBall.point.Y >= player.point.Y && greenBall.point.Y <= (player.point.Y + (player.height/4)) && greenBall.point.X <= (player.point.X + player.width));
        }

        /// <summary>
        /// Metoda sprawdzająca, czy złapano żółtą piłkę.
        /// </summary>
        public bool IsYellowBallCatched()
        {
            return (yellowBall.point.X >= player.point.X && yellowBall.point.Y >= player.point.Y && yellowBall.point.Y <= (player.point.Y + (player.height / 4)) && yellowBall.point.X <= (player.point.X + player.width));
        }

        /// <summary>
        /// Metoda sprawdzająca, czy złapano czerwoną piłkę.
        /// </summary>
        public bool IsRedBallCatched()
        {
            return (redBall.point.X >= player.point.X && redBall.point.Y >= player.point.Y && redBall.point.Y <= (player.point.Y + (player.height / 4)) && redBall.point.X <= (player.point.X + player.width));
        }

        /// <summary>
        /// Metoda sprawdzająca, czy złapano serce.
        /// </summary>
        public bool IsLifePointCatched()
        {
            return (lifePoint.point.X >= player.point.X && lifePoint.point.Y >= player.point.Y && lifePoint.point.Y <= (player.point.Y + (player.height / 4)) && lifePoint.point.X <= (player.point.X + player.width)); ;
        }

        /// <summary>
        /// Metoda generująca łatwe pytanie.
        /// </summary>
        public void EasyQuestion() 
        {
            question_timeleft = 8;

            var rng = new Random();

            int wariant = rng.Next(0,4);
            int a = rng.Next(6, 11);
            int b = rng.Next(2, 6);
            int c = rng.Next(1, 5);

            switch (wariant)
            {
                case 0:
                    {
                        correct_answer = a + b;
                        question =  a + " + " + b + " = ? ";
                        break;
                    }
                case 1:
                    {
                        correct_answer = a - b;
                        question = a + " - " + b + " = ? ";
                        break;
                    }
                case 2:
                    {
                        correct_answer = a + b - c;
                        question = a + " + " + b + " - " + c + " = ? ";
                        break;
                    }
                case 3:
                    {
                        correct_answer = b + c;
                        question = b + " + " + c + " = ? ";
                        break;
                    }
            }

            }

        /// <summary>
        /// Metoda generująca średnie pytanie.
        /// </summary>
        public void MediumQuestion() 
        {
            question_timeleft = 10;
            var rng = new Random();

            int wariant = rng.Next(0, 4);
            int a = rng.Next(5, 9);
            int b = rng.Next(1, 8);
            int c = rng.Next(3, 6);
            int d = rng.Next(1, 4);

            switch (wariant)
            {
                case 0:
                    {
                        correct_answer = b * c;
                        question = b + " * " + c + " = ? ";
                        break;
                    }
                case 1:
                    {
                        correct_answer = (c*b)+a;
                        question = "( " + c + " * " + b + " )  + " +  a + " = ? ";
                        break;
                    }
                case 2:
                    {
                        correct_answer = (a + b) - (c+d);
                        question = "( " + a + " + " + b + " )  -  ( " + c + " + " + d + " )  = ? ";
                        if (correct_answer < 0)
                        {
                            correct_answer = (c + d) - (a + b);
                            question = "( " + c + " + " + d + " )  -  ( " + a + " + " + b + " )  = ? ";
                        }
                        
                        break;
                    }
                case 3:
                    {
                        correct_answer = c * d;
                        question = c + " * " + d + " = ? ";
                        break;
                    }
            }
        }

        /// <summary>
        /// Metoda generująca trudne pytanie.
        /// </summary>
        public void HardQuestion() 
        {
            question_timeleft = 12;
            var rng = new Random();

            int wariant = rng.Next(0, 3);
            int a = rng.Next(1, 31);
            int b = rng.Next(1, 11);
            int c = rng.Next(1, 10);
            int d = rng.Next(1, 6);

            switch (wariant)
            {
                case 0:
                    {
                        correct_answer = b * c + a;
                        question = b + " * " + c + " + " + a + " = ? ";
                        break;
                    }
                case 1:
                    {
                        correct_answer = (a + b) * d;
                        question = "( " + a + " + " + b + " )  * " + d + " = ? ";
                        break;
                    }
                case 2:
                    {
                        if (a > c)
                        {
                            do
                            {
                                c = c + 1;
                            } while (a % c != 0); //zabezpieczenie przed niepodzielnymi liczbami

                            correct_answer = a / c;
                            question = a + " / " + c + "  = ? ";
                        }
                        else
                        {
                            do
                            {
                                a = a + 1;
                            } while (c % a != 0); //zabezpieczenie przed niepodzielnymi liczbami

                            correct_answer = c/ a;
                            question = c + " / " + a + "  = ? ";

                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// Metoda sprawdzająca, czy odpowiedź podana przez gracza jest prawidłowa.
        /// </summary>
        public bool AnswerCheck()
        {
            return (answer == correct_answer);
        }

        /// <summary>
        /// Metoda odpowiadająca za sytuację, gdy gracz źle odpowiedział na pytanie, lub skonczył mu się czas na odpowiedź.
        /// </summary>
        public void WrongAnswerOrTimeEnd()
        {
            streak = 0;
            player_lives -= 1;
            player.lives = player_lives;
            System.IO.Stream str = Properties.Resources.answer_bad;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        /// <summary>
        /// Metoda odpowiadająca za sytuację, gdy gracz dobrze odpowiedział na pytanie.
        /// </summary>
        public void GoodAnswer()
        {
            if (IsGreenBallCatched())                               
            {
                score += 10 * bonus();
                time += time_add;
            }
            if (IsYellowBallCatched())                              
            {
                score += 25 * bonus();
                time += time_add;                 
            }
            if (IsRedBallCatched())
            {
                score += 50 * bonus();
                time += time_add*2;
            }
            streak += 1;                                    //za kazda dobra odpowiedz pod rząd rośnie seria, która daje bonus
            System.IO.Stream str = Properties.Resources.answer_good;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        /// <summary>
        /// Metoda naliczająca bonus w zależności od tego, na ile pytań udało się odpowiedzieć bezbłędnie.
        /// </summary>
        public int bonus()
        {
            int bonus;                                                //co 5 dobrych odpowiedzi mamy kolejny mnoznik
            if (streak < 5) bonus = 1;                          
            else if (streak >= 5 && streak < 10) bonus = 2;
            else if (streak >= 10 && streak < 20) bonus = 3;
            else bonus = 4;                                           //maksymalny mnoznik to x4
            return bonus;
        }


        /// <summary>
        /// Metoda, która zwraca obecny poziom, na podstawie wyniku gracza.
        /// </summary>
        public int Level()
        {
            if (score <= 100) return 1;
            else if (score <= 500) return 2;
            else if (score <= 800) return 3;
            else if (score <= 1500) return 4;
            else if (score <= 3000) return 5;
            else if (score <= 4000) return 6;
            else if (score <= 5000) return 7;
            else return 8;
        }


        /// <summary>
        /// Metoda "spawnująca" piłki, każdy kolejny poziom trudności wpływa na rozkład prawdopodobieństwa wystąpienia danego koloru piłki.
        /// </summary>
        public void SpawnBall(int difficulty)
        {
            var rng = new Random();
            int lvl = 0;
            switch (difficulty)
            {
                case 1:
                    {
                        lvl = rng.Next(0, 7);
                        ball_speed = 3;
                        time_add = 4;
                        break;
                    }
                case 2:
                    {
                        lvl = rng.Next(0, 11);
                        ball_speed = 4;
                        time_add = 3;
                        break;
                    }
                case 3:
                    {
                        lvl = rng.Next(3, 12);
                        ball_speed = 5;
                        time_add = 3;
                        break;
                    }
                case 4:
                    {
                        lvl = rng.Next(4, 12);
                        ball_speed = 6;
                        time_add = 2;
                        break;
                    }
                case 5:
                    {
                        lvl = rng.Next(4, 17);
                        ball_speed = 8;
                        time_add = 2;
                        break;
                    }
                case 6:
                    {
                        lvl = rng.Next(5, 20);
                        ball_speed = 10;
                        time_add = 1;
                        break;
                    }
                case 7:
                    {
                        lvl = rng.Next(8, 20);
                        ball_speed = 12;
                        time_add = 1;
                        break;
                    }
                case 8:
                    {
                        lvl = rng.Next(15, 30);
                        ball_speed = 15;
                        time_add = 1;
                        break;
                    }
            }
            if (lvl <= 5)greenBall.GenerateSpawnPoint();
            else if (lvl <= 15) yellowBall.GenerateSpawnPoint();
            else if (lvl <= 30) redBall.GenerateSpawnPoint();
            if (lvl == 15)                                              //mala szansa na wygenerowanie punktu zycia, ktory gracz moze zebrac aby odnowic sobie brakujace zycie (dopiero od 5 poziomu)
            {
                if (lifePoint.point.X == 1600)   lifePoint.GenerateSpawnPoint();
            }
        }



        /// <summary>
        /// Metoda przenosząca piłki poza grywalny obszar gry.
        /// </summary>
        public void RemoveBall()
        {
                greenBall.point.X = 1600;
                yellowBall.point.X = 1600;
                redBall.point.X = 1600;
        }
        /// <summary>
        /// Metoda przenosząca serca poza grywalny obszar gry.
        /// </summary>
        public void RemoveHeart()
        {
            lifePoint.point.X = 1600;
        }

        /// <summary>
        /// Metoda sprawdzająca, czy zielona piłka spadła poza planszę.
        /// </summary>
        public bool GreenBallFallDown()
        {
            return (greenBall.point.Y >= 1300 && greenBall.point.X < 850);          //gdy pilka akurat nie jest na ekranie gry (wspolrzedne X), to nas nie interesuje czy spadla czy nie
        }

        /// <summary>
        /// Metoda sprawdzająca, czy żółta piłka spadła poza planszę.
        /// </summary>
        public bool YellowBallFallDown()
        {
            return (yellowBall.point.Y >= 1300 && yellowBall.point.X < 850);
        }
        /// <summary>
        /// Metoda sprawdzająca, czy czerwona piłka spadła poza planszę.
        /// </summary>
        public bool RedBallFallDown()
        {
            return (redBall.point.Y >= 1300 && redBall.point.X < 850);
        }


        /// <summary>
        /// Metoda sprawdzająca, czy skończył się czas.
        /// </summary>
        public bool EndOfTime()                                 
        {
            if (time <= 0) return true;                         //jezeli 0, zwroc true
            else return false;                                  //jezeli nie 0, zwroc false
        }

        /// <summary>
        /// Metoda sprawdzająca, czy gra zakończyła się (w przypadku gdy skończył się czas lub utracono wszystkie życia).
        /// </summary>
        public bool Lost()                                      //warunek sprawdzający, czy gracz przegrał
        {
            return player.LostAllLifePoints() || EndOfTime();   //są dwie możliwe sytuacje porażki, koniec czasu lub utrata wszystkich żyć
        }

        /// <summary>
        /// Metoda przyznająca ocenę graczowi na podstawie zdobytych punktów, pozostałych żyć i poziomu, w którym zakończono grę.
        /// </summary>
        public String FinalMark()
        {
            final_score = score + player_lives * 20 * Level(); ;
            if (final_score <= 400) return "1";
            else if (final_score <= 700) return "2-";
            else if (final_score <= 1000) return "2";
            else if (final_score <= 1500) return "2+";
            else if (final_score <= 1800) return "3-";
            else if (final_score <= 2100) return "3";
            else if (final_score <= 2500) return "3+";
            else if (final_score <= 2800) return "4-";
            else if (final_score <= 3000) return "4";
            else if (final_score <= 3200) return "4+";
            else if (final_score <= 3500) return "5-";
            else if (final_score <= 4000) return "5";
            else if (final_score <= 5000) return "5+";
            else return "6";
        }

        /// <summary>
        /// Metoda, która rozpoczyna grę od początku.
        /// </summary>
        public void Restart()
        {
            player_lives = 3;
            player.lives = player_lives;
            score = 0;
            time = 10;
            RemoveBall();
            RemoveHeart();
            SpawnBall(Level());
        }
    }
}
