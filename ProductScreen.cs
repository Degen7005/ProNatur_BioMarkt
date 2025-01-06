
using System.Data;
using System.Data.SqlClient;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class ProductScreen : Form
    {
        int lastselectedProductKey;

        public ProductScreen()
        {
            InitializeComponent();
            ShowProducts();
        }

        void ShowProducts()
        {
            var conn = new SqlConnection(Global.ConnectionString);
            conn.Open();
            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            productsDGV.DataSource = dataSet.Tables[0];
            conn.Close();
        }
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxMarke.Text == "" || textBoxPreis.Text == null || comboBoxkategorie.SelectedItem == null)
            {
                return;
            }
            string produktName = textBoxName.Text;
            string productBrand = textBoxMarke.Text;
            string productCatergory = comboBoxkategorie.Text;
            float productPrice = float.Parse(textBoxPreis.Text);
            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", produktName, productBrand, productCatergory, productPrice);

            executeQuery(query);
            ClearAllFields();
            ShowProducts();
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            if (lastselectedProductKey == 0)
            {
                MessageBox.Show("Bitte wählen sie erst ein Produkt");
                return;
            }

            string query = string.Format("update Products set Name='{0}',Brand='{1}',Category='{2}',Price='{3}' where Id={4}"
                , textBoxName.Text, textBoxMarke.Text, comboBoxkategorie.Text, textBoxPreis.Text, lastselectedProductKey);
            executeQuery(query);
            ClearAllFields();
            ShowProducts();
        }

        private void btnFelderleeren_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            textBoxName.Text = "";
            textBoxMarke.Text = "";
            textBoxPreis.Text = "";
            comboBoxkategorie.Text = "";
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            if (lastselectedProductKey == 0)
            {
                MessageBox.Show("Bitte wählen sie erst ein Produkt");
                return;
            }
            string query = string.Format("delete from Products where Id={0};", lastselectedProductKey);
            executeQuery(query);
            ClearAllFields();
            ShowProducts();
        }

        void executeQuery(string query)
        {
            var databaseConnection = new SqlConnection(Global.ConnectionString);
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsDGV.SelectedRows.Count > 0)
            {
                var selectedRow = productsDGV.SelectedRows[0];
                if (selectedRow.Cells.Count >= 4)
                {
                    textBoxName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
                    textBoxMarke.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
                    comboBoxkategorie.SelectedItem = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
                    textBoxPreis.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();
                    lastselectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;
                }
            }
        }
    }
}
