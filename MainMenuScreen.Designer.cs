namespace ProNatur_Biomarkt_GmbH
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            btnPro = new Button();
            btnRechnung = new Button();
            SuspendLayout();
            // 
            // btnPro
            // 
            btnPro.BackgroundImage = (Image)resources.GetObject("btnPro.BackgroundImage");
            btnPro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPro.ForeColor = SystemColors.ButtonFace;
            btnPro.Location = new Point(12, 22);
            btnPro.Name = "btnPro";
            btnPro.Size = new Size(283, 127);
            btnPro.TabIndex = 0;
            btnPro.Text = "Produkte verwalten";
            btnPro.UseVisualStyleBackColor = true;
            btnPro.Click += btnPro_Click;
            // 
            // btnRechnung
            // 
            btnRechnung.BackgroundImage = (Image)resources.GetObject("btnRechnung.BackgroundImage");
            btnRechnung.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRechnung.ForeColor = SystemColors.ButtonFace;
            btnRechnung.Location = new Point(301, 22);
            btnRechnung.Name = "btnRechnung";
            btnRechnung.Size = new Size(283, 127);
            btnRechnung.TabIndex = 1;
            btnRechnung.Text = "Rechnung erstellen";
            btnRechnung.UseVisualStyleBackColor = true;
            btnRechnung.Click += btnRechnung_Click;
            // 
            // MainMenuScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(597, 161);
            Controls.Add(btnRechnung);
            Controls.Add(btnPro);
            Name = "MainMenuScreen";
            Text = "Hauptmenü";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPro;
        private Button btnRechnung;
    }
}