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
            SuspendLayout();
            // 
            // btnNim
            // 
            btnNim.Location = new Point(551, 72);
            btnNim.Name = "btnNim";
            btnNim.Size = new Size(153, 73);
            btnNim.TabIndex = 0;
            btnNim.Text = "Nim";
            btnNim.UseVisualStyleBackColor = true;
            btnNim.Click += btnNim_Click;
            // 
            // turnSwitch
            // 
            turnSwitch.Location = new Point(546, 246);
            turnSwitch.Name = "turnSwitch";
            turnSwitch.Size = new Size(174, 91);
            turnSwitch.TabIndex = 1;
            turnSwitch.Text = "Gegner ";
            turnSwitch.UseVisualStyleBackColor = true;
            turnSwitch.Click += turnSwitch_Click;
            // 
            // retry
            // 
            retry.Location = new Point(12, 392);
            retry.Name = "retry";
            retry.Size = new Size(94, 29);
            retry.TabIndex = 2;
            retry.Text = "Retry";
            retry.UseVisualStyleBackColor = true;
            retry.Click += retry_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(retry);
            Controls.Add(turnSwitch);
            Controls.Add(btnNim);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNim;
        private Button turnSwitch;
        private Button retry;
    }
}