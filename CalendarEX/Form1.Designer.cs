namespace CalendarEX
{
    partial class GlowneOkno
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.GlowneOkno_podzial = new System.Windows.Forms.SplitContainer();
            this.PanelRoku = new System.Windows.Forms.TableLayoutPanel();
            this.PanelRoku_rok = new System.Windows.Forms.Label();
            this.PanelRoku_rokDoPrzodu = new System.Windows.Forms.Button();
            this.PanelRoku_rokWstecz = new System.Windows.Forms.Button();
            this.PanelGlowny = new System.Windows.Forms.TableLayoutPanel();
            this.PanelGlowny_Daty = new System.Windows.Forms.TableLayoutPanel();
            this.Daty_Nadchodzace = new System.Windows.Forms.TableLayoutPanel();
            this.Daty_Najwazniejsze = new System.Windows.Forms.TableLayoutPanel();
            this.Daty_Notatki = new System.Windows.Forms.TableLayoutPanel();
            this.PanelGlowny_Miesiace = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Styczen = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Lipiec = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Luty = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Sierpien = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Marzec = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Wrzesien = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Kwiecien = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Pazdziernik = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Maj = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Listopad = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Czerwiec = new System.Windows.Forms.TableLayoutPanel();
            this.Miesiace_Grudzien = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.GlowneOkno_podzial)).BeginInit();
            this.GlowneOkno_podzial.Panel1.SuspendLayout();
            this.GlowneOkno_podzial.Panel2.SuspendLayout();
            this.GlowneOkno_podzial.SuspendLayout();
            this.PanelRoku.SuspendLayout();
            this.PanelGlowny.SuspendLayout();
            this.PanelGlowny_Daty.SuspendLayout();
            this.PanelGlowny_Miesiace.SuspendLayout();
            this.SuspendLayout();
            // 
            // GlowneOkno_podzial
            // 
            this.GlowneOkno_podzial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlowneOkno_podzial.Location = new System.Drawing.Point(0, 0);
            this.GlowneOkno_podzial.Name = "GlowneOkno_podzial";
            this.GlowneOkno_podzial.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // GlowneOkno_podzial.Panel1
            // 
            this.GlowneOkno_podzial.Panel1.Controls.Add(this.PanelRoku);
            this.GlowneOkno_podzial.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // GlowneOkno_podzial.Panel2
            // 
            this.GlowneOkno_podzial.Panel2.Controls.Add(this.PanelGlowny);
            this.GlowneOkno_podzial.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.GlowneOkno_podzial.Size = new System.Drawing.Size(1160, 813);
            this.GlowneOkno_podzial.SplitterDistance = 53;
            this.GlowneOkno_podzial.TabIndex = 0;
            // 
            // PanelRoku
            // 
            this.PanelRoku.ColumnCount = 3;
            this.PanelRoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelRoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.PanelRoku.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelRoku.Controls.Add(this.PanelRoku_rok, 1, 0);
            this.PanelRoku.Controls.Add(this.PanelRoku_rokDoPrzodu, 2, 0);
            this.PanelRoku.Controls.Add(this.PanelRoku_rokWstecz, 0, 0);
            this.PanelRoku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoku.Location = new System.Drawing.Point(0, 0);
            this.PanelRoku.Name = "PanelRoku";
            this.PanelRoku.RowCount = 1;
            this.PanelRoku.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelRoku.Size = new System.Drawing.Size(1160, 53);
            this.PanelRoku.TabIndex = 0;
            // 
            // PanelRoku_rok
            // 
            this.PanelRoku_rok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRoku_rok.AutoSize = true;
            this.PanelRoku_rok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PanelRoku_rok.Location = new System.Drawing.Point(177, 0);
            this.PanelRoku_rok.Name = "PanelRoku_rok";
            this.PanelRoku_rok.Size = new System.Drawing.Size(806, 53);
            this.PanelRoku_rok.TabIndex = 0;
            this.PanelRoku_rok.Text = "2022";
            this.PanelRoku_rok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRoku_rokDoPrzodu
            // 
            this.PanelRoku_rokDoPrzodu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRoku_rokDoPrzodu.Location = new System.Drawing.Point(989, 3);
            this.PanelRoku_rokDoPrzodu.Name = "PanelRoku_rokDoPrzodu";
            this.PanelRoku_rokDoPrzodu.Size = new System.Drawing.Size(168, 47);
            this.PanelRoku_rokDoPrzodu.TabIndex = 2;
            this.PanelRoku_rokDoPrzodu.Text = "NASTĘPNY";
            this.PanelRoku_rokDoPrzodu.UseVisualStyleBackColor = true;
            // 
            // PanelRoku_rokWstecz
            // 
            this.PanelRoku_rokWstecz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRoku_rokWstecz.Location = new System.Drawing.Point(3, 3);
            this.PanelRoku_rokWstecz.Name = "PanelRoku_rokWstecz";
            this.PanelRoku_rokWstecz.Size = new System.Drawing.Size(168, 47);
            this.PanelRoku_rokWstecz.TabIndex = 1;
            this.PanelRoku_rokWstecz.Text = "POPRZEDNI";
            this.PanelRoku_rokWstecz.UseVisualStyleBackColor = true;
            this.PanelRoku_rokWstecz.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelGlowny
            // 
            this.PanelGlowny.ColumnCount = 2;
            this.PanelGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PanelGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PanelGlowny.Controls.Add(this.PanelGlowny_Daty, 0, 0);
            this.PanelGlowny.Controls.Add(this.PanelGlowny_Miesiace, 1, 0);
            this.PanelGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGlowny.Location = new System.Drawing.Point(0, 0);
            this.PanelGlowny.Name = "PanelGlowny";
            this.PanelGlowny.RowCount = 1;
            this.PanelGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelGlowny.Size = new System.Drawing.Size(1160, 756);
            this.PanelGlowny.TabIndex = 0;
            // 
            // PanelGlowny_Daty
            // 
            this.PanelGlowny_Daty.ColumnCount = 1;
            this.PanelGlowny_Daty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelGlowny_Daty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelGlowny_Daty.Controls.Add(this.Daty_Nadchodzace, 0, 0);
            this.PanelGlowny_Daty.Controls.Add(this.Daty_Najwazniejsze, 0, 1);
            this.PanelGlowny_Daty.Controls.Add(this.Daty_Notatki, 0, 2);
            this.PanelGlowny_Daty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGlowny_Daty.Location = new System.Drawing.Point(3, 3);
            this.PanelGlowny_Daty.Name = "PanelGlowny_Daty";
            this.PanelGlowny_Daty.RowCount = 3;
            this.PanelGlowny_Daty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.PanelGlowny_Daty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.PanelGlowny_Daty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.PanelGlowny_Daty.Size = new System.Drawing.Size(168, 750);
            this.PanelGlowny_Daty.TabIndex = 0;
            // 
            // Daty_Nadchodzace
            // 
            this.Daty_Nadchodzace.ColumnCount = 1;
            this.Daty_Nadchodzace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Daty_Nadchodzace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Daty_Nadchodzace.Location = new System.Drawing.Point(3, 3);
            this.Daty_Nadchodzace.Name = "Daty_Nadchodzace";
            this.Daty_Nadchodzace.RowCount = 2;
            this.Daty_Nadchodzace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Daty_Nadchodzace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Daty_Nadchodzace.Size = new System.Drawing.Size(162, 256);
            this.Daty_Nadchodzace.TabIndex = 0;
            // 
            // Daty_Najwazniejsze
            // 
            this.Daty_Najwazniejsze.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Daty_Najwazniejsze.ColumnCount = 1;
            this.Daty_Najwazniejsze.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Daty_Najwazniejsze.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Daty_Najwazniejsze.Location = new System.Drawing.Point(3, 265);
            this.Daty_Najwazniejsze.Name = "Daty_Najwazniejsze";
            this.Daty_Najwazniejsze.RowCount = 2;
            this.Daty_Najwazniejsze.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Daty_Najwazniejsze.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Daty_Najwazniejsze.Size = new System.Drawing.Size(162, 256);
            this.Daty_Najwazniejsze.TabIndex = 1;
            // 
            // Daty_Notatki
            // 
            this.Daty_Notatki.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Daty_Notatki.ColumnCount = 1;
            this.Daty_Notatki.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Daty_Notatki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Daty_Notatki.Location = new System.Drawing.Point(3, 527);
            this.Daty_Notatki.Name = "Daty_Notatki";
            this.Daty_Notatki.RowCount = 2;
            this.Daty_Notatki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Daty_Notatki.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Daty_Notatki.Size = new System.Drawing.Size(162, 220);
            this.Daty_Notatki.TabIndex = 2;
            // 
            // PanelGlowny_Miesiace
            // 
            this.PanelGlowny_Miesiace.ColumnCount = 6;
            this.PanelGlowny_Miesiace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelGlowny_Miesiace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelGlowny_Miesiace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelGlowny_Miesiace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelGlowny_Miesiace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelGlowny_Miesiace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Styczen, 0, 0);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Lipiec, 0, 1);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Luty, 1, 0);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Sierpien, 1, 1);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Marzec, 2, 0);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Wrzesien, 2, 1);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Kwiecien, 3, 0);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Pazdziernik, 3, 1);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Maj, 4, 0);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Listopad, 4, 1);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Czerwiec, 5, 0);
            this.PanelGlowny_Miesiace.Controls.Add(this.Miesiace_Grudzien, 5, 1);
            this.PanelGlowny_Miesiace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGlowny_Miesiace.Location = new System.Drawing.Point(177, 3);
            this.PanelGlowny_Miesiace.Name = "PanelGlowny_Miesiace";
            this.PanelGlowny_Miesiace.RowCount = 2;
            this.PanelGlowny_Miesiace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelGlowny_Miesiace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelGlowny_Miesiace.Size = new System.Drawing.Size(980, 750);
            this.PanelGlowny_Miesiace.TabIndex = 1;
            // 
            // Miesiace_Styczen
            // 
            this.Miesiace_Styczen.ColumnCount = 1;
            this.Miesiace_Styczen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Styczen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Styczen.Location = new System.Drawing.Point(3, 3);
            this.Miesiace_Styczen.Name = "Miesiace_Styczen";
            this.Miesiace_Styczen.RowCount = 2;
            this.Miesiace_Styczen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Styczen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Styczen.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Styczen.TabIndex = 0;
            // 
            // Miesiace_Lipiec
            // 
            this.Miesiace_Lipiec.ColumnCount = 1;
            this.Miesiace_Lipiec.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Lipiec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Lipiec.Location = new System.Drawing.Point(3, 378);
            this.Miesiace_Lipiec.Name = "Miesiace_Lipiec";
            this.Miesiace_Lipiec.RowCount = 2;
            this.Miesiace_Lipiec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Lipiec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Lipiec.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Lipiec.TabIndex = 1;
            // 
            // Miesiace_Luty
            // 
            this.Miesiace_Luty.ColumnCount = 1;
            this.Miesiace_Luty.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Luty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Luty.Location = new System.Drawing.Point(166, 3);
            this.Miesiace_Luty.Name = "Miesiace_Luty";
            this.Miesiace_Luty.RowCount = 2;
            this.Miesiace_Luty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Luty.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Luty.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Luty.TabIndex = 2;
            // 
            // Miesiace_Sierpien
            // 
            this.Miesiace_Sierpien.ColumnCount = 1;
            this.Miesiace_Sierpien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Sierpien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Sierpien.Location = new System.Drawing.Point(166, 378);
            this.Miesiace_Sierpien.Name = "Miesiace_Sierpien";
            this.Miesiace_Sierpien.RowCount = 2;
            this.Miesiace_Sierpien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Sierpien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Sierpien.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Sierpien.TabIndex = 3;
            // 
            // Miesiace_Marzec
            // 
            this.Miesiace_Marzec.ColumnCount = 1;
            this.Miesiace_Marzec.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Marzec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Marzec.Location = new System.Drawing.Point(329, 3);
            this.Miesiace_Marzec.Name = "Miesiace_Marzec";
            this.Miesiace_Marzec.RowCount = 2;
            this.Miesiace_Marzec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Marzec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Marzec.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Marzec.TabIndex = 4;
            // 
            // Miesiace_Wrzesien
            // 
            this.Miesiace_Wrzesien.ColumnCount = 1;
            this.Miesiace_Wrzesien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Wrzesien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Wrzesien.Location = new System.Drawing.Point(329, 378);
            this.Miesiace_Wrzesien.Name = "Miesiace_Wrzesien";
            this.Miesiace_Wrzesien.RowCount = 2;
            this.Miesiace_Wrzesien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Wrzesien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Wrzesien.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Wrzesien.TabIndex = 5;
            // 
            // Miesiace_Kwiecien
            // 
            this.Miesiace_Kwiecien.ColumnCount = 1;
            this.Miesiace_Kwiecien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Kwiecien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Kwiecien.Location = new System.Drawing.Point(492, 3);
            this.Miesiace_Kwiecien.Name = "Miesiace_Kwiecien";
            this.Miesiace_Kwiecien.RowCount = 2;
            this.Miesiace_Kwiecien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Kwiecien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Kwiecien.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Kwiecien.TabIndex = 6;
            // 
            // Miesiace_Pazdziernik
            // 
            this.Miesiace_Pazdziernik.ColumnCount = 1;
            this.Miesiace_Pazdziernik.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Pazdziernik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Pazdziernik.Location = new System.Drawing.Point(492, 378);
            this.Miesiace_Pazdziernik.Name = "Miesiace_Pazdziernik";
            this.Miesiace_Pazdziernik.RowCount = 2;
            this.Miesiace_Pazdziernik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Pazdziernik.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Pazdziernik.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Pazdziernik.TabIndex = 7;
            // 
            // Miesiace_Maj
            // 
            this.Miesiace_Maj.ColumnCount = 1;
            this.Miesiace_Maj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Maj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Maj.Location = new System.Drawing.Point(655, 3);
            this.Miesiace_Maj.Name = "Miesiace_Maj";
            this.Miesiace_Maj.RowCount = 2;
            this.Miesiace_Maj.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Maj.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Maj.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Maj.TabIndex = 8;
            // 
            // Miesiace_Listopad
            // 
            this.Miesiace_Listopad.ColumnCount = 1;
            this.Miesiace_Listopad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Listopad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Listopad.Location = new System.Drawing.Point(655, 378);
            this.Miesiace_Listopad.Name = "Miesiace_Listopad";
            this.Miesiace_Listopad.RowCount = 2;
            this.Miesiace_Listopad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Listopad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Listopad.Size = new System.Drawing.Size(157, 369);
            this.Miesiace_Listopad.TabIndex = 9;
            // 
            // Miesiace_Czerwiec
            // 
            this.Miesiace_Czerwiec.ColumnCount = 1;
            this.Miesiace_Czerwiec.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Czerwiec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Czerwiec.Location = new System.Drawing.Point(818, 3);
            this.Miesiace_Czerwiec.Name = "Miesiace_Czerwiec";
            this.Miesiace_Czerwiec.RowCount = 2;
            this.Miesiace_Czerwiec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Czerwiec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Czerwiec.Size = new System.Drawing.Size(159, 369);
            this.Miesiace_Czerwiec.TabIndex = 10;
            // 
            // Miesiace_Grudzien
            // 
            this.Miesiace_Grudzien.ColumnCount = 1;
            this.Miesiace_Grudzien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Miesiace_Grudzien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Miesiace_Grudzien.Location = new System.Drawing.Point(818, 378);
            this.Miesiace_Grudzien.Name = "Miesiace_Grudzien";
            this.Miesiace_Grudzien.RowCount = 2;
            this.Miesiace_Grudzien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Miesiace_Grudzien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.Miesiace_Grudzien.Size = new System.Drawing.Size(159, 369);
            this.Miesiace_Grudzien.TabIndex = 11;
            // 
            // GlowneOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 813);
            this.Controls.Add(this.GlowneOkno_podzial);
            this.Name = "GlowneOkno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalendarEX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GlowneOkno_podzial.Panel1.ResumeLayout(false);
            this.GlowneOkno_podzial.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GlowneOkno_podzial)).EndInit();
            this.GlowneOkno_podzial.ResumeLayout(false);
            this.PanelRoku.ResumeLayout(false);
            this.PanelRoku.PerformLayout();
            this.PanelGlowny.ResumeLayout(false);
            this.PanelGlowny_Daty.ResumeLayout(false);
            this.PanelGlowny_Miesiace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer GlowneOkno_podzial;
        private System.Windows.Forms.TableLayoutPanel PanelRoku;
        private System.Windows.Forms.Label PanelRoku_rok;
        private System.Windows.Forms.Button PanelRoku_rokDoPrzodu;
        private System.Windows.Forms.Button PanelRoku_rokWstecz;
        private System.Windows.Forms.TableLayoutPanel PanelGlowny;
        private System.Windows.Forms.TableLayoutPanel PanelGlowny_Daty;
        private System.Windows.Forms.TableLayoutPanel PanelGlowny_Miesiace;
        private System.Windows.Forms.TableLayoutPanel Daty_Najwazniejsze;
        private System.Windows.Forms.TableLayoutPanel Daty_Notatki;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Styczen;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Lipiec;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Luty;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Sierpien;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Marzec;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Wrzesien;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Kwiecien;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Pazdziernik;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Maj;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Listopad;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Czerwiec;
        private System.Windows.Forms.TableLayoutPanel Miesiace_Grudzien;
        private System.Windows.Forms.TableLayoutPanel Daty_Nadchodzace;
    }
}

