using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WannaSee
{
    public partial class Movies : Form
    {
        public readonly Form1 MainWindow;
        public string Url;
        public List<Movie> MoviesList = new List<Movie>();
        public List<Movie> actualList = new List<Movie>();
        public List<String> Genres = new List<string>();
        public List<String> CountriesList = new List<string>();

        public Movies(Form1 form1)
        {
            MainWindow = form1;
            Url = GetUrl();

            MoviesList = GetMoviesList();
            RepairLetters();
            actualList = MoviesList.ToList();

            InitializeComponent();
            MainWindow.Hide();

            //main area with movies
            SetGridValues(MoviesList);
            ChangeBackgroundColor();

            FillComboBoxes();

            DataMovies.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            DataMovies.EnableHeadersVisualStyles = false;
        }

        private void FillComboBoxes()
        {
            //combobox with genres and countries
            AddItemsToListsIfDontExist(MoviesList);
            AddListsToComboBox();

            //combobox with interestslevel
            AddInterestsLevelsToComboBox();
        }

        private void AddItemsToListsIfDontExist(List<Movie> listOfMovies)
        {
            foreach (var mov in listOfMovies)
            {
                //add to list with genres
                var gen = mov.Genre;
                gen = gen.Replace(" ", string.Empty);
                List<string> genres = gen.Split(',').ToList();
                foreach (var genre in genres)
                {
                    if (!Genres.Contains(genre))
                    {
                        Genres.Add(genre);
                    }
                }


                //add to list with countries
                var country = mov.Country;
                country = country.Replace(" ", string.Empty);
                List<string> countries = country.Split(',').ToList();
                foreach (var cou in countries)
                {
                    if (!CountriesList.Contains(cou))
                    {
                        CountriesList.Add(cou);
                    }
                }
            }
        }


        private void AddListsToComboBox()
        {
            foreach (var genre in Genres)
            {
                GenreList.Items.Add(genre);
            }

            foreach (var country in CountriesList)
            {
                Countries.Items.Add(country);
            }
        }


        private void AddInterestsLevelsToComboBox()
        {
            LevelOfInterests.Items.Add("jestem zainteresowany");
            LevelOfInterests.Items.Add("kiedyś obejrzę");
            LevelOfInterests.Items.Add("na pewno obejrzę");
            LevelOfInterests.Items.Add("muszę obejrzeć");
            LevelOfInterests.Items.Add("umrę jak nie zobaczę");
        }


        private string GetUrl()
        {
            return File.ReadAllText("user.txt");
        }

        private List<Movie> GetMoviesList()
        {
            var listOfMovies = new List<Movie>();
            int count = 0;
            try
            {
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(Url);
                var mainNode = htmlDoc.DocumentNode.SelectSingleNode("//body/div[@id='body']")
                    .SelectSingleNode("//div[@class='bodyBackground']")
                    .SelectSingleNode("//div[@class='bodyWrapper ']");
                var moviesInfo = mainNode.SelectNodes("//div/table[@class='sortable wantToSeeSee']/tbody/td");

                var movie = new Movie();
                foreach (var singleMovie in moviesInfo)
                {
                    if (count % 2 == 0) // movie info
                    {
                        movie = new Movie();
                        var row = singleMovie.InnerText;
                        movie.Tittle = singleMovie.Attributes[0].DeEntitizeValue;

                        movie.Year = row.Substring(singleMovie.InnerText.LastIndexOf('(') + 1, 4);

                        //add Genre (to list)
                        movie.Genre = row.Substring(row.LastIndexOf("gatunek:") + 8);

                        //add EnglishTittle
                        try
                        {
                            movie.EnglishTittle = row.Substring(row.LastIndexOf(')') + 1,
                                row.LastIndexOf(" kraj:") - row.LastIndexOf(')'));
                        }
                        catch (Exception e)
                        {
                            movie.EnglishTittle = "";
                        }

                        //add Country info
                        try
                        {
                            movie.Country = row.Substring(row.LastIndexOf("kraj:") + 5,
                                row.LastIndexOf(" gatunek:") - row.LastIndexOf("kraj") - 5);
                        }
                        catch (Exception e)
                        {
                            movie.Country = "";
                        }

                        //add Rates
                        if (MainWindow.LoadRates())
                        {
                            try
                            {
                                var htmlMovie = singleMovie.InnerHtml;
                                var movieUrl = htmlMovie.Substring(htmlMovie.IndexOf("href=\"") + 6,
                                    htmlMovie.IndexOf("class") - htmlMovie.IndexOf("href=\"") - 8);
                                movieUrl = "http://www.filmweb.pl" + movieUrl;
                                movie.Rate = GetRateOfMovie(movieUrl);
                            }
                            catch (Exception e)
                            {
                                movie.Rate = "";
                            }
                        }
                    }

                    else // how much want to see
                    {
                        movie.HowMuchWantSee = singleMovie.LastChild.InnerText;
                        listOfMovies.Add(movie);
                    }
                    count++;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Błąd odczytu. Sprawdź połączenie internetowe lub czy wprowadzona " +
                                "została poprawna nazwa użytkownika", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return listOfMovies;
        }


        private void RepairLetters()
        {
            MoviesList.Where(d => d.Genre.Contains("Kr&oacute;tkometrażowy")).ToList()
                .ForEach(s => s.Genre = s.Genre.Replace("Kr&oacute;tkometrażowy", "Krótkometrażowy"));
            foreach (var movie in MoviesList)
            {
                if (movie.Genre.Contains("Kr&oacute;tkometrażowy"))
                    movie.Genre.Replace("Kr&oacute;tkometrażowy", "Krótkometrażowy");
            }
        }


        private string GetRateOfMovie(string movieUrl)
        {
            HtmlWeb web2 = new HtmlWeb();
            var htmlDoc2 = web2.Load(movieUrl);
            var mainNode2 = htmlDoc2.DocumentNode
                .SelectSingleNode("//body/div[@class='entity-page-wrapper']/div[@id='body']")
                .SelectSingleNode("//div[@class='bodyBackground']")
                .SelectSingleNode("//div[@class='bodyWrapper ']/div[@id='sidebar']")
                .SelectSingleNode("//div[@class='filmRateBox']");
            var textNode2 = mainNode2.ChildNodes[6].InnerText;
            return textNode2.Substring(textNode2.IndexOf("communityRateInfo:") + 19, 3);
        }


        private void SetGridValues(List<Movie> MoviesList)
        {
            DataMovies.Rows.Clear();
            DataMovies.Refresh();

            foreach (var movie in MoviesList)
            {
                this.DataMovies.Rows.Add(movie.Tittle, movie.EnglishTittle, movie.Rate,
                    movie.Genre, movie.Year, movie.Country, movie.HowMuchWantSee);
            }
        }

        private void SetGridValues(Movie SingleMovie)
        {
            DataMovies.Rows.Clear();
            DataMovies.Refresh();

            this.DataMovies.Rows.Add(SingleMovie.Tittle, SingleMovie.EnglishTittle, SingleMovie.Rate,
                SingleMovie.Genre, SingleMovie.Year, SingleMovie.Country, SingleMovie.HowMuchWantSee);

            DataMovies.Refresh();
        }

        private void ChangeBackgroundColor()
        {
            foreach (DataGridViewRow row in DataMovies.Rows)
                row.DefaultCellStyle.BackColor = Color.Bisque;
        }


        private void ClearSelection()
        {
            DataMovies.ClearSelection();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
            MainWindow.Show();
        }


        private void Movies_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DestroyHandle();
            MainWindow.Show();
        }

        private void GiveRandomMovie_Click(object sender, EventArgs e)
        {
            var length = MoviesList.Count;
            Random rnd = new Random();
            var index = rnd.Next(length) - 1;
            var movie = MoviesList[index];
            SetGridValues(movie);
            ClearSelection();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            SetGridValues(MoviesList);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchMovie();
        }


        private void TittleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchMovie();
        }

        private void SearchMovie()
        {
            var partOfTittle = TittleSearch.Text;
            if (partOfTittle == "")
                return;

            actualList.Clear();
            foreach (var movie in MoviesList)
            {
                if (movie.Tittle.ToLower().Contains(partOfTittle.ToLower()) ||
                    movie.EnglishTittle.ToLower().Contains(partOfTittle.ToLower()))
                    actualList.Add(movie);
            }

            SetGridValues(actualList);
        }

        private void ClearFiltrationArea_Click(object sender, EventArgs e)
        {
            GenreList.SelectedIndex = -1;
            YearSince.Text = "";
            YearTo.Text = "";
            RateSince.Text = "";
            RateTo.Text = "";
            Countries.SelectedIndex = -1;
            LevelOfInterests.SelectedIndex = -1;
            SetGridValues(MoviesList);
        }

        private void Filtration_Click(object sender, EventArgs e)
        {
            Filtr filtr = new Filtr();
            filtr = GetFiltrationValues();

            actualList = MoviesList.ToList();

            if (filtr.Genre != "")
            {
                List<Movie> genresFiltr = MoviesList.Where(q => q.Genre.Contains(filtr.Genre)).ToList();
                actualList = actualList.Intersect(genresFiltr).ToList();
            }

            if (filtr.SinceYear != "")
            {
                List<Movie> yearSinceFiltr = MoviesList.Where(q => Int32.Parse(q.Year) >= Int32.Parse(filtr.SinceYear)).ToList();
                actualList = actualList.Intersect(yearSinceFiltr).ToList();
            }

            if (filtr.ToYear != "")
            {
                List<Movie> yearToFiltr = MoviesList.Where(q => Int32.Parse(q.Year) <= Int32.Parse(filtr.ToYear)).ToList();
                actualList = actualList.Intersect(yearToFiltr).ToList();
            }

            if (MainWindow.LoadRates())
            {
                if (filtr.SinceRate != "")
                {
                    List<Movie> rateSinceFiltr = MoviesList.Where(q => float.Parse(q.Rate) >= float.Parse(filtr.SinceRate))
                        .ToList();
                    actualList = actualList.Intersect(rateSinceFiltr).ToList();
                }
                if (filtr.ToRate != "")
                {
                    List<Movie> rateToFiltr = MoviesList.Where(q => float.Parse(q.Rate) <= float.Parse(filtr.ToRate)).ToList();
                    actualList = actualList.Intersect(rateToFiltr).ToList();
                }
            }

            if (filtr.Country != "")
            {
                List<Movie> countriesFiltr = MoviesList.Where(q => q.Country.Contains(filtr.Country)).ToList();
                actualList = actualList.Intersect(countriesFiltr).ToList();
            }

            if (filtr.InterestsLevel != "")
            {
                List<Movie> interestsFiltr = MoviesList.Where(q => q.HowMuchWantSee.Contains(filtr.InterestsLevel)).ToList();
                actualList = actualList.Intersect(interestsFiltr).ToList();
            }


            SetGridValues(actualList);
        }

        private Filtr GetFiltrationValues()
        {
            Filtr filtrObj = new Filtr();

            var itemSelected = GenreList.SelectedIndex > -1;
            filtrObj.Genre = itemSelected ? GenreList.SelectedItem.ToString() : "";

            itemSelected = LevelOfInterests.SelectedIndex > -1;
            filtrObj.InterestsLevel = itemSelected ? LevelOfInterests.SelectedItem.ToString() : "";

            itemSelected = Countries.SelectedIndex > -1;
            filtrObj.Country = itemSelected ? Countries.SelectedItem.ToString() : "";

            int n;

            var isNumeric = int.TryParse(YearSince.Text, out n);
            filtrObj.SinceYear = isNumeric ? YearSince.Text : "";

            isNumeric = int.TryParse(YearTo.Text, out n);
            filtrObj.ToYear = isNumeric ? YearTo.Text : "";

            float d;
            var isFloat = float.TryParse(RateSince.Text, out d);
            filtrObj.SinceRate = isFloat ? RateSince.Text : "";

            isFloat = float.TryParse(RateTo.Text, out d);
            filtrObj.ToRate = isFloat ? RateTo.Text : "";

            return filtrObj;
        }
    }
}