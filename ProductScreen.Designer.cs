namespace ProNatur_Biomarkt_GmbH
{
    partial class ProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxPreis = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxMarke = new TextBox();
            label4 = new Label();
            comboBoxkategorie = new ComboBox();
            btnSpeichern = new Button();
            btnFelderleeren = new Button();
            btnBearbeiten = new Button();
            btnLoeschen = new Button();
            productsDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productsDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.MenuText;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(91, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(315, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPreis
            // 
            textBoxPreis.BackColor = SystemColors.MenuText;
            textBoxPreis.BorderStyle = BorderStyle.FixedSingle;
            textBoxPreis.ForeColor = Color.White;
            textBoxPreis.Location = new Point(91, 200);
            textBoxPreis.Name = "textBoxPreis";
            textBoxPreis.Size = new Size(75, 23);
            textBoxPreis.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 208);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Preis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Kategorie";
            // 
            // textBoxMarke
            // 
            textBoxMarke.BackColor = SystemColors.MenuText;
            textBoxMarke.BorderStyle = BorderStyle.FixedSingle;
            textBoxMarke.ForeColor = Color.White;
            textBoxMarke.Location = new Point(91, 70);
            textBoxMarke.Name = "textBoxMarke";
            textBoxMarke.Size = new Size(158, 23);
            textBoxMarke.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 72);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Marke";
            // 
            // comboBoxkategorie
            // 
            comboBoxkategorie.BackColor = Color.Black;
            comboBoxkategorie.ForeColor = Color.White;
            comboBoxkategorie.FormattingEnabled = true;
            comboBoxkategorie.Items.AddRange(new object[] { "Obst", "Gemüse", "Fleisch", "Drogerie", "Getränke" });
            comboBoxkategorie.Location = new Point(91, 137);
            comboBoxkategorie.Name = "comboBoxkategorie";
            comboBoxkategorie.Size = new Size(158, 23);
            comboBoxkategorie.TabIndex = 8;
            // 
            // btnSpeichern
            // 
            btnSpeichern.BackColor = Color.Black;
            btnSpeichern.FlatStyle = FlatStyle.Flat;
            btnSpeichern.ForeColor = Color.White;
            btnSpeichern.Location = new Point(91, 262);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(75, 23);
            btnSpeichern.TabIndex = 9;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = false;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // btnFelderleeren
            // 
            btnFelderleeren.BackColor = Color.Black;
            btnFelderleeren.FlatStyle = FlatStyle.Flat;
            btnFelderleeren.ForeColor = Color.White;
            btnFelderleeren.Location = new Point(295, 262);
            btnFelderleeren.Name = "btnFelderleeren";
            btnFelderleeren.Size = new Size(111, 23);
            btnFelderleeren.TabIndex = 10;
            btnFelderleeren.Text = "Felder Leeren";
            btnFelderleeren.UseVisualStyleBackColor = false;
            btnFelderleeren.Click += btnFelderleeren_Click;
            // 
            // btnBearbeiten
            // 
            btnBearbeiten.BackColor = Color.Black;
            btnBearbeiten.FlatStyle = FlatStyle.Flat;
            btnBearbeiten.ForeColor = Color.White;
            btnBearbeiten.Location = new Point(188, 262);
            btnBearbeiten.Name = "btnBearbeiten";
            btnBearbeiten.Size = new Size(75, 23);
            btnBearbeiten.TabIndex = 11;
            btnBearbeiten.Text = "Bearbeiten";
            btnBearbeiten.UseVisualStyleBackColor = false;
            btnBearbeiten.Click += btnBearbeiten_Click;
            // 
            // btnLoeschen
            // 
            btnLoeschen.BackColor = Color.Black;
            btnLoeschen.FlatStyle = FlatStyle.Flat;
            btnLoeschen.ForeColor = Color.White;
            btnLoeschen.Location = new Point(432, 262);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(75, 23);
            btnLoeschen.TabIndex = 12;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = false;
            btnLoeschen.Click += btnLöschen_Click;
            // 
            // productsDGV
            // 
            productsDGV.AllowUserToAddRows = false;
            productsDGV.AllowUserToDeleteRows = false;
            productsDGV.AllowUserToResizeColumns = false;
            productsDGV.AllowUserToResizeRows = false;
            productsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDGV.BackgroundColor = Color.Black;
            productsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDGV.Location = new Point(12, 308);
            productsDGV.Name = "productsDGV";
            productsDGV.RowHeadersVisible = false;
            productsDGV.RowTemplate.DefaultCellStyle.BackColor = Color.Black;
            productsDGV.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            productsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.White;
            productsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(75, 75, 75);
            productsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDGV.Size = new Size(775, 257);
            productsDGV.TabIndex = 13;
            productsDGV.CellContentClick += productsDGV_CellContentClick;
            // 
            // ProductScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(799, 577);
            Controls.Add(productsDGV);
            Controls.Add(btnLoeschen);
            Controls.Add(btnBearbeiten);
            Controls.Add(btnFelderleeren);
            Controls.Add(btnSpeichern);
            Controls.Add(comboBoxkategorie);
            Controls.Add(textBoxMarke);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPreis);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produkte";
            
            ((System.ComponentModel.ISupportInitialize)productsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxPreis;
        private Label label2;
        private Label label3;
        private TextBox textBoxMarke;
        private Label label4;
        private ComboBox comboBoxkategorie;
        private Button btnSpeichern;
        private Button btnFelderleeren;
        private Button btnBearbeiten;
        private Button btnLoeschen;
        private DataGridView productsDGV;
    }
}