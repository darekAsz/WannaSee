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
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HowMuchWantSee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiveRandomMovie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TittleSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataMovies)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackToMenu.Location = new System.Drawing.Point(45, 494);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(75, 41);
            this.BackToMenu.TabIndex = 0;
            this.BackToMenu.Text = "Wróć";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // DataMovies
            // 
            this.DataMovies.AllowUserToAddRows = false;
            this.DataMovies.AllowUserToDeleteRows = false;
            this.DataMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tittle,
            this.EnglishTittle,
            this.Rate,
            this.Genre,
            this.Year,
            this.Country,
            this.HowMuchWantSee});
            this.DataMovies.EnableHeadersVisualStyles = false;
            this.DataMovies.Location = new System.Drawing.Point(3, 12);
            this.DataMovies.MultiSelect = false;
            this.DataMovies.Name = "DataMovies";
            this.DataMovies.ReadOnly = true;
            this.DataMovies.Size = new System.Drawing.Size(918, 376);
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
            // Rate
            // 
            this.Rate.HeaderText = "Ocena";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 50;
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
            // GiveRandomMovie
            // 
            this.GiveRandomMovie.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GiveRandomMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GiveRandomMovie.Location = new System.Drawing.Point(12, 396);
            this.GiveRandomMovie.Name = "GiveRandomMovie";
            this.GiveRandomMovie.Size = new System.Drawing.Size(145, 53);
            this.GiveRandomMovie.TabIndex = 2;
            this.GiveRandomMovie.Text = "Losuj film";
            this.GiveRandomMovie.UseVisualStyleBackColor = false;
            this.GiveRandomMovie.Click += new System.EventHandler(this.GiveRandomMovie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(441, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtr";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.TittleSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(184, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wyszukiwarka";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Reset.Location = new System.Drawing.Point(12, 455);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(145, 33);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Resetuj";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tytuł lub część tytułu";
            // 
            // TittleSearch
            // 
            this.TittleSearch.Location = new System.Drawing.Point(19, 71);
            this.TittleSearch.Name = "TittleSearch";
            this.TittleSearch.Size = new System.Drawing.Size(196, 20);
            this.TittleSearch.TabIndex = 1;
            this.TittleSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TittleSearch_KeyDown);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Search.Location = new System.Drawing.Point(19, 108);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(196, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Szukaj";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GiveRandomMovie);
            this.Controls.Add(this.DataMovies);
            this.Controls.Add(this.BackToMenu);
            this.Name = "Movies";
            this.Text = "Movies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Movies_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataMovies)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.DataGridView DataMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishTittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn HowMuchWantSee;
        private System.Windows.Forms.Button GiveRandomMovie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox TittleSearch;
        private System.Windows.Forms.Label label1;
    }
}