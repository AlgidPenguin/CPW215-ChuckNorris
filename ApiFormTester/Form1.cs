using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ApiFormTester
{
    public partial class jokeForm : Form
    {
        public jokeForm()
        {
            InitializeComponent();
        }

        private async void jokeBtn_Click(object sender, EventArgs e)
        {
            Joke j = await GetJoke();
            jokeTxt.Text = j.JokeText;
        }

        private async static Task<Joke> GetJoke()
        {
            return await ChuckNorrisClient.GetRandomJoke();
        }

        private async static Task<IEnumerable<string>> GetCategories()
        {
            return await ChuckNorrisClient.GetCategories();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var categories = await GetCategories();

            foreach (var category in categories)
            {
                jokeCategoriesCbx.Items.Add(category);
            }
        }
    }
}
