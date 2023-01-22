namespace CalendarEX
{
    partial class OknoMiesiac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoMiesiac));
            this.OknoMiesiac_Podzial = new System.Windows.Forms.SplitContainer();
            this.PodzialTytul = new System.Windows.Forms.TableLayoutPanel();
            this.PodzialTytul_tekst = new System.Windows.Forms.Label();
            this.PodzialTygodni = new System.Windows.Forms.TableLayoutPanel();
            this.PodzialTygodni_NazwyDni = new System.Windows.Forms.TableLayoutPanel();
            this.NazwyDni_poniedziałek = new System.Windows.Forms.Label();
            this.NazwyDni_wtorek = new System.Windows.Forms.Label();
            this.NazwyDni_sroda = new System.Windows.Forms.Label();
            this.NazwyDni_czwartek = new System.Windows.Forms.Label();
            this.NazwyDni_piatek = new System.Windows.Forms.Label();
            this.NazwyDni_sobota = new System.Windows.Forms.Label();
            this.NazwyDni_niedziela = new System.Windows.Forms.Label();
            this.PodzialTygodni_kontrolkiDni = new System.Windows.Forms.FlowLayoutPanel();
            this.PodzialTytul_obraz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OknoMiesiac_Podzial)).BeginInit();
            this.OknoMiesiac_Podzial.Panel1.SuspendLayout();
            this.OknoMiesiac_Podzial.Panel2.SuspendLayout();
            this.OknoMiesiac_Podzial.SuspendLayout();
            this.PodzialTytul.SuspendLayout();
            this.PodzialTygodni.SuspendLayout();
            this.PodzialTygodni_NazwyDni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PodzialTytul_obraz)).BeginInit();
            this.SuspendLayout();
            // 
            // OknoMiesiac_Podzial
            // 
            this.OknoMiesiac_Podzial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OknoMiesiac_Podzial.Location = new System.Drawing.Point(0, 0);
            this.OknoMiesiac_Podzial.Name = "OknoMiesiac_Podzial";
            this.OknoMiesiac_Podzial.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // OknoMiesiac_Podzial.Panel1
            // 
            this.OknoMiesiac_Podzial.Panel1.Controls.Add(this.PodzialTytul);
            // 
            // OknoMiesiac_Podzial.Panel2
            // 
            this.OknoMiesiac_Podzial.Panel2.Controls.Add(this.PodzialTygodni);
            this.OknoMiesiac_Podzial.Size = new System.Drawing.Size(1137, 741);
            this.OknoMiesiac_Podzial.SplitterDistance = 44;
            this.OknoMiesiac_Podzial.TabIndex = 0;
            // 
            // PodzialTytul
            // 
            this.PodzialTytul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.PodzialTytul.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.PodzialTytul.ColumnCount = 4;
            this.PodzialTytul.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PodzialTytul.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PodzialTytul.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PodzialTytul.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PodzialTytul.Controls.Add(this.PodzialTytul_tekst, 1, 0);
            this.PodzialTytul.Controls.Add(this.PodzialTytul_obraz, 2, 0);
            this.PodzialTytul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PodzialTytul.Location = new System.Drawing.Point(0, 0);
            this.PodzialTytul.Name = "PodzialTytul";
            this.PodzialTytul.RowCount = 1;
            this.PodzialTytul.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PodzialTytul.Size = new System.Drawing.Size(1137, 44);
            this.PodzialTytul.TabIndex = 0;
            // 
            // PodzialTytul_tekst
            // 
            this.PodzialTytul_tekst.AutoSize = true;
            this.PodzialTytul_tekst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PodzialTytul_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PodzialTytul_tekst.Location = new System.Drawing.Point(457, 3);
            this.PodzialTytul_tekst.Name = "PodzialTytul_tekst";
            this.PodzialTytul_tekst.Size = new System.Drawing.Size(162, 38);
            this.PodzialTytul_tekst.TabIndex = 0;
            this.PodzialTytul_tekst.Text = "MIESIĄC";
            this.PodzialTytul_tekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PodzialTygodni
            // 
            this.PodzialTygodni.ColumnCount = 1;
            this.PodzialTygodni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PodzialTygodni.Controls.Add(this.PodzialTygodni_NazwyDni, 0, 0);
            this.PodzialTygodni.Controls.Add(this.PodzialTygodni_kontrolkiDni, 0, 1);
            this.PodzialTygodni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PodzialTygodni.Location = new System.Drawing.Point(0, 0);
            this.PodzialTygodni.Name = "PodzialTygodni";
            this.PodzialTygodni.RowCount = 2;
            this.PodzialTygodni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.PodzialTygodni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.PodzialTygodni.Size = new System.Drawing.Size(1137, 693);
            this.PodzialTygodni.TabIndex = 0;
            // 
            // PodzialTygodni_NazwyDni
            // 
            this.PodzialTygodni_NazwyDni.ColumnCount = 7;
            this.PodzialTygodni_NazwyDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PodzialTygodni_NazwyDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PodzialTygodni_NazwyDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PodzialTygodni_NazwyDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PodzialTygodni_NazwyDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PodzialTygodni_NazwyDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PodzialTygodni_NazwyDni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.PodzialTygodni_NazwyDni.Controls.Add(this.NazwyDni_poniedziałek, 0, 0);
            this.PodzialTygodni_NazwyDni.Controls.Add(this.NazwyDni_wtorek, 1, 0);
            this.PodzialTygodni_NazwyDni.Controls.Add(this.NazwyDni_sroda, 2, 0);
            this.PodzialTygodni_NazwyDni.Controls.Add(this.NazwyDni_czwartek, 3, 0);
            this.PodzialTygodni_NazwyDni.Controls.Add(this.NazwyDni_piatek, 4, 0);
            this.PodzialTygodni_NazwyDni.Controls.Add(this.NazwyDni_sobota, 5, 0);
            this.PodzialTygodni_NazwyDni.Controls.Add(this.NazwyDni_niedziela, 6, 0);
            this.PodzialTygodni_NazwyDni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PodzialTygodni_NazwyDni.Location = new System.Drawing.Point(3, 3);
            this.PodzialTygodni_NazwyDni.Name = "PodzialTygodni_NazwyDni";
            this.PodzialTygodni_NazwyDni.RowCount = 1;
            this.PodzialTygodni_NazwyDni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PodzialTygodni_NazwyDni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.PodzialTygodni_NazwyDni.Size = new System.Drawing.Size(1131, 28);
            this.PodzialTygodni_NazwyDni.TabIndex = 0;
            // 
            // NazwyDni_poniedziałek
            // 
            this.NazwyDni_poniedziałek.AutoSize = true;
            this.NazwyDni_poniedziałek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.NazwyDni_poniedziałek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NazwyDni_poniedziałek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwyDni_poniedziałek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwyDni_poniedziałek.Location = new System.Drawing.Point(3, 0);
            this.NazwyDni_poniedziałek.Name = "NazwyDni_poniedziałek";
            this.NazwyDni_poniedziałek.Size = new System.Drawing.Size(155, 28);
            this.NazwyDni_poniedziałek.TabIndex = 0;
            this.NazwyDni_poniedziałek.Text = "PONIEDZIAŁEK";
            this.NazwyDni_poniedziałek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwyDni_wtorek
            // 
            this.NazwyDni_wtorek.AutoSize = true;
            this.NazwyDni_wtorek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.NazwyDni_wtorek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NazwyDni_wtorek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwyDni_wtorek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwyDni_wtorek.Location = new System.Drawing.Point(164, 0);
            this.NazwyDni_wtorek.Name = "NazwyDni_wtorek";
            this.NazwyDni_wtorek.Size = new System.Drawing.Size(155, 28);
            this.NazwyDni_wtorek.TabIndex = 1;
            this.NazwyDni_wtorek.Text = "WTOREK";
            this.NazwyDni_wtorek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwyDni_sroda
            // 
            this.NazwyDni_sroda.AutoSize = true;
            this.NazwyDni_sroda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.NazwyDni_sroda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NazwyDni_sroda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwyDni_sroda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwyDni_sroda.Location = new System.Drawing.Point(325, 0);
            this.NazwyDni_sroda.Name = "NazwyDni_sroda";
            this.NazwyDni_sroda.Size = new System.Drawing.Size(155, 28);
            this.NazwyDni_sroda.TabIndex = 2;
            this.NazwyDni_sroda.Text = "ŚRODA";
            this.NazwyDni_sroda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwyDni_czwartek
            // 
            this.NazwyDni_czwartek.AutoSize = true;
            this.NazwyDni_czwartek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.NazwyDni_czwartek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NazwyDni_czwartek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwyDni_czwartek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwyDni_czwartek.Location = new System.Drawing.Point(486, 0);
            this.NazwyDni_czwartek.Name = "NazwyDni_czwartek";
            this.NazwyDni_czwartek.Size = new System.Drawing.Size(155, 28);
            this.NazwyDni_czwartek.TabIndex = 3;
            this.NazwyDni_czwartek.Text = "CZWARTEK";
            this.NazwyDni_czwartek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwyDni_piatek
            // 
            this.NazwyDni_piatek.AutoSize = true;
            this.NazwyDni_piatek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.NazwyDni_piatek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NazwyDni_piatek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwyDni_piatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwyDni_piatek.Location = new System.Drawing.Point(647, 0);
            this.NazwyDni_piatek.Name = "NazwyDni_piatek";
            this.NazwyDni_piatek.Size = new System.Drawing.Size(155, 28);
            this.NazwyDni_piatek.TabIndex = 4;
            this.NazwyDni_piatek.Text = "PIĄTEK";
            this.NazwyDni_piatek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwyDni_sobota
            // 
            this.NazwyDni_sobota.AutoSize = true;
            this.NazwyDni_sobota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.NazwyDni_sobota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NazwyDni_sobota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwyDni_sobota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwyDni_sobota.Location = new System.Drawing.Point(808, 0);
            this.NazwyDni_sobota.Name = "NazwyDni_sobota";
            this.NazwyDni_sobota.Size = new System.Drawing.Size(155, 28);
            this.NazwyDni_sobota.TabIndex = 5;
            this.NazwyDni_sobota.Text = "SOBOTA";
            this.NazwyDni_sobota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NazwyDni_niedziela
            // 
            this.NazwyDni_niedziela.AutoSize = true;
            this.NazwyDni_niedziela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(231)))), ((int)(((byte)(151)))));
            this.NazwyDni_niedziela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NazwyDni_niedziela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NazwyDni_niedziela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwyDni_niedziela.Location = new System.Drawing.Point(969, 0);
            this.NazwyDni_niedziela.Name = "NazwyDni_niedziela";
            this.NazwyDni_niedziela.Size = new System.Drawing.Size(159, 28);
            this.NazwyDni_niedziela.TabIndex = 6;
            this.NazwyDni_niedziela.Text = "NIEDZIELA";
            this.NazwyDni_niedziela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PodzialTygodni_kontrolkiDni
            // 
            this.PodzialTygodni_kontrolkiDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(224)))), ((int)(((byte)(184)))));
            this.PodzialTygodni_kontrolkiDni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PodzialTygodni_kontrolkiDni.Location = new System.Drawing.Point(3, 37);
            this.PodzialTygodni_kontrolkiDni.Name = "PodzialTygodni_kontrolkiDni";
            this.PodzialTygodni_kontrolkiDni.Size = new System.Drawing.Size(1131, 653);
            this.PodzialTygodni_kontrolkiDni.TabIndex = 1;
            // 
            // PodzialTytul_obraz
            // 
            this.PodzialTytul_obraz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PodzialTytul_obraz.Image = global::CalendarEX.img.styczen;
            this.PodzialTytul_obraz.InitialImage = global::CalendarEX.img.styczen;
            this.PodzialTytul_obraz.Location = new System.Drawing.Point(628, 6);
            this.PodzialTytul_obraz.Name = "PodzialTytul_obraz";
            this.PodzialTytul_obraz.Size = new System.Drawing.Size(50, 32);
            this.PodzialTytul_obraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PodzialTytul_obraz.TabIndex = 1;
            this.PodzialTytul_obraz.TabStop = false;
            // 
            // OknoMiesiac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 741);
            this.Controls.Add(this.OknoMiesiac_Podzial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OknoMiesiac";
            this.Text = "Miesiąc";
            this.Load += new System.EventHandler(this.OknoMiesiac_Load);
            this.Resize += new System.EventHandler(this.OknoMiesiac_Resize);
            this.OknoMiesiac_Podzial.Panel1.ResumeLayout(false);
            this.OknoMiesiac_Podzial.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OknoMiesiac_Podzial)).EndInit();
            this.OknoMiesiac_Podzial.ResumeLayout(false);
            this.PodzialTytul.ResumeLayout(false);
            this.PodzialTytul.PerformLayout();
            this.PodzialTygodni.ResumeLayout(false);
            this.PodzialTygodni_NazwyDni.ResumeLayout(false);
            this.PodzialTygodni_NazwyDni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PodzialTytul_obraz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer OknoMiesiac_Podzial;
        private System.Windows.Forms.TableLayoutPanel PodzialTygodni;
        private System.Windows.Forms.TableLayoutPanel PodzialTygodni_NazwyDni;
        private System.Windows.Forms.Label NazwyDni_poniedziałek;
        private System.Windows.Forms.Label NazwyDni_wtorek;
        private System.Windows.Forms.Label NazwyDni_sroda;
        private System.Windows.Forms.Label NazwyDni_czwartek;
        private System.Windows.Forms.Label NazwyDni_piatek;
        private System.Windows.Forms.Label NazwyDni_sobota;
        private System.Windows.Forms.Label NazwyDni_niedziela;
        private System.Windows.Forms.FlowLayoutPanel PodzialTygodni_kontrolkiDni;
        private System.Windows.Forms.TableLayoutPanel PodzialTytul;
        private System.Windows.Forms.Label PodzialTytul_tekst;
        private System.Windows.Forms.PictureBox PodzialTytul_obraz;
    }
}