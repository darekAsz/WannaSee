namespace WannaSee
{
    partial class Movies
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
            this.BackToMenu = new System.Windows.Forms.Button();
            this.DataMovies = new System.Windows.Forms.DataGridView();
            this.Tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishTittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HowMuchWantSee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackToMenu.Location = new System.Drawing.Point(12, 417);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(75, 23);
            this.BackToMenu.TabIndex = 0;
            this.BackToMenu.Text = "Wróć";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // DataMovies
            // 
            this.DataMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tittle,
            this.EnglishTittle,
            this.Genre,
            this.Year,
            this.Country,
            this.HowMuchWantSee});
            this.DataMovies.EnableHeadersVisualStyles = false;
            this.DataMovies.Location = new System.Drawing.Point(12, 12);
            this.DataMovies.Name = "DataMovies";
            this.DataMovies.Size = new System.Drawing.Size(853, 376);
            this.DataMovies.TabIndex = 1;
            // 
            // Tittle
            // 
            this.Tittle.HeaderText = "Tytuł";
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            this.Tittle.Width = 175;
            // 
            // EnglishTittle
            // 
            this.EnglishTittle.HeaderText = "Tytuł angielski";
            this.EnglishTittle.Name = "EnglishTittle";
            this.EnglishTittle.ReadOnly = true;
            this.EnglishTittle.Width = 150;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Gatunek";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Width = 175;
            // 
            // Year
            // 
            this.Year.HeaderText = "Rok";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 50;
            // 
            // Country
            // 
            this.Country.HeaderText = "Kraj";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // HowMuchWantSee
            // 
            this.HowMuchWantSee.HeaderText = "Stopień zainteresowania";
            this.HowMuchWantSee.Name = "HowMuchWantSee";
            this.HowMuchWantSee.ReadOnly = true;
            this.HowMuchWantSee.Width = 140;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(877, 452);
            this.Controls.Add(this.DataMovies);
            this.Controls.Add(this.BackToMenu);
            this.Name = "Movies";
            this.Text = "Movies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Movies_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.DataGridView DataMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishTittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn HowMuchWantSee;
    }
}