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
        public List<String> MoviesList = new List<string>();


        public Movies(Form1 form1)
        {   
            MainWindow = form1;
            Url = GetUrl();
            //MoviesList = GetMoviesList();
            InitializeComponent();
        }

        private void GetMoviesList()
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(Url);
                var mainNode = htmlDoc.DocumentNode.SelectSingleNode("//body/div[@id='body']")
                    .SelectSingleNode("//div[@class='bodyBackground']")
                    .SelectSingleNode("//div[@class='bodyWrapper ']");
                var moviesInfo = mainNode.SelectNodes("//div/table[@class='sortable wantToSeeSee']/tbody/td");
                int i = 9;
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd odczytu. Sprawdź połączenie internetowe lub czy wprowadzona " +
                                "została poprawna nazwa użytkownika", "Błąd", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private string GetUrl()
        {
            return File.ReadAllText("user.txt");
        }





        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
            MainWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetMoviesList();
        }

        private void Movies_FormClosing(object sender, FormClosingEventArgs e)
        {      
            this.DestroyHandle(); 
            MainWindow.Show();
        }

        
    }
}
