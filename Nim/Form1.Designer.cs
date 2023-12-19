namespace Nim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameStart = new Button();
            btnEasy = new Button();
            btnHard = new Button();
            SuspendLayout();
            // 
            // gameStart
            // 
            gameStart.Location = new Point(219, 294);
            gameStart.Name = "gameStart";
            gameStart.Size = new Size(332, 90);
            gameStart.TabIndex = 0;
            gameStart.Text = "Start";
            gameStart.UseVisualStyleBackColor = true;
            gameStart.Click += gameStart_Click;
            // 
            // btnEasy
            // 
            btnEasy.Location = new Point(415, 165);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(136, 62);
            btnEasy.TabIndex = 1;
            btnEasy.Text = "Einfach";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += btnEasy_Click;
            // 
            // btnHard
            // 
            btnHard.Location = new Point(219, 165);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(136, 62);
            btnHard.TabIndex = 2;
            btnHard.Text = "Schwer";
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Click += btnHard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHard);
            Controls.Add(btnEasy);
            Controls.Add(gameStart);
            Name = "Form1";
            Text = "Nim_Launcher";
            ResumeLayout(false);
        }

        #endregion

        private Button gameStart;
        private Button btnEasy;
        private Button btnHard;
    }
}
