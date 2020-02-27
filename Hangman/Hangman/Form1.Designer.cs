namespace Hangman
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
            this.wordLbl = new System.Windows.Forms.Label();
            this.wordLabelLbl = new System.Windows.Forms.Label();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.inputBtn = new System.Windows.Forms.Button();
            this.replayBtn = new System.Windows.Forms.Button();
            this.inputLbl = new System.Windows.Forms.Label();
            this.livesLabelLbl = new System.Windows.Forms.Label();
            this.livesLbl = new System.Windows.Forms.Label();
            this.guessLabelLbl = new System.Windows.Forms.Label();
            this.guessLbl = new System.Windows.Forms.Label();
            this.hangmanPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPic)).BeginInit();
            this.SuspendLayout();
            // 
            // wordLbl
            // 
            this.wordLbl.AutoSize = true;
            this.wordLbl.Location = new System.Drawing.Point(50, 9);
            this.wordLbl.Name = "wordLbl";
            this.wordLbl.Size = new System.Drawing.Size(13, 13);
            this.wordLbl.TabIndex = 0;
            this.wordLbl.Text = "_";
            // 
            // wordLabelLbl
            // 
            this.wordLabelLbl.AutoSize = true;
            this.wordLabelLbl.Location = new System.Drawing.Point(12, 9);
            this.wordLabelLbl.Name = "wordLabelLbl";
            this.wordLabelLbl.Size = new System.Drawing.Size(36, 13);
            this.wordLabelLbl.TabIndex = 1;
            this.wordLabelLbl.Text = "Word:";
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(83, 189);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(189, 20);
            this.inputTxt.TabIndex = 2;
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(12, 215);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(75, 23);
            this.inputBtn.TabIndex = 3;
            this.inputBtn.Text = "Make Guess";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // replayBtn
            // 
            this.replayBtn.Location = new System.Drawing.Point(197, 215);
            this.replayBtn.Name = "replayBtn";
            this.replayBtn.Size = new System.Drawing.Size(75, 23);
            this.replayBtn.TabIndex = 4;
            this.replayBtn.Text = "Play Again";
            this.replayBtn.UseVisualStyleBackColor = true;
            this.replayBtn.Click += new System.EventHandler(this.replayBtn_Click);
            // 
            // inputLbl
            // 
            this.inputLbl.AutoSize = true;
            this.inputLbl.Location = new System.Drawing.Point(12, 192);
            this.inputLbl.Name = "inputLbl";
            this.inputLbl.Size = new System.Drawing.Size(65, 13);
            this.inputLbl.TabIndex = 5;
            this.inputLbl.Text = "Your Guess:";
            // 
            // livesLabelLbl
            // 
            this.livesLabelLbl.AutoSize = true;
            this.livesLabelLbl.Location = new System.Drawing.Point(218, 9);
            this.livesLabelLbl.Name = "livesLabelLbl";
            this.livesLabelLbl.Size = new System.Drawing.Size(35, 13);
            this.livesLabelLbl.TabIndex = 6;
            this.livesLabelLbl.Text = "Lives:";
            // 
            // livesLbl
            // 
            this.livesLbl.AutoSize = true;
            this.livesLbl.Location = new System.Drawing.Point(259, 9);
            this.livesLbl.Name = "livesLbl";
            this.livesLbl.Size = new System.Drawing.Size(13, 13);
            this.livesLbl.TabIndex = 7;
            this.livesLbl.Text = "6";
            // 
            // hangmanPic
            // 
            this.hangmanPic.Location = new System.Drawing.Point(15, 52);
            this.hangmanPic.Name = "hangmanPic";
            this.hangmanPic.Size = new System.Drawing.Size(257, 127);
            this.hangmanPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangmanPic.TabIndex = 8;
            this.hangmanPic.TabStop = false;
            // 
            // guessLabelLbl
            // 
            this.guessLabelLbl.AutoSize = true;
            this.guessLabelLbl.Location = new System.Drawing.Point(12, 36);
            this.guessLabelLbl.Name = "guessLabelLbl";
            this.guessLabelLbl.Size = new System.Drawing.Size(51, 13);
            this.guessLabelLbl.TabIndex = 9;
            this.guessLabelLbl.Text = "Guesses:";
            // 
            // guessLbl
            // 
            this.guessLbl.AutoSize = true;
            this.guessLbl.Location = new System.Drawing.Point(65, 36);
            this.guessLbl.Name = "guessLbl";
            this.guessLbl.Size = new System.Drawing.Size(10, 13);
            this.guessLbl.TabIndex = 10;
            this.guessLbl.Text = ".";
            // 
            // hangmanPic
            // 
            this.hangmanPic.Location = new System.Drawing.Point(15, 52);
            this.hangmanPic.Name = "hangmanPic";
            this.hangmanPic.Size = new System.Drawing.Size(257, 127);
            this.hangmanPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangmanPic.TabIndex = 8;
            this.hangmanPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.guessLbl);
            this.Controls.Add(this.guessLabelLbl);
            this.Controls.Add(this.hangmanPic);
            this.Controls.Add(this.livesLbl);
            this.Controls.Add(this.livesLabelLbl);
            this.Controls.Add(this.inputLbl);
            this.Controls.Add(this.replayBtn);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.wordLabelLbl);
            this.Controls.Add(this.wordLbl);
            this.MaximumSize = new System.Drawing.Size(300, 283);
            this.MinimumSize = new System.Drawing.Size(300, 283);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.Label wordLabelLbl;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.Button replayBtn;
        private System.Windows.Forms.Label inputLbl;
        private System.Windows.Forms.Label livesLabelLbl;
        private System.Windows.Forms.Label livesLbl;
        private System.Windows.Forms.PictureBox hangmanPic;
        private System.Windows.Forms.Label guessLabelLbl;
        private System.Windows.Forms.Label guessLbl;
    }
}

