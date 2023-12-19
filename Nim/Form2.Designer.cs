namespace Nim
{
    partial class Form2
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
            btnNim = new Button();
            turnSwitch = new Button();
            retry = new Button();
            labelLoose = new Label();
            btnLeave = new Button();
            labelWon = new Label();
            labTurn = new Label();
            label1 = new Label();
            labelPunkte = new Label();
            SuspendLayout();
            // 
            // btnNim
            // 
            btnNim.Location = new Point(980, 557);
            btnNim.Name = "btnNim";
            btnNim.Size = new Size(153, 73);
            btnNim.TabIndex = 0;
            btnNim.Text = "Nim";
            btnNim.UseVisualStyleBackColor = true;
            btnNim.Click += btnNim_Click;
            // 
            // turnSwitch
            // 
            turnSwitch.Location = new Point(264, 548);
            turnSwitch.Name = "turnSwitch";
            turnSwitch.Size = new Size(174, 91);
            turnSwitch.TabIndex = 1;
            turnSwitch.Text = "Gegner ";
            turnSwitch.UseVisualStyleBackColor = true;
            turnSwitch.Click += turnSwitch_Click;
            // 
            // retry
            // 
            retry.Location = new Point(645, 365);
            retry.Name = "retry";
            retry.Size = new Size(152, 43);
            retry.TabIndex = 2;
            retry.Text = "Nochmal";
            retry.UseVisualStyleBackColor = true;
            retry.Visible = false;
            retry.Click += retry_Click;
            // 
            // labelLoose
            // 
            labelLoose.AutoSize = true;
            labelLoose.Font = new Font("Segoe UI", 30F);
            labelLoose.Location = new Point(541, 278);
            labelLoose.Name = "labelLoose";
            labelLoose.Size = new Size(390, 67);
            labelLoose.TabIndex = 3;
            labelLoose.Text = "Du hast verloren";
            labelLoose.TextAlign = ContentAlignment.MiddleCenter;
            labelLoose.Visible = false;
            // 
            // btnLeave
            // 
            btnLeave.Location = new Point(645, 423);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(152, 43);
            btnLeave.TabIndex = 4;
            btnLeave.Text = "Verlassen";
            btnLeave.UseVisualStyleBackColor = true;
            btnLeave.Visible = false;
            btnLeave.Click += btnLeave_Click;
            // 
            // labelWon
            // 
            labelWon.Font = new Font("Segoe UI", 30F);
            labelWon.Location = new Point(541, 276);
            labelWon.Name = "labelWon";
            labelWon.Size = new Size(465, 86);
            labelWon.TabIndex = 5;
            labelWon.Text = "Du hast gewonnen";
            labelWon.Visible = false;
            // 
            // labTurn
            // 
            labTurn.AutoSize = true;
            labTurn.Font = new Font("Segoe UI", 20F);
            labTurn.Location = new Point(615, 67);
            labTurn.Name = "labTurn";
            labTurn.Size = new Size(0, 46);
            labTurn.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(47, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 7;
            // 
            // labelPunkte
            // 
            labelPunkte.AutoSize = true;
            labelPunkte.Font = new Font("Segoe UI", 14F);
            labelPunkte.Location = new Point(79, 54);
            labelPunkte.Name = "labelPunkte";
            labelPunkte.Size = new Size(0, 32);
            labelPunkte.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1571, 762);
            Controls.Add(labelPunkte);
            Controls.Add(label1);
            Controls.Add(labTurn);
            Controls.Add(labelWon);
            Controls.Add(btnLeave);
            Controls.Add(labelLoose);
            Controls.Add(retry);
            Controls.Add(turnSwitch);
            Controls.Add(btnNim);
            Name = "Form2";
            Text = "Nim";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNim;
        private Button turnSwitch;
        private Button retry;
        private Label labelLoose;
        private Button btnLeave;
        private Label labelWon;
        private Label labTurn;
        private Label label1;
        private Label labelPunkte;
    }
}