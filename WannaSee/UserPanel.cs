using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WannaSee
{
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void SaveUser_Click(object sender, EventArgs e)
        {
            if (userName.Text != "")
            {
                try
                {    var sb = new StringBuilder();
                    sb.Append("http://www.filmweb.pl/user/");
                    sb.Append(userName.Text);
                    sb.Append("/films/wantToSee");
                     File.WriteAllText("user.txt", sb.ToString());
                    MessageBox.Show("Poprawnie zmieniono użytkownika", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DestroyHandle();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Problem przy operacji na pliku. Plik uszkodzony lub nie masz praw dostepu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Nie podano nazwy użytkownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
