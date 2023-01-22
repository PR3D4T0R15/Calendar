namespace CalendarEX
{
    partial class OknoNoweWydarzenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoNoweWydarzenie));
            this.ukladGlowny = new System.Windows.Forms.TableLayoutPanel();
            this.ukladPrzyciskow = new System.Windows.Forms.FlowLayoutPanel();
            this.Zapisz = new System.Windows.Forms.Button();
            this.NazwaWydarzenia_tytul = new System.Windows.Forms.Label();
            this.Data_tytul = new System.Windows.Forms.Label();
            this.NazwaWydarzenia = new System.Windows.Forms.TextBox();
            this.data_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Data_dzien = new System.Windows.Forms.TextBox();
            this.Data_miesiac = new System.Windows.Forms.ComboBox();
            this.Data_rok = new System.Windows.Forms.TextBox();
            this.CzyWazneWydarzenie = new System.Windows.Forms.CheckBox();
            this.ukladGlowny.SuspendLayout();
            this.ukladPrzyciskow.SuspendLayout();
            this.data_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ukladGlowny
            // 
            this.ukladGlowny.ColumnCount = 1;
            this.ukladGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ukladGlowny.Controls.Add(this.ukladPrzyciskow, 0, 5);
            this.ukladGlowny.Controls.Add(this.NazwaWydarzenia_tytul, 0, 3);
            this.ukladGlowny.Controls.Add(this.Data_tytul, 0, 0);
            this.ukladGlowny.Controls.Add(this.NazwaWydarzenia, 0, 4);
            this.ukladGlowny.Controls.Add(this.data_panel, 0, 1);
            this.ukladGlowny.Controls.Add(this.CzyWazneWydarzenie, 0, 2);
            this.ukladGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ukladGlowny.Location = new System.Drawing.Point(0, 0);
            this.ukladGlowny.Margin = new System.Windows.Forms.Padding(0);
            this.ukladGlowny.Name = "ukladGlowny";
            this.ukladGlowny.RowCount = 6;
            this.ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.95349F));
            this.ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.09302F));
            this.ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.95349F));
            this.ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.95349F));
            this.ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.09302F));
            this.ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.95349F));
            this.ukladGlowny.Size = new System.Drawing.Size(353, 219);
            this.ukladGlowny.TabIndex = 0;
            // 
            // ukladPrzyciskow
            // 
            this.ukladPrzyciskow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ukladPrzyciskow.Controls.Add(this.Zapisz);
            this.ukladPrzyciskow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ukladPrzyciskow.Location = new System.Drawing.Point(0, 186);
            this.ukladPrzyciskow.Margin = new System.Windows.Forms.Padding(0);
            this.ukladPrzyciskow.Name = "ukladPrzyciskow";
            this.ukladPrzyciskow.Size = new System.Drawing.Size(353, 33);
            this.ukladPrzyciskow.TabIndex = 0;
            // 
            // Zapisz
            // 
            this.Zapisz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.Zapisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zapisz.Location = new System.Drawing.Point(275, 3);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 23);
            this.Zapisz.TabIndex = 0;
            this.Zapisz.Text = "ZAPISZ";
            this.Zapisz.UseVisualStyleBackColor = false;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // NazwaWydarzenia_tytul
            // 
            this.NazwaWydarzenia_tytul.AutoSize = true;
            this.NazwaWydarzenia_tytul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwaWydarzenia_tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaWydarzenia_tytul.Location = new System.Drawing.Point(9, 108);
            this.NazwaWydarzenia_tytul.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.NazwaWydarzenia_tytul.Name = "NazwaWydarzenia_tytul";
            this.NazwaWydarzenia_tytul.Size = new System.Drawing.Size(335, 30);
            this.NazwaWydarzenia_tytul.TabIndex = 1;
            this.NazwaWydarzenia_tytul.Text = "Nazwa wydarzenia";
            this.NazwaWydarzenia_tytul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Data_tytul
            // 
            this.Data_tytul.AutoSize = true;
            this.Data_tytul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Data_tytul.Location = new System.Drawing.Point(9, 0);
            this.Data_tytul.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.Data_tytul.Name = "Data_tytul";
            this.Data_tytul.Size = new System.Drawing.Size(335, 30);
            this.Data_tytul.TabIndex = 2;
            this.Data_tytul.Text = "Data";
            this.Data_tytul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NazwaWydarzenia
            // 
            this.NazwaWydarzenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwaWydarzenia.Location = new System.Drawing.Point(9, 141);
            this.NazwaWydarzenia.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.NazwaWydarzenia.Name = "NazwaWydarzenia";
            this.NazwaWydarzenia.Size = new System.Drawing.Size(335, 20);
            this.NazwaWydarzenia.TabIndex = 3;
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.Data_dzien);
            this.data_panel.Controls.Add(this.Data_miesiac);
            this.data_panel.Controls.Add(this.Data_rok);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(9, 33);
            this.data_panel.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(335, 42);
            this.data_panel.TabIndex = 4;
            // 
            // Data_dzien
            // 
            this.Data_dzien.Location = new System.Drawing.Point(3, 3);
            this.Data_dzien.Name = "Data_dzien";
            this.Data_dzien.Size = new System.Drawing.Size(39, 20);
            this.Data_dzien.TabIndex = 0;
            this.Data_dzien.Text = "Dzień";
            // 
            // Data_miesiac
            // 
            this.Data_miesiac.FormattingEnabled = true;
            this.Data_miesiac.Items.AddRange(new object[] {
            "styczeń",
            "luty",
            "marzec",
            "kwiecień",
            "maj",
            "czerwiec",
            "lipiec",
            "sierpień",
            "wrzesień",
            "październik",
            "listopad",
            "grudzień"});
            this.Data_miesiac.Location = new System.Drawing.Point(48, 3);
            this.Data_miesiac.Name = "Data_miesiac";
            this.Data_miesiac.Size = new System.Drawing.Size(121, 21);
            this.Data_miesiac.TabIndex = 1;
            // 
            // Data_rok
            // 
            this.Data_rok.Location = new System.Drawing.Point(175, 3);
            this.Data_rok.Name = "Data_rok";
            this.Data_rok.Size = new System.Drawing.Size(100, 20);
            this.Data_rok.TabIndex = 2;
            this.Data_rok.Text = "Rok";
            // 
            // CzyWazneWydarzenie
            // 
            this.CzyWazneWydarzenie.AutoSize = true;
            this.CzyWazneWydarzenie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CzyWazneWydarzenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CzyWazneWydarzenie.Location = new System.Drawing.Point(9, 81);
            this.CzyWazneWydarzenie.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.CzyWazneWydarzenie.Name = "CzyWazneWydarzenie";
            this.CzyWazneWydarzenie.Size = new System.Drawing.Size(335, 24);
            this.CzyWazneWydarzenie.TabIndex = 5;
            this.CzyWazneWydarzenie.Text = "Ważne wydarzenie";
            this.CzyWazneWydarzenie.UseVisualStyleBackColor = true;
            // 
            // OknoNoweWydarzenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 219);
            this.Controls.Add(this.ukladGlowny);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OknoNoweWydarzenie";
            this.Text = "Nowe Wydarzenie";
            this.ukladGlowny.ResumeLayout(false);
            this.ukladGlowny.PerformLayout();
            this.ukladPrzyciskow.ResumeLayout(false);
            this.data_panel.ResumeLayout(false);
            this.data_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ukladGlowny;
        private System.Windows.Forms.FlowLayoutPanel ukladPrzyciskow;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Label NazwaWydarzenia_tytul;
        private System.Windows.Forms.Label Data_tytul;
        private System.Windows.Forms.TextBox NazwaWydarzenia;
        private System.Windows.Forms.FlowLayoutPanel data_panel;
        private System.Windows.Forms.TextBox Data_dzien;
        private System.Windows.Forms.ComboBox Data_miesiac;
        private System.Windows.Forms.TextBox Data_rok;
        private System.Windows.Forms.CheckBox CzyWazneWydarzenie;
    }
}