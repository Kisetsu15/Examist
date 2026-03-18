using System.Windows.Forms;

namespace Examist {
    public partial class StartPage : Form
    {
        readonly Student student;

        public StartPage()
        {
            var selectionPage = new SelectionPage(student);
            selectionPage.Show();
            Hide();
        }
    }
}