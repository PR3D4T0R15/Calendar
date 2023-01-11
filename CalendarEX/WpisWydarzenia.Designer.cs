namespace CalendarEX
{
    partial class WpisWydarzenia
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WpisWydarzenia_tekst = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.WpisWydarzenia_tekst, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 17);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WpisWydarzenia_tekst
            // 
            this.WpisWydarzenia_tekst.AutoSize = true;
            this.WpisWydarzenia_tekst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WpisWydarzenia_tekst.Location = new System.Drawing.Point(3, 0);
            this.WpisWydarzenia_tekst.Name = "WpisWydarzenia_tekst";
            this.WpisWydarzenia_tekst.Size = new System.Drawing.Size(142, 17);
            this.WpisWydarzenia_tekst.TabIndex = 0;
            this.WpisWydarzenia_tekst.Text = "TEKST WYDARZENIA";
            this.WpisWydarzenia_tekst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WpisWydarzenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WpisWydarzenia";
            this.Size = new System.Drawing.Size(148, 17);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label WpisWydarzenia_tekst;
    }
}
