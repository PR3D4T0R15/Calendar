namespace CalendarEX
{
    partial class PustyDzien
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ikonka_ukladGlowny = new System.Windows.Forms.TableLayoutPanel();
            this.nazwa = new System.Windows.Forms.Label();
            this.ikonka_ukladGlowny.SuspendLayout();
            this.SuspendLayout();
            // 
            // ikonka_ukladGlowny
            // 
            this.ikonka_ukladGlowny.ColumnCount = 1;
            this.ikonka_ukladGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ikonka_ukladGlowny.Controls.Add(this.nazwa, 0, 0);
            this.ikonka_ukladGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ikonka_ukladGlowny.Location = new System.Drawing.Point(0, 0);
            this.ikonka_ukladGlowny.Margin = new System.Windows.Forms.Padding(0);
            this.ikonka_ukladGlowny.Name = "ikonka_ukladGlowny";
            this.ikonka_ukladGlowny.RowCount = 1;
            this.ikonka_ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ikonka_ukladGlowny.Size = new System.Drawing.Size(161, 108);
            this.ikonka_ukladGlowny.TabIndex = 0;
            // 
            // nazwa
            // 
            this.nazwa.AutoSize = true;
            this.nazwa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nazwa.Location = new System.Drawing.Point(0, 0);
            this.nazwa.Margin = new System.Windows.Forms.Padding(0);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(161, 108);
            this.nazwa.TabIndex = 0;
            this.nazwa.Text = "TEST";
            this.nazwa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nazwa.Visible = false;
            // 
            // PustyDzien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ikonka_ukladGlowny);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "PustyDzien";
            this.Size = new System.Drawing.Size(161, 108);
            this.ikonka_ukladGlowny.ResumeLayout(false);
            this.ikonka_ukladGlowny.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ikonka_ukladGlowny;
        private System.Windows.Forms.Label nazwa;
    }
}
