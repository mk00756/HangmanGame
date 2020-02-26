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
            this.SuspendLayout();
            // 
            // wordLbl
            // 
            this.wordLbl.AutoSize = true;
            this.wordLbl.Location = new System.Drawing.Point(54, 9);
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
            this.inputTxt.Location = new System.Drawing.Point(83, 110);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(100, 20);
            this.inputTxt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.wordLabelLbl);
            this.Controls.Add(this.wordLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLbl;
        private System.Windows.Forms.Label wordLabelLbl;
        private System.Windows.Forms.TextBox inputTxt;
    }
}

