
namespace TheLetterGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_second_label = new System.Windows.Forms.Label();
            this.finish_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.timer_minute_label = new System.Windows.Forms.Label();
            this.words_txtbox = new System.Windows.Forms.TextBox();
            this.word_screen = new System.Windows.Forms.Label();
            this.finish_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.word_timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timer_second_label);
            this.panel1.Controls.Add(this.finish_label);
            this.panel1.Controls.Add(this.welcome_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.score_label);
            this.panel1.Controls.Add(this.timer_minute_label);
            this.panel1.Controls.Add(this.words_txtbox);
            this.panel1.Controls.Add(this.word_screen);
            this.panel1.Controls.Add(this.finish_button);
            this.panel1.Controls.Add(this.start_button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(517, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = ":";
            // 
            // timer_second_label
            // 
            this.timer_second_label.AutoSize = true;
            this.timer_second_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timer_second_label.Location = new System.Drawing.Point(527, 123);
            this.timer_second_label.Name = "timer_second_label";
            this.timer_second_label.Size = new System.Drawing.Size(0, 16);
            this.timer_second_label.TabIndex = 10;
            // 
            // finish_label
            // 
            this.finish_label.AutoSize = true;
            this.finish_label.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.finish_label.ForeColor = System.Drawing.Color.Red;
            this.finish_label.Location = new System.Drawing.Point(158, 188);
            this.finish_label.Name = "finish_label";
            this.finish_label.Size = new System.Drawing.Size(0, 51);
            this.finish_label.TabIndex = 9;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Rage Italic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(55, 30);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(699, 61);
            this.welcome_label.TabIndex = 8;
            this.welcome_label.Text = "Welcome, The Letter Game is starting...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(435, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(597, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score : ";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_label.Location = new System.Drawing.Point(669, 120);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(0, 16);
            this.score_label.TabIndex = 5;
            // 
            // timer_minute_label
            // 
            this.timer_minute_label.AutoSize = true;
            this.timer_minute_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timer_minute_label.Location = new System.Drawing.Point(498, 123);
            this.timer_minute_label.Name = "timer_minute_label";
            this.timer_minute_label.Size = new System.Drawing.Size(0, 16);
            this.timer_minute_label.TabIndex = 4;
            // 
            // words_txtbox
            // 
            this.words_txtbox.Location = new System.Drawing.Point(66, 117);
            this.words_txtbox.Name = "words_txtbox";
            this.words_txtbox.Size = new System.Drawing.Size(247, 20);
            this.words_txtbox.TabIndex = 3;
            this.words_txtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // word_screen
            // 
            this.word_screen.AutoSize = true;
            this.word_screen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.word_screen.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.word_screen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.word_screen.Location = new System.Drawing.Point(230, 217);
            this.word_screen.Name = "word_screen";
            this.word_screen.Size = new System.Drawing.Size(0, 102);
            this.word_screen.TabIndex = 2;
            // 
            // finish_button
            // 
            this.finish_button.BackColor = System.Drawing.Color.Firebrick;
            this.finish_button.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.finish_button.Location = new System.Drawing.Point(550, 311);
            this.finish_button.Name = "finish_button";
            this.finish_button.Size = new System.Drawing.Size(119, 55);
            this.finish_button.TabIndex = 1;
            this.finish_button.Text = "Finish";
            this.finish_button.UseVisualStyleBackColor = false;
            this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.PeachPuff;
            this.start_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_button.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start_button.Location = new System.Drawing.Point(550, 184);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(119, 55);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // word_timer
            // 
            this.word_timer.Tick += new System.EventHandler(this.word_timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type the letters into the box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "The Letter Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label word_screen;
        private System.Windows.Forms.Button finish_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox words_txtbox;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label timer_minute_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label finish_label;
        private System.Windows.Forms.Label timer_second_label;
        private System.Windows.Forms.Timer word_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

