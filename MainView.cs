namespace Clock
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            this.ActiveControl = timeLabelTop; // Disable awful focus from textBox
        }
    }
}