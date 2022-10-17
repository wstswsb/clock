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
            HideControl();
        }

        private void MainView_Click(object sender, EventArgs e)
        {
            HideControl();
        }

        private void HideControl()
        {
            this.ActiveControl = timeLabelTop; // Disable awful focus from textBox
        }
    }
}