namespace ProNatur_Biomarkt_GmbH
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            ProductScreen productScreen = new ProductScreen();
            productScreen.Show();
            this.Hide();
        }

        private void btnRechnung_Click(object sender, EventArgs e)
        {
            Rechnung rechnungsScreen = new Rechnung();
            rechnungsScreen.Show();
            this.Hide();
        }
    }
}
