using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektJPWPv2
{
    /// <summary>
    /// Klasa wyświetlająca grę.
    /// </summary>
    public partial class Okno : Form
    {
        private readonly Color BackgroundColor = Color.Transparent;
        private readonly Bitmap bitmap;
        private readonly Graphics graphics;
        private readonly Game game;

        bool moveleft, moveright;
        int speed = 20;
        int currentX = 440;

        /// <summary>
        /// Inicjujemy wszystkie potrzebne rzeczy, uruchamiamy timery itd.
        /// </summary>
        public Okno()
        {
            InitializeComponent();
            bitmap = new Bitmap(1280, 1024);
            graphics = Graphics.FromImage(bitmap);
            graphics.PageUnit = GraphicsUnit.Pixel;
            game = new Game();
            game.SpawnBall(game.Level());
            time_left_display.Text = Convert.ToString(game.time) + " sek.";
            time_left_bar.Value = game.time;
            timerMain.Start();
            timeCount.Start();
        }

        private void timeCount_Tick(object sender, EventArgs e)                     //licznik czasu, z interwałem ustawionym na 1 sekundę
        {
            game.time -= 1;                                                         //z każdym tickiem odejmowana jest sekunda na wyswietlaczu pozostalego czasu
            time_left_display.Text = Convert.ToString(game.time) + " sek.";
            time_left_bar.Value = game.time;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            game.BallDrop();                                                        //ruch piłki w dół 

            if (game.player_lives == 3)                         //sekcja odpowiedzialna za wyswietlanie serduszek (ilosc zyc)
            {
                life3.Visible = true;
                life2.Visible = true;
                life1.Visible = true;
            }
            if (game.player_lives == 2)
            {
                life3.Visible = false;
                life2.Visible = true;
                life1.Visible = true;
            }
            if (game.player_lives == 1)
            {
                life3.Visible = false;
                life2.Visible = false;
                life1.Visible = true;
            }
            if (game.player_lives == 0)
            {
                life3.Visible = false;
                life2.Visible = false;
                life1.Visible = false;
            }

            if (moveleft == true && currentX >= 0)      // ta sekcja odpowiada za ruch postaci
            {
                currentX -= speed;                      //ruch w lewo o <speed>
                game.UpdatePlayerPostition(currentX);   //metoda aktualizująca pozycję gracza
            }
            if (moveright == true && currentX <= 900)
            {
                currentX += speed;                      //ruch w prawo <speed>
                game.UpdatePlayerPostition(currentX);   //metoda aktualizująca pozycję gracza
            }
            if (game.IsGreenBallCatched())              //sprawdzamy czy zielona piłka jest złapana
            {                                           //jeżeli tak, to: 
                moveleft = false;                       //ustawiamy poruszanie sie na false, bez tego pojawia sie blad - jezeli przed zlapaniem pilki poruszalismy sie w lewo lub w prawo to po zlapaniu automatycznie bylo na true
                moveright = false;
                timerMain.Stop();                       //zatrzymujemy timer odpowiedzialny za ruchome elementy ekranu (zamrażamy je)
                timeCount.Stop();                       //zatrzymujemy również timer, który odpowiada za wyświetlanie czasu na panelu po prawej
                question.BackColor = Color.Lime;        //zielona piłka, zielone tło pytania
                question.Visible = true;                //panel pytania ustawiamy na widoczny
                game.EasyQuestion();                    //generujemy losowe łatwe pytanie
                questionTime.Text = "Pozostały Czas: " + Convert.ToString(8);
                question_text.Text = game.question;     //wyswietlamy tresc pytania
                timerQuestion.Start();                  //odliczamy czas 
                answerBox.Enabled = true;               //włączamy wszystkie elementy panelu pytania 
                enter.Enabled = true;
                answerBox.Focus();                      //textbox ustawiamy tak, aby miał focus (żeby nie trzeba było klikać na niego myszką)
            }
            if (game.IsYellowBallCatched())             //w przypadku pozostałych piłek wszystko dzieje się analogicznie, z małymi różnicami
            {
                moveleft = false;
                moveright = false;
                timerMain.Stop();
                timeCount.Stop();
                question.BackColor = Color.Yellow;
                question.Visible = true;
                game.MediumQuestion();
                questionTime.Text = "Pozostały Czas: " + Convert.ToString(10);
                timerQuestion.Start();
                question_text.Text = game.question;
                answerBox.Enabled = true;
                enter.Enabled = true;
                answerBox.Focus();
            }
            if (game.IsRedBallCatched())
            {
                moveleft = false;
                moveright = false;
                timerMain.Stop();
                timeCount.Stop();
                question.BackColor = Color.Red;
                question.Visible = true;
                game.HardQuestion();
                questionTime.Text = "Pozostały Czas: " + Convert.ToString(12);
                timerQuestion.Start();
                question_text.Text = game.question;
                answerBox.Enabled = true;
                enter.Enabled = true;
                answerBox.Focus();
            }
            if (game.IsLifePointCatched())                          //dodatkowe serca beda spadac od czasu do czasu, gdyz momentami gra sie robi naprawde ciezka
            {
                System.IO.Stream str = Properties.Resources.gain_lifepoint;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                if (game.player_lives < 3) game.player_lives += 1;  // jezeli mamy juz 3 zycia to nie dostajemy 4
                else game.score += 100;                             //zamiast tego dostaniemy bonusowe punkty
                game.RemoveHeart();
            }
            if (game.GreenBallFallDown())                           //jezeli nie zlapiemy pilki
            {
                game.streak = 0;                                    //tracimy serie przez co rowniez tracimy bonus
                bonus_display.Visible = false;
                game.RemoveBall();                                  //usuwamy pilke poza mape 
                game.SpawnBall(game.Level());                      //generujemy pilce nowy punkt spawnu (losowany jest tez kolor pilki na podstawie poziomu
                game.time -= 2;                                     //kara czasowa za nie zlapanie pilki
            }
            if (game.YellowBallFallDown())                          //analogicznie jak dla zielonej pilki
            {
                game.streak = 0;
                bonus_display.Visible = false;
                game.RemoveBall();
                game.SpawnBall(game.Level());
                game.time -= 3;
            }
            if (game.RedBallFallDown())
            {
                game.streak = 0;
                bonus_display.Visible = false;
                game.RemoveBall();
                game.SpawnBall(game.Level());
                game.time -= 5;
            }

            level_display.Text = "Poziom " + Convert.ToString(game.Level());    //wyswietlanie obecnego poziomu 
            score_display.Text = Convert.ToString(game.score);                  //wyswietlanie obecnej ilosci punktow gracza

            if (game.streak >= 5)                                               //jezeli zlapiemy 5 pilek, i odpowiemy bezblednie na pytanie zawarte w nich
            {
                bonus_display.Visible = true;                                   //wyswietla sie mnoznik bonusu 
                bonus_display.Text = "x" + Convert.ToString(game.bonus());
            }

            if (game.Lost())                                                    //gdy gra sie skonczy 
            {
                play_again.Enabled = true;
                System.IO.Stream str = Properties.Resources.endgame;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                timerMain.Stop();                                               //zatrzymujemy liczniki czasu
                timeCount.Stop();
                timerQuestion.Stop();
                endgame.Visible = true;
                lives_final.Text = Convert.ToString(game.player_lives);
                score_final.Text = Convert.ToString(game.score);
                final_mark.Text = "Ocena " + game.FinalMark();
            }
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;             //zapobieganie "miganiu" ruchomych elementów
            graphics.Clear(BackgroundColor);        //rysujemy wszystkie elementy, ktore stanowia najwazniejsza czesc gry
            game.Draw(graphics);                    //elementy sa na nowo rysowane co 1 ms, tak jak jest ustawione w interwale timerMain
            e.Graphics.DrawImage(bitmap, 0, 0);     //"plansza" gry
        }


        private void timerQuestion_Tick(object sender, EventArgs e)                             //timer, ktory uruchamia sie podczas odpowiadania na pytanie
        {
            if (game.question_timeleft == 0)                                                    //jezeli skonczy sie czas na odpowiedzenie na pytanie
            {
                game.WrongAnswerOrTimeEnd();                                                    //traktujemy to po prostu jako zla odpowiedz
                bonus_display.Visible = false;
                QuestionAnswered();                                                             //metoda question answer jest opisana nizej
            }
            game.question_timeleft -= 1;                                                        //zliczamy czas w dol
            questionTime.Text = "Pozostały Czas: " + Convert.ToString(game.question_timeleft);  //wyswietlamy


        }

        private void enter_Click(object sender, EventArgs e)                                    //mozemy zarowno "wyslac" odpowiedz klikajac specjalny przycisk na ekranie
        {
            if (answerBox.TextLength > 0)                                                        //nie da sie wyslac pustej odpowiedzi, musimy cokolwiek napisac
            {
                game.answer = Convert.ToInt32(answerBox.Text);                                  //tekst konwertujemy do zmiennej calkowitej int32
                if (game.AnswerCheck()) game.GoodAnswer();                                      //sprawdzamy czy odpowiedz, ktora podalismy jest dobra, jezeli tak to aktywujemy metode, ktora wyznacza odpowiednia nagrode
                else
                {
                    game.WrongAnswerOrTimeEnd();                                                //jezeli odpowiedz zla, to aktywujemy metode, ktora odbiera jedno zycie
                    bonus_display.Visible = false;
                }
                QuestionAnswered();

            }
        }
        private void answerBox_KeyPress(object sender, KeyPressEventArgs e)                     //lub wciskajac ENTER na klawiaturze
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (answerBox.TextLength > 0)                                                   //wszystko tak samo jak w metodzie powyzej
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(answerBox.Text, "[^0-9]"))        //zabezpiecznie przed wpisywaniem znakow innych niz cyfry
                    {
                        MessageBox.Show("Podaj tylko liczby.");                                        //odpowiedni komunikat
                        answerBox.Text = answerBox.Text.Remove(answerBox.Text.Length - 1);
                    }
                    else
                    {
                        game.answer = Convert.ToInt32(answerBox.Text);
                        if (game.AnswerCheck()) game.GoodAnswer();
                        else
                        {
                            game.WrongAnswerOrTimeEnd();
                            bonus_display.Visible = false;
                        }
                        QuestionAnswered();
                    }
                }
            }

        }
        private void QuestionAnswered()                                                        //metoda aktywuje sie po odpowiedzeniu na pytanie, lub po zakonczeniu czasu
        {                                                                                      //niezaleznie, czy byla dobra czy zla odpowiedz
            time_left_display.Text = Convert.ToString(game.time) + " sek.";                    //wyswietlamy zaaktualizowany czas
            time_left_bar.Value = game.time;
            question.Visible = false;                                                          //okno z pytaniem ustawiamy na niewidoczne
            answerBox.Clear();                                                                 //czyscimy textbox, zeby przy nastepnym pytaniu byl pusty
            answerBox.Enabled = false;                                                         //wylaczamy niepotrzebne elementy
            enter.Enabled = false;
            timerMain.Start();                                                                 //wznawiamy timery
            timeCount.Start();
            timerQuestion.Stop();                                                              //zatrzymujemy timer pytan
            game.RemoveBall();                                                                 //usuwamy pilke
            game.SpawnBall(game.Level());                                                      //spawnujemy nowa
        }



        private void Okno_KeyDown(object sender, KeyEventArgs e)                               //metoda, odpowiadajaca za sytuacje, gdy mamy wcisniete klawisze strzalek
        {
            if (e.KeyCode == Keys.Left)
            {
                moveleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveright = true;
            }
        }

        private void play_again_Click(object sender, EventArgs e)
        {
            endgame.Visible = false;
            game.Restart();
            time_left_display.Text = Convert.ToString(game.time) + " sek.";                    //wyswietlamy zaaktualizowany czas
            time_left_bar.Value = game.time;
            timerMain.Start();                                                                
            timeCount.Start();
            play_again.Enabled = false;
        }

        private void Okno_KeyUp(object sender, KeyEventArgs e)                                 //metoda odpowiadajaca za przeciwna sytuacje do powyzszej
        {

            if (e.KeyCode == Keys.Left)
            {
                moveleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveright = false;
            }
        }
    }
}

        
    




