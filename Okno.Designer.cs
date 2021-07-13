using System.Drawing;

namespace ProjektJPWPv2
{
    partial class Okno
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.level_display = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.score_display = new System.Windows.Forms.Label();
            this.bonus = new System.Windows.Forms.Label();
            this.bonus_display = new System.Windows.Forms.Label();
            this.PozostaleZycia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_left_display = new System.Windows.Forms.Label();
            this.time_left_wyswietlanie = new System.Windows.Forms.Label();
            this.time_left_bar = new System.Windows.Forms.ProgressBar();
            this.PozostalyCzas = new System.Windows.Forms.Label();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.timeCount = new System.Windows.Forms.Timer(this.components);
            this.question = new System.Windows.Forms.Panel();
            this.questionTime = new System.Windows.Forms.Label();
            this.answer_info = new System.Windows.Forms.Label();
            this.question_text = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.timerQuestion = new System.Windows.Forms.Timer(this.components);
            this.endgame = new System.Windows.Forms.Panel();
            this.final_mark = new System.Windows.Forms.Label();
            this.lives_final = new System.Windows.Forms.Label();
            this.lives_left = new System.Windows.Forms.Label();
            this.score_final_txt = new System.Windows.Forms.Label();
            this.score_final = new System.Windows.Forms.Label();
            this.endgame_display = new System.Windows.Forms.Label();
            this.play_again = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            this.question.SuspendLayout();
            this.endgame.SuspendLayout();
            this.SuspendLayout();
            // 
            // level_display
            // 
            this.level_display.AutoSize = true;
            this.level_display.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level_display.Location = new System.Drawing.Point(53, 35);
            this.level_display.Name = "level_display";
            this.level_display.Size = new System.Drawing.Size(131, 38);
            this.level_display.TabIndex = 0;
            this.level_display.Text = "Poziom 1";
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(3, 95);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(89, 31);
            this.wynik.TabIndex = 1;
            this.wynik.Text = "Wynik:";
            // 
            // score_display
            // 
            this.score_display.AutoSize = true;
            this.score_display.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_display.Location = new System.Drawing.Point(91, 96);
            this.score_display.Name = "score_display";
            this.score_display.Size = new System.Drawing.Size(26, 30);
            this.score_display.TabIndex = 2;
            this.score_display.Text = "0";
            // 
            // bonus
            // 
            this.bonus.AutoSize = true;
            this.bonus.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bonus.Location = new System.Drawing.Point(3, 143);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(84, 31);
            this.bonus.TabIndex = 3;
            this.bonus.Text = "Bonus:";
            // 
            // bonus_display
            // 
            this.bonus_display.AutoSize = true;
            this.bonus_display.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bonus_display.Location = new System.Drawing.Point(91, 144);
            this.bonus_display.Name = "bonus_display";
            this.bonus_display.Size = new System.Drawing.Size(36, 30);
            this.bonus_display.TabIndex = 4;
            this.bonus_display.Text = "x1";
            this.bonus_display.Visible = false;
            // 
            // PozostaleZycia
            // 
            this.PozostaleZycia.AutoSize = true;
            this.PozostaleZycia.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PozostaleZycia.Location = new System.Drawing.Point(19, 239);
            this.PozostaleZycia.Name = "PozostaleZycia";
            this.PozostaleZycia.Size = new System.Drawing.Size(207, 35);
            this.PozostaleZycia.TabIndex = 5;
            this.PozostaleZycia.Text = "Pozostałe Życia:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.time_left_display);
            this.panel1.Controls.Add(this.time_left_wyswietlanie);
            this.panel1.Controls.Add(this.time_left_bar);
            this.panel1.Controls.Add(this.PozostalyCzas);
            this.panel1.Controls.Add(this.life2);
            this.panel1.Controls.Add(this.life3);
            this.panel1.Controls.Add(this.life1);
            this.panel1.Controls.Add(this.PozostaleZycia);
            this.panel1.Controls.Add(this.bonus_display);
            this.panel1.Controls.Add(this.bonus);
            this.panel1.Controls.Add(this.score_display);
            this.panel1.Controls.Add(this.wynik);
            this.panel1.Controls.Add(this.level_display);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(1024, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 1026);
            this.panel1.TabIndex = 0;
            // 
            // time_left_display
            // 
            this.time_left_display.AutoSize = true;
            this.time_left_display.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time_left_display.Location = new System.Drawing.Point(151, 430);
            this.time_left_display.Name = "time_left_display";
            this.time_left_display.Size = new System.Drawing.Size(63, 23);
            this.time_left_display.TabIndex = 16;
            this.time_left_display.Text = "25 sek.";
            // 
            // time_left_wyswietlanie
            // 
            this.time_left_wyswietlanie.Location = new System.Drawing.Point(0, 0);
            this.time_left_wyswietlanie.Name = "time_left_wyswietlanie";
            this.time_left_wyswietlanie.Size = new System.Drawing.Size(100, 23);
            this.time_left_wyswietlanie.TabIndex = 15;
            // 
            // time_left_bar
            // 
            this.time_left_bar.Location = new System.Drawing.Point(25, 397);
            this.time_left_bar.Name = "time_left_bar";
            this.time_left_bar.Size = new System.Drawing.Size(192, 26);
            this.time_left_bar.TabIndex = 11;
            this.time_left_bar.Value = 25;
            // 
            // PozostalyCzas
            // 
            this.PozostalyCzas.AutoSize = true;
            this.PozostalyCzas.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PozostalyCzas.Location = new System.Drawing.Point(19, 359);
            this.PozostalyCzas.Name = "PozostalyCzas";
            this.PozostalyCzas.Size = new System.Drawing.Size(198, 35);
            this.PozostalyCzas.TabIndex = 10;
            this.PozostalyCzas.Text = "Pozostały Czas:";
            // 
            // life2
            // 
            this.life2.Image = global::ProjektJPWPv2.Properties.Resources._6Tr5eLnjc;
            this.life2.Location = new System.Drawing.Point(96, 291);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(42, 44);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life2.TabIndex = 8;
            this.life2.TabStop = false;
            // 
            // life3
            // 
            this.life3.Image = global::ProjektJPWPv2.Properties.Resources._6Tr5eLnjc;
            this.life3.Location = new System.Drawing.Point(163, 291);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(42, 44);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life3.TabIndex = 7;
            this.life3.TabStop = false;
            // 
            // life1
            // 
            this.life1.Image = global::ProjektJPWPv2.Properties.Resources._6Tr5eLnjc;
            this.life1.Location = new System.Drawing.Point(25, 291);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(42, 44);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life1.TabIndex = 6;
            this.life1.TabStop = false;
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // timeCount
            // 
            this.timeCount.Enabled = true;
            this.timeCount.Interval = 1000;
            this.timeCount.Tick += new System.EventHandler(this.timeCount_Tick);
            // 
            // question
            // 
            this.question.Controls.Add(this.questionTime);
            this.question.Controls.Add(this.answer_info);
            this.question.Controls.Add(this.question_text);
            this.question.Controls.Add(this.enter);
            this.question.Controls.Add(this.answerBox);
            this.question.Location = new System.Drawing.Point(236, 166);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(599, 356);
            this.question.TabIndex = 1;
            this.question.Visible = false;
            // 
            // questionTime
            // 
            this.questionTime.AutoSize = true;
            this.questionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionTime.Location = new System.Drawing.Point(21, 302);
            this.questionTime.Name = "questionTime";
            this.questionTime.Size = new System.Drawing.Size(149, 24);
            this.questionTime.TabIndex = 4;
            this.questionTime.Text = "Pozostały Czas: ";
            // 
            // answer_info
            // 
            this.answer_info.AutoSize = true;
            this.answer_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answer_info.Location = new System.Drawing.Point(19, 208);
            this.answer_info.Name = "answer_info";
            this.answer_info.Size = new System.Drawing.Size(232, 31);
            this.answer_info.TabIndex = 3;
            this.answer_info.Text = "Twoja odpowiedź:";
            // 
            // question_text
            // 
            this.question_text.AutoSize = true;
            this.question_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question_text.Location = new System.Drawing.Point(26, 106);
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(195, 63);
            this.question_text.TabIndex = 2;
            this.question_text.Text = "TUTAJ";
            this.question_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enter
            // 
            this.enter.Enabled = false;
            this.enter.Location = new System.Drawing.Point(429, 226);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(150, 63);
            this.enter.TabIndex = 1;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // answerBox
            // 
            this.answerBox.BackColor = System.Drawing.SystemColors.Menu;
            this.answerBox.Enabled = false;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBox.Location = new System.Drawing.Point(25, 251);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(387, 38);
            this.answerBox.TabIndex = 0;
            this.answerBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerBox_KeyPress);
            // 
            // timerQuestion
            // 
            this.timerQuestion.Interval = 1000;
            this.timerQuestion.Tick += new System.EventHandler(this.timerQuestion_Tick);
            // 
            // endgame
            // 
            this.endgame.Controls.Add(this.play_again);
            this.endgame.Controls.Add(this.final_mark);
            this.endgame.Controls.Add(this.lives_final);
            this.endgame.Controls.Add(this.lives_left);
            this.endgame.Controls.Add(this.score_final_txt);
            this.endgame.Controls.Add(this.score_final);
            this.endgame.Controls.Add(this.endgame_display);
            this.endgame.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endgame.Location = new System.Drawing.Point(39, 33);
            this.endgame.Name = "endgame";
            this.endgame.Size = new System.Drawing.Size(955, 486);
            this.endgame.TabIndex = 2;
            this.endgame.Visible = false;
            // 
            // final_mark
            // 
            this.final_mark.AutoSize = true;
            this.final_mark.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.final_mark.Location = new System.Drawing.Point(678, 397);
            this.final_mark.Name = "final_mark";
            this.final_mark.Size = new System.Drawing.Size(118, 47);
            this.final_mark.TabIndex = 5;
            this.final_mark.Text = "Ocena";
            // 
            // lives_final
            // 
            this.lives_final.AutoSize = true;
            this.lives_final.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lives_final.Location = new System.Drawing.Point(663, 193);
            this.lives_final.Name = "lives_final";
            this.lives_final.Size = new System.Drawing.Size(41, 47);
            this.lives_final.TabIndex = 4;
            this.lives_final.Text = "0";
            // 
            // lives_left
            // 
            this.lives_left.AutoSize = true;
            this.lives_left.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lives_left.Location = new System.Drawing.Point(82, 192);
            this.lives_left.Name = "lives_left";
            this.lives_left.Size = new System.Drawing.Size(309, 48);
            this.lives_left.TabIndex = 3;
            this.lives_left.Text = "Pozostałe Życia: ";
            // 
            // score_final_txt
            // 
            this.score_final_txt.AutoSize = true;
            this.score_final_txt.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_final_txt.Location = new System.Drawing.Point(82, 258);
            this.score_final_txt.Name = "score_final_txt";
            this.score_final_txt.Size = new System.Drawing.Size(229, 48);
            this.score_final_txt.TabIndex = 2;
            this.score_final_txt.Text = "Twój Wynik:";
            // 
            // score_final
            // 
            this.score_final.AutoSize = true;
            this.score_final.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_final.Location = new System.Drawing.Point(663, 259);
            this.score_final.Name = "score_final";
            this.score_final.Size = new System.Drawing.Size(41, 47);
            this.score_final.TabIndex = 1;
            this.score_final.Text = "0";
            // 
            // endgame_display
            // 
            this.endgame_display.AutoSize = true;
            this.endgame_display.Font = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endgame_display.Location = new System.Drawing.Point(240, 27);
            this.endgame_display.Name = "endgame_display";
            this.endgame_display.Size = new System.Drawing.Size(478, 111);
            this.endgame_display.TabIndex = 0;
            this.endgame_display.Text = "Koniec Gry!";
            // 
            // play_again
            // 
            this.play_again.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play_again.Location = new System.Drawing.Point(90, 397);
            this.play_again.Name = "play_again";
            this.play_again.Size = new System.Drawing.Size(227, 47);
            this.play_again.TabIndex = 6;
            this.play_again.Text = "Zagraj Ponownie!";
            this.play_again.UseVisualStyleBackColor = true;
            this.play_again.Click += new System.EventHandler(this.play_again_Click);
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::ProjektJPWPv2.Properties.Resources._477861;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.endgame);
            this.Controls.Add(this.question);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Okno";
            this.Text = "MathMaster";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Okno_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Okno_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            this.question.ResumeLayout(false);
            this.question.PerformLayout();
            this.endgame.ResumeLayout(false);
            this.endgame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label level_display;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label score_display;
        private System.Windows.Forms.Label bonus;
        private System.Windows.Forms.Label bonus_display;
        private System.Windows.Forms.Label PozostaleZycia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.Label time_left_wyswietlanie;
        private System.Windows.Forms.ProgressBar time_left_bar;
        private System.Windows.Forms.Label PozostalyCzas;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label time_left_display;
        private System.Windows.Forms.Timer timeCount;
        private System.Windows.Forms.Panel question;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label question_text;
        private System.Windows.Forms.Label answer_info;
        private System.Windows.Forms.Timer timerQuestion;
        private System.Windows.Forms.Label questionTime;
        private System.Windows.Forms.Panel endgame;
        private System.Windows.Forms.Label final_mark;
        private System.Windows.Forms.Label lives_final;
        private System.Windows.Forms.Label lives_left;
        private System.Windows.Forms.Label score_final_txt;
        private System.Windows.Forms.Label score_final;
        private System.Windows.Forms.Label endgame_display;
        private System.Windows.Forms.Button play_again;
        //  private RuchomyPictureBox postac;
    }

  
}

