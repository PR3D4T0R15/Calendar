namespace CalendarEX
{
    partial class PelnyDzien
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
            this.ukladGlowny = new System.Windows.Forms.TableLayoutPanel();
            this.ZadaniaDnia = new System.Windows.Forms.FlowLayoutPanel();
            this.NumerDnia = new System.Windows.Forms.Label();
            this.ukladGlowny.SuspendLayout();
            this.SuspendLayout();
            // 
            // ukladGlowny
            // 
            this.ukladGlowny.ColumnCount = 1;
            this.ukladGlowny.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ukladGlowny.Controls.Add(this.NumerDnia, 0, 0);
            this.ukladGlowny.Controls.Add(this.ZadaniaDnia, 0, 1);
            this.ukladGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ukladGlowny.Location = new System.Drawing.Point(0, 0);
            this.ukladGlowny.Margin = new System.Windows.Forms.Padding(0);
            this.ukladGlowny.Name = "ukladGlowny";
            this.ukladGlowny.RowCount = 2;
            this.ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.ukladGlowny.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
            this.ukladGlowny.Size = new System.Drawing.Size(159, 106);
            this.ukladGlowny.TabIndex = 0;
            // 
            // ZadaniaDnia
            // 
            this.ZadaniaDnia.AutoScroll = true;
            this.ZadaniaDnia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.ZadaniaDnia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZadaniaDnia.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ZadaniaDnia.Location = new System.Drawing.Point(0, 36);
            this.ZadaniaDnia.Margin = new System.Windows.Forms.Padding(0);
            this.ZadaniaDnia.Name = "ZadaniaDnia";
            this.ZadaniaDnia.Size = new System.Drawing.Size(159, 70);
            this.ZadaniaDnia.TabIndex = 1;
            // 
            // NumerDnia
            // 
            this.NumerDnia.AutoSize = true;
            this.NumerDnia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.NumerDnia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumerDnia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerDnia.Location = new System.Drawing.Point(0, 0);
            this.NumerDnia.Margin = new System.Windows.Forms.Padding(0);
            this.NumerDnia.Name = "NumerDnia";
            this.NumerDnia.Size = new System.Drawing.Size(159, 36);
            this.NumerDnia.TabIndex = 0;
            this.NumerDnia.Text = "label1";
            this.NumerDnia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NumerDnia.TextChanged += new System.EventHandler(this.NumerDnia_TextChanged);
            this.NumerDnia.Click += new System.EventHandler(this.NumerDnia_Click);
            // 
            // PelnyDzien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ukladGlowny);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "PelnyDzien";
            this.Size = new System.Drawing.Size(159, 106);
            this.ukladGlowny.ResumeLayout(false);
            this.ukladGlowny.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ukladGlowny;
        private System.Windows.Forms.FlowLayoutPanel ZadaniaDnia;
        private System.Windows.Forms.Label NumerDnia;
    }
}
