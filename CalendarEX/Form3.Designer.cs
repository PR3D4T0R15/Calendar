namespace CalendarEX
{
    partial class OknoNotatki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoNotatki));
            this.OknoNotatki_Podzial = new System.Windows.Forms.TableLayoutPanel();
            this.Podzial_notatki = new System.Windows.Forms.TextBox();
            this.Podzial_Przyciski = new System.Windows.Forms.FlowLayoutPanel();
            this.Przyciski_zapisz = new System.Windows.Forms.Button();
            this.Przyciski_anuluj = new System.Windows.Forms.Button();
            this.OknoNotatki_Podzial.SuspendLayout();
            this.Podzial_Przyciski.SuspendLayout();
            this.SuspendLayout();
            // 
            // OknoNotatki_Podzial
            // 
            this.OknoNotatki_Podzial.ColumnCount = 1;
            this.OknoNotatki_Podzial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OknoNotatki_Podzial.Controls.Add(this.Podzial_notatki, 0, 0);
            this.OknoNotatki_Podzial.Controls.Add(this.Podzial_Przyciski, 0, 1);
            this.OknoNotatki_Podzial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OknoNotatki_Podzial.Location = new System.Drawing.Point(0, 0);
            this.OknoNotatki_Podzial.Name = "OknoNotatki_Podzial";
            this.OknoNotatki_Podzial.RowCount = 2;
            this.OknoNotatki_Podzial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.OknoNotatki_Podzial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.OknoNotatki_Podzial.Size = new System.Drawing.Size(800, 450);
            this.OknoNotatki_Podzial.TabIndex = 0;
            // 
            // Podzial_notatki
            // 
            this.Podzial_notatki.AcceptsTab = true;
            this.Podzial_notatki.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Podzial_notatki.Location = new System.Drawing.Point(3, 3);
            this.Podzial_notatki.Multiline = true;
            this.Podzial_notatki.Name = "Podzial_notatki";
            this.Podzial_notatki.Size = new System.Drawing.Size(794, 408);
            this.Podzial_notatki.TabIndex = 1;
            // 
            // Podzial_Przyciski
            // 
            this.Podzial_Przyciski.Controls.Add(this.Przyciski_zapisz);
            this.Podzial_Przyciski.Controls.Add(this.Przyciski_anuluj);
            this.Podzial_Przyciski.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Podzial_Przyciski.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Podzial_Przyciski.Location = new System.Drawing.Point(3, 417);
            this.Podzial_Przyciski.Name = "Podzial_Przyciski";
            this.Podzial_Przyciski.Size = new System.Drawing.Size(794, 30);
            this.Podzial_Przyciski.TabIndex = 2;
            // 
            // Przyciski_zapisz
            // 
            this.Przyciski_zapisz.Location = new System.Drawing.Point(716, 3);
            this.Przyciski_zapisz.Name = "Przyciski_zapisz";
            this.Przyciski_zapisz.Size = new System.Drawing.Size(75, 23);
            this.Przyciski_zapisz.TabIndex = 0;
            this.Przyciski_zapisz.Text = "ZAPISZ";
            this.Przyciski_zapisz.UseVisualStyleBackColor = true;
            // 
            // Przyciski_anuluj
            // 
            this.Przyciski_anuluj.Location = new System.Drawing.Point(635, 3);
            this.Przyciski_anuluj.Name = "Przyciski_anuluj";
            this.Przyciski_anuluj.Size = new System.Drawing.Size(75, 23);
            this.Przyciski_anuluj.TabIndex = 1;
            this.Przyciski_anuluj.Text = "ANULUJ";
            this.Przyciski_anuluj.UseVisualStyleBackColor = true;
            // 
            // OknoNotatki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OknoNotatki_Podzial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OknoNotatki";
            this.Text = "Notatki";
            this.OknoNotatki_Podzial.ResumeLayout(false);
            this.OknoNotatki_Podzial.PerformLayout();
            this.Podzial_Przyciski.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OknoNotatki_Podzial;
        private System.Windows.Forms.TextBox Podzial_notatki;
        private System.Windows.Forms.FlowLayoutPanel Podzial_Przyciski;
        private System.Windows.Forms.Button Przyciski_zapisz;
        private System.Windows.Forms.Button Przyciski_anuluj;
    }
}