namespace Projekt_6
{
    partial class TickTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        bool whosTurn = false; // true - kolej gracza 1, false - kolej gracza 2
        int turn_Count = 0; 
        const int MAX_TURN_COUNT = 9;

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
            this.exitButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.tieLabel = new System.Windows.Forms.Label();
            this.C2Button = new System.Windows.Forms.Button();
            this.C3Button = new System.Windows.Forms.Button();
            this.B3Button = new System.Windows.Forms.Button();
            this.A3Button = new System.Windows.Forms.Button();
            this.B2Button = new System.Windows.Forms.Button();
            this.A2Button = new System.Windows.Forms.Button();
            this.C1Button = new System.Windows.Forms.Button();
            this.B1Button = new System.Windows.Forms.Button();
            this.A1Button = new System.Windows.Forms.Button();
            this.goToMenuButton = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Snow;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(234, 466);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(273, 65);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Wyjdź z gry";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.Snow;
            this.startGameButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startGameButton.Location = new System.Drawing.Point(234, 352);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(273, 65);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Rozpocznij grę";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.titleLabel.Location = new System.Drawing.Point(216, 216);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(317, 61);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Kółko i krzyżyk";
            // 
            // gamePanel
            // 
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamePanel.Controls.Add(this.playAgainButton);
            this.gamePanel.Controls.Add(this.tieLabel);
            this.gamePanel.Controls.Add(this.C2Button);
            this.gamePanel.Controls.Add(this.C3Button);
            this.gamePanel.Controls.Add(this.B3Button);
            this.gamePanel.Controls.Add(this.A3Button);
            this.gamePanel.Controls.Add(this.B2Button);
            this.gamePanel.Controls.Add(this.A2Button);
            this.gamePanel.Controls.Add(this.C1Button);
            this.gamePanel.Controls.Add(this.B1Button);
            this.gamePanel.Controls.Add(this.A1Button);
            this.gamePanel.Location = new System.Drawing.Point(100, 100);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(597, 597);
            this.gamePanel.TabIndex = 3;
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Snow;
            this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.Location = new System.Drawing.Point(173, 295);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(258, 119);
            this.playAgainButton.TabIndex = 5;
            this.playAgainButton.Text = "Zagraj ponownie";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // tieLabel
            // 
            this.tieLabel.AutoSize = true;
            this.tieLabel.BackColor = System.Drawing.Color.Transparent;
            this.tieLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tieLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tieLabel.ForeColor = System.Drawing.Color.DimGray;
            this.tieLabel.Location = new System.Drawing.Point(162, 163);
            this.tieLabel.Name = "tieLabel";
            this.tieLabel.Size = new System.Drawing.Size(278, 106);
            this.tieLabel.TabIndex = 5;
            this.tieLabel.Text = "Remis!";
            // 
            // C2Button
            // 
            this.C2Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2Button.Location = new System.Drawing.Point(199, 398);
            this.C2Button.Name = "C2Button";
            this.C2Button.Size = new System.Drawing.Size(195, 195);
            this.C2Button.TabIndex = 8;
            this.C2Button.UseVisualStyleBackColor = true;
            this.C2Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // C3Button
            // 
            this.C3Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3Button.Location = new System.Drawing.Point(400, 398);
            this.C3Button.Name = "C3Button";
            this.C3Button.Size = new System.Drawing.Size(195, 195);
            this.C3Button.TabIndex = 7;
            this.C3Button.UseVisualStyleBackColor = true;
            this.C3Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // B3Button
            // 
            this.B3Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3Button.Location = new System.Drawing.Point(400, 199);
            this.B3Button.Name = "B3Button";
            this.B3Button.Size = new System.Drawing.Size(195, 195);
            this.B3Button.TabIndex = 6;
            this.B3Button.UseVisualStyleBackColor = true;
            this.B3Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // A3Button
            // 
            this.A3Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3Button.Location = new System.Drawing.Point(400, -2);
            this.A3Button.Name = "A3Button";
            this.A3Button.Size = new System.Drawing.Size(195, 195);
            this.A3Button.TabIndex = 5;
            this.A3Button.UseVisualStyleBackColor = true;
            this.A3Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // B2Button
            // 
            this.B2Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2Button.Location = new System.Drawing.Point(199, 199);
            this.B2Button.Name = "B2Button";
            this.B2Button.Size = new System.Drawing.Size(195, 195);
            this.B2Button.TabIndex = 4;
            this.B2Button.UseVisualStyleBackColor = true;
            this.B2Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // A2Button
            // 
            this.A2Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2Button.Location = new System.Drawing.Point(199, -2);
            this.A2Button.Name = "A2Button";
            this.A2Button.Size = new System.Drawing.Size(195, 195);
            this.A2Button.TabIndex = 3;
            this.A2Button.UseVisualStyleBackColor = true;
            this.A2Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // C1Button
            // 
            this.C1Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1Button.Location = new System.Drawing.Point(-2, 398);
            this.C1Button.Name = "C1Button";
            this.C1Button.Size = new System.Drawing.Size(195, 195);
            this.C1Button.TabIndex = 2;
            this.C1Button.UseVisualStyleBackColor = true;
            this.C1Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // B1Button
            // 
            this.B1Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1Button.Location = new System.Drawing.Point(-2, 199);
            this.B1Button.Name = "B1Button";
            this.B1Button.Size = new System.Drawing.Size(195, 195);
            this.B1Button.TabIndex = 1;
            this.B1Button.UseVisualStyleBackColor = true;
            this.B1Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // A1Button
            // 
            this.A1Button.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1Button.Location = new System.Drawing.Point(-2, -2);
            this.A1Button.Name = "A1Button";
            this.A1Button.Size = new System.Drawing.Size(195, 195);
            this.A1Button.TabIndex = 0;
            this.A1Button.UseVisualStyleBackColor = true;
            this.A1Button.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // goToMenuButton
            // 
            this.goToMenuButton.BackColor = System.Drawing.Color.Snow;
            this.goToMenuButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goToMenuButton.Location = new System.Drawing.Point(46, 32);
            this.goToMenuButton.Name = "goToMenuButton";
            this.goToMenuButton.Size = new System.Drawing.Size(196, 48);
            this.goToMenuButton.TabIndex = 4;
            this.goToMenuButton.Text = "Wróć do menu";
            this.goToMenuButton.UseVisualStyleBackColor = false;
            this.goToMenuButton.Click += new System.EventHandler(this.goToMenuButton_Click);
            // 
            // TickTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_6.Properties.Resources.Untitled_design;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.goToMenuButton);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.titleLabel);
            this.MaximizeBox = false;
            this.Name = "TickTacToe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kółko i krzyżyk";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button exitButton;
        private Button startGameButton;
        private Label titleLabel;
        private Panel gamePanel;
        private Button goToMenuButton;
        private Button C2Button;
        private Button C3Button;
        private Button B3Button;
        private Button A3Button;
        private Button B2Button;
        private Button A2Button;
        private Button C1Button;
        private Button B1Button;
        private Button A1Button;
        private Button playAgainButton;
        private Label tieLabel;
    }
}