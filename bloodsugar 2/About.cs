using System.Windows.Forms;

namespace bloodsugar_2
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            //Navigates to page for info about program
            githubPage.Navigate("https://github.com/kiljoy001/bloodsugar2");
        }

        private void githubPage_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
