using System.Data;
using System.Data.SqlClient;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class Rechnung : Form
    {
        int lastselectedProductKey;

        public Rechnung()
        {
            InitializeComponent();
            ShowBill();
        }

        void ShowBill()
        {
            var databaseConnection = new SqlConnection(Global.ConnectionString);
            databaseConnection.Open();
            string query = string.Format("select * from Rechnung");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridBill.DataSource = dataSet.Tables[0];
            databaseConnection.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (textBoxMarke.Text == "" || textBoxName.Text == "" || textBoxPreis.Text == "")
            {
                return;
            }
            string emfeangerName = textBoxName.Text;
            string Gesamtpreis = textBoxPreis.Text;
            string produktName = textBoxMarke.Text;
            string query = string.Format("insert into Rechnung values('{0}','{1}','{2}')", emfeangerName, produktName, Gesamtpreis);
            executeQuery(query);
            ClearAllFirlds();
            ShowBill();
        }

        void executeQuery(string query)
        {
            var databaseConnection = new SqlConnection(Global.ConnectionString);
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        void ClearAllFirlds()
        {
            textBoxMarke.Text = "";
            textBoxName.Text = "";
            textBoxPreis.Text = "";
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            if (textBoxMarke.Text == "" || textBoxName.Text == "" || textBoxPreis.Text == "")
            {
                return;
            }
            string emfeangerName = textBoxName.Text;
            string Gesamtpreis = textBoxPreis.Text;
            string produktName = textBoxMarke.Text;
            string query = string.Format("update Rechnung set EmfeangerName='{0}',Produkt='{1}',Gesamtpreis='{2}'where Id={3}"
                , emfeangerName, produktName, Gesamtpreis, lastselectedProductKey);
            executeQuery(query);
            ClearAllFirlds();
            ShowBill();
        }

        private void btnFelderleeren_Click(object sender, EventArgs e)
        {
            ClearAllFirlds();
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            if (textBoxMarke.Text == "" || textBoxName.Text == "" || textBoxPreis.Text == "")
            {
                return;
            }
            string emfeangerName = textBoxName.Text;
            string Gesamtpreis = textBoxPreis.Text;
            string produktName = textBoxMarke.Text;
            string query = string.Format("delete from Rechnung where Id={0}", lastselectedProductKey);
            executeQuery(query);
            ClearAllFirlds();
            ShowBill();
        }



        private void Rechnung_Load(object sender, EventArgs e)
        {
            ShowBill();
        }

        private void dataGridBill_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridBill.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridBill.SelectedRows[0];
                if (selectedRow.Cells.Count >= 4)
                {
                    lastselectedProductKey = (int)dataGridBill.SelectedRows[0].Cells[0].Value;
                    textBoxName.Text = dataGridBill.SelectedRows[0].Cells[1].Value.ToString();
                    textBoxMarke.Text = dataGridBill.SelectedRows[0].Cells[2].Value.ToString();
                    textBoxPreis.Text = dataGridBill.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
        }
    }
}
