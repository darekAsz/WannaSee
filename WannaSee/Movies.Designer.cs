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
            this.GiveRandomMovie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LevelOfInterests = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClearFiltrationArea = new System.Windows.Forms.Button();
            this.Filtration = new System.Windows.Forms.Button();
            this.Countries = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RateTo = new System.Windows.Forms.TextBox();
            this.RateSince = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YearTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YearSince = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenreList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.TittleSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnglishTittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HowMuchWantSee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataMovies)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.DataMovies.Size = new System.Drawing.Size(956, 376);
            this.DataMovies.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.LevelOfInterests);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ClearFiltrationArea);
            this.groupBox1.Controls.Add(this.Filtration);
            this.groupBox1.Controls.Add(this.Countries);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.RateTo);
            this.groupBox1.Controls.Add(this.RateSince);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.YearTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.YearSince);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.GenreList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(441, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtr";
            // 
            // LevelOfInterests
            // 
            this.LevelOfInterests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LevelOfInterests.FormattingEnabled = true;
            this.LevelOfInterests.Location = new System.Drawing.Point(362, 73);
            this.LevelOfInterests.Name = "LevelOfInterests";
            this.LevelOfInterests.Size = new System.Drawing.Size(150, 21);
            this.LevelOfInterests.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(377, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "      Stopień \r\nzainteresowania";
            // 
            // ClearFiltrationArea
            // 
            this.ClearFiltrationArea.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClearFiltrationArea.Location = new System.Drawing.Point(9, 125);
            this.ClearFiltrationArea.Name = "ClearFiltrationArea";
            this.ClearFiltrationArea.Size = new System.Drawing.Size(189, 23);
            this.ClearFiltrationArea.TabIndex = 14;
            this.ClearFiltrationArea.Text = "Resetuj";
            this.ClearFiltrationArea.UseVisualStyleBackColor = false;
            this.ClearFiltrationArea.Click += new System.EventHandler(this.ClearFiltrationArea_Click);
            // 
            // Filtration
            // 
            this.Filtration.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Filtration.Location = new System.Drawing.Point(244, 125);
            this.Filtration.Name = "Filtration";
            this.Filtration.Size = new System.Drawing.Size(268, 23);
            this.Filtration.TabIndex = 13;
            this.Filtration.Text = "Filtruj";
            this.Filtration.UseVisualStyleBackColor = false;
            this.Filtration.Click += new System.EventHandler(this.Filtration_Click);
            // 
            // Countries
            // 
            this.Countries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Countries.FormattingEnabled = true;
            this.Countries.Location = new System.Drawing.Point(244, 89);
            this.Countries.Name = "Countries";
            this.Countries.Size = new System.Drawing.Size(100, 21);
            this.Countries.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(164, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kraj";
            // 
            // RateTo
            // 
            this.RateTo.Location = new System.Drawing.Point(244, 59);
            this.RateTo.Name = "RateTo";
            this.RateTo.Size = new System.Drawing.Size(100, 20);
            this.RateTo.TabIndex = 10;
            // 
            // RateSince
            // 
            this.RateSince.Location = new System.Drawing.Point(244, 26);
            this.RateSince.Name = "RateSince";
            this.RateSince.Size = new System.Drawing.Size(100, 20);
            this.RateSince.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(164, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ocena do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(171, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(164, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ocena od";
            // 
            // YearTo
            // 
            this.YearTo.Location = new System.Drawing.Point(74, 88);
            this.YearTo.Name = "YearTo";
            this.YearTo.Size = new System.Drawing.Size(74, 20);
            this.YearTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Do roku";
            // 
            // YearSince
            // 
            this.YearSince.Location = new System.Drawing.Point(75, 56);
            this.YearSince.Name = "YearSince";
            this.YearSince.Size = new System.Drawing.Size(73, 20);
            this.YearSince.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Od roku";
            // 
            // GenreList
            // 
            this.GenreList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreList.FormattingEnabled = true;
            this.GenreList.Location = new System.Drawing.Point(74, 23);
            this.GenreList.Name = "GenreList";
            this.GenreList.Size = new System.Drawing.Size(74, 21);
            this.GenreList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gatunek";
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
            // TittleSearch
            // 
            this.TittleSearch.Location = new System.Drawing.Point(19, 71);
            this.TittleSearch.Name = "TittleSearch";
            this.TittleSearch.Size = new System.Drawing.Size(196, 20);
            this.TittleSearch.TabIndex = 1;
            this.TittleSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TittleSearch_KeyDown);
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
            // Tittle
            // 
            this.Tittle.HeaderText = "Tytuł";
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            this.Tittle.Width = 200;
            // 
            // EnglishTittle
            // 
            this.EnglishTittle.HeaderText = "Tytuł angielski";
            this.EnglishTittle.Name = "EnglishTittle";
            this.EnglishTittle.ReadOnly = true;
            this.EnglishTittle.Width = 175;
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
            this.HowMuchWantSee.Width = 160;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(971, 562);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.DataGridView DataMovies;
        private System.Windows.Forms.Button GiveRandomMovie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox TittleSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GenreList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox YearTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YearSince;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RateTo;
        private System.Windows.Forms.TextBox RateSince;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClearFiltrationArea;
        private System.Windows.Forms.Button Filtration;
        private System.Windows.Forms.ComboBox Countries;
        private System.Windows.Forms.ComboBox LevelOfInterests;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnglishTittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn HowMuchWantSee;
    }
}