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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeUser_Click(object sender, EventArgs e)
        {
            new UserPanel().Show();
        }

        private void ListOfFilms_Click(object sender, EventArgs e)
        {
            new Movies(this).Show();
        }
    }
}
