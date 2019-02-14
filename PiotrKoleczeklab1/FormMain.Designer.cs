namespace PiotrKoleczeklab1
{
    partial class FormMain
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
            this.labelMainTitle = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonExtreme = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCountry = new System.Windows.Forms.Label();
            this.buttonReich = new System.Windows.Forms.Button();
            this.buttonZSRR = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMainTitle
            // 
            this.labelMainTitle.AutoSize = true;
            this.labelMainTitle.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMainTitle.Location = new System.Drawing.Point(48, 9);
            this.labelMainTitle.Name = "labelMainTitle";
            this.labelMainTitle.Size = new System.Drawing.Size(934, 45);
            this.labelMainTitle.TabIndex = 0;
            this.labelMainTitle.Text = "SYMULATOR OBLĘŻENIA SEWASTOPOLA (1941-1942)";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDifficulty.Location = new System.Drawing.Point(33, 111);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(193, 20);
            this.labelDifficulty.TabIndex = 1;
            this.labelDifficulty.Text = "Wybierz poziom trudności:";
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonEasy
            // 
            this.buttonEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEasy.Location = new System.Drawing.Point(264, 104);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(130, 35);
            this.buttonEasy.TabIndex = 2;
            this.buttonEasy.Text = "Łatwy";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMedium.Location = new System.Drawing.Point(447, 104);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(130, 35);
            this.buttonMedium.TabIndex = 3;
            this.buttonMedium.Text = "Średni";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHard.Location = new System.Drawing.Point(655, 104);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(130, 35);
            this.buttonHard.TabIndex = 4;
            this.buttonHard.Text = "Trudny";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // buttonExtreme
            // 
            this.buttonExtreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExtreme.Location = new System.Drawing.Point(852, 104);
            this.buttonExtreme.Name = "buttonExtreme";
            this.buttonExtreme.Size = new System.Drawing.Size(130, 35);
            this.buttonExtreme.TabIndex = 5;
            this.buttonExtreme.Text = "Ekstremalny";
            this.buttonExtreme.UseVisualStyleBackColor = true;
            this.buttonExtreme.Click += new System.EventHandler(this.buttonExtreme_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHowToPlay.Location = new System.Drawing.Point(12, 427);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(170, 60);
            this.buttonHowToPlay.TabIndex = 6;
            this.buttonHowToPlay.Text = "Jak grać?";
            this.buttonHowToPlay.UseVisualStyleBackColor = true;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAbout.Location = new System.Drawing.Point(12, 522);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(170, 60);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(861, 522);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(170, 60);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Wyjdź z gry";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountry.Location = new System.Drawing.Point(33, 215);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(253, 20);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Wybierz nację, którą chesz zagrać:";
            // 
            // buttonReich
            // 
            this.buttonReich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonReich.Location = new System.Drawing.Point(417, 195);
            this.buttonReich.Name = "buttonReich";
            this.buttonReich.Size = new System.Drawing.Size(160, 60);
            this.buttonReich.TabIndex = 10;
            this.buttonReich.Text = "III Rzesza";
            this.buttonReich.UseVisualStyleBackColor = true;
            this.buttonReich.Click += new System.EventHandler(this.buttonReich_Click);
            // 
            // buttonZSRR
            // 
            this.buttonZSRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZSRR.Location = new System.Drawing.Point(655, 195);
            this.buttonZSRR.Name = "buttonZSRR";
            this.buttonZSRR.Size = new System.Drawing.Size(160, 60);
            this.buttonZSRR.TabIndex = 11;
            this.buttonZSRR.Text = "ZSRR";
            this.buttonZSRR.UseVisualStyleBackColor = true;
            this.buttonZSRR.Click += new System.EventHandler(this.buttonZSRR_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(508, 417);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(207, 81);
            this.buttonStart.TabIndex = 12;
            this.buttonStart.Text = "Zacznij grę";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonZSRR);
            this.Controls.Add(this.buttonReich);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonHowToPlay);
            this.Controls.Add(this.buttonExtreme);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.buttonEasy);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelMainTitle);
            this.Name = "FormMain";
            this.Text = "Menu główne";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainTitle;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonExtreme;
        private System.Windows.Forms.Button buttonHowToPlay;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Button buttonReich;
        private System.Windows.Forms.Button buttonZSRR;
        private System.Windows.Forms.Button buttonStart;
    }
}

