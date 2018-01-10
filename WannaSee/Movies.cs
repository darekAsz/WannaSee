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


        public Movies(Form1 form1)
        {
            MainWindow = form1;
            Url = GetUrl();
            MoviesList = GetMoviesList();
            InitializeComponent();
            MainWindow.Hide();
            AddToGrid();

            DataMovies.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            DataMovies.EnableHeadersVisualStyles = false;
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
                    if (count % 2 == 0) // title
                    {
                        movie = new Movie();
                        var row = singleMovie.InnerText;
                        //movie.Tittle = row.Substring(0, row.LastIndexOf('('));
                        movie.Tittle = singleMovie.Attributes[0].DeEntitizeValue;

                        movie.Year = row.Substring(singleMovie.InnerText.LastIndexOf('(') + 1, 4);
                        movie.Genre = row.Substring(row.LastIndexOf("gatunek:") + 8);

                        try
                        {
                            movie.EnglishTittle = row.Substring(row.LastIndexOf(')') + 1,
                                row.LastIndexOf(" kraj:") - row.LastIndexOf(')'));
                        }
                        catch (Exception e)
                        {
                            movie.EnglishTittle = "";
                        }

                        try
                        {
                            movie.Country = row.Substring(row.LastIndexOf("kraj:") + 5,
                                row.LastIndexOf(" gatunek:") - row.LastIndexOf("kraj") - 5);
                        }
                        catch (Exception e)
                        {
                            movie.Country = "";
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


        private void AddToGrid()
        {
            foreach (var movie in MoviesList)
            {
                this.DataMovies.Rows.Add(movie.Tittle, movie.EnglishTittle, movie.Genre, movie.Year, movie.Country, movie.HowMuchWantSee);
            }
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
    }
}