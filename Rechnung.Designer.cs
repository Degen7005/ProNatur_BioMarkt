namespace ProNatur_Biomarkt_GmbH
{
    partial class Rechnung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoeschen = new Button();
            btnBearbeiten = new Button();
            btnFelderleeren = new Button();
            btnSpeichern = new Button();
            textBoxMarke = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxPreis = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            dataGridBill = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridBill).BeginInit();
            SuspendLayout();
            // 
            // btnLoeschen
            // 
            btnLoeschen.BackColor = Color.Black;
            btnLoeschen.FlatStyle = FlatStyle.Flat;
            btnLoeschen.ForeColor = Color.White;
            btnLoeschen.Location = new Point(436, 249);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(75, 23);
            btnLoeschen.TabIndex = 24;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = false;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // btnBearbeiten
            // 
            btnBearbeiten.BackColor = Color.Black;
            btnBearbeiten.FlatStyle = FlatStyle.Flat;
            btnBearbeiten.ForeColor = Color.White;
            btnBearbeiten.Location = new Point(192, 249);
            btnBearbeiten.Name = "btnBearbeiten";
            btnBearbeiten.Size = new Size(75, 23);
            btnBearbeiten.TabIndex = 23;
            btnBearbeiten.Text = "Bearbeiten";
            btnBearbeiten.UseVisualStyleBackColor = false;
            btnBearbeiten.Click += btnBearbeiten_Click;
            // 
            // btnFelderleeren
            // 
            btnFelderleeren.BackColor = Color.Black;
            btnFelderleeren.FlatStyle = FlatStyle.Flat;
            btnFelderleeren.ForeColor = Color.White;
            btnFelderleeren.Location = new Point(299, 249);
            btnFelderleeren.Name = "btnFelderleeren";
            btnFelderleeren.Size = new Size(111, 23);
            btnFelderleeren.TabIndex = 22;
            btnFelderleeren.Text = "Felder Leeren";
            btnFelderleeren.UseVisualStyleBackColor = false;
            btnFelderleeren.Click += btnFelderleeren_Click;
            // 
            // btnSpeichern
            // 
            btnSpeichern.BackColor = Color.Black;
            btnSpeichern.FlatStyle = FlatStyle.Flat;
            btnSpeichern.ForeColor = Color.White;
            btnSpeichern.Location = new Point(95, 249);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(75, 23);
            btnSpeichern.TabIndex = 21;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = false;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // textBoxMarke
            // 
            textBoxMarke.BackColor = SystemColors.MenuText;
            textBoxMarke.BorderStyle = BorderStyle.FixedSingle;
            textBoxMarke.ForeColor = Color.White;
            textBoxMarke.Location = new Point(119, 86);
            textBoxMarke.Name = "textBoxMarke";
            textBoxMarke.Size = new Size(158, 23);
            textBoxMarke.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(20, 88);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 18;
            label4.Text = "Produkt";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(20, 153);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 17;
            // 
            // textBoxPreis
            // 
            textBoxPreis.BackColor = SystemColors.MenuText;
            textBoxPreis.BorderStyle = BorderStyle.FixedSingle;
            textBoxPreis.ForeColor = Color.White;
            textBoxPreis.Location = new Point(119, 151);
            textBoxPreis.Name = "textBoxPreis";
            textBoxPreis.Size = new Size(75, 23);
            textBoxPreis.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(20, 153);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 15;
            label2.Text = "Gesamt Preis";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.MenuText;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(119, 23);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(315, 23);
            textBoxName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 13;
            label1.Text = "Emfänger Name";
            // 
            // dataGridBill
            // 
            dataGridBill.AllowUserToAddRows = false;
            dataGridBill.AllowUserToDeleteRows = false;
            dataGridBill.AllowUserToResizeColumns = false;
            dataGridBill.AllowUserToResizeRows = false;
            dataGridBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBill.BackgroundColor = Color.Black;
            dataGridBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBill.Dock = DockStyle.Bottom;
            dataGridBill.Location = new Point(0, 307);
            dataGridBill.Name = "dataGridBill";
            dataGridBill.RowHeadersVisible = false;
            dataGridBill.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            dataGridBill.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridBill.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridBill.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(75, 75, 75);
            dataGridBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridBill.Size = new Size(800, 257);
            dataGridBill.TabIndex = 25;
            dataGridBill.CellContentClick += dataGridBill_CellContentClick_1;
            // 
            // Rechnung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 564);
            Controls.Add(dataGridBill);
            Controls.Add(btnLoeschen);
            Controls.Add(btnBearbeiten);
            Controls.Add(btnFelderleeren);
            Controls.Add(btnSpeichern);
            Controls.Add(textBoxMarke);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPreis);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "Rechnung";
            Text = "Rechnung";
            Load += Rechnung_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoeschen;
        private Button btnBearbeiten;
        private Button btnFelderleeren;
        private Button btnSpeichern;
        private TextBox textBoxMarke;
        private Label label4;
        private Label label3;
        private TextBox textBoxPreis;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private DataGridView dataGridBill;
    }
}