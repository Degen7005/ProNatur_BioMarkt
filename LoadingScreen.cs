namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            label2.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                loadingbarTimer.Stop();
                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();
                this.Hide();
            }
        }


    }
}
