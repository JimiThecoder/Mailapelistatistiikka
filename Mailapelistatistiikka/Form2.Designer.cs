namespace Mailapelistatistiikka
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOtteluidenMaara = new System.Windows.Forms.Label();
            this.lblVoittoprosentti = new System.Windows.Forms.Label();
            this.lstOttelut = new System.Windows.Forms.ListBox();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnTakaisin = new System.Windows.Forms.Button();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.btnPoistaValittu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelitilastot";
            // 
            // lblOtteluidenMaara
            // 
            this.lblOtteluidenMaara.AutoSize = true;
            this.lblOtteluidenMaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblOtteluidenMaara.Location = new System.Drawing.Point(346, 69);
            this.lblOtteluidenMaara.Name = "lblOtteluidenMaara";
            this.lblOtteluidenMaara.Size = new System.Drawing.Size(109, 18);
            this.lblOtteluidenMaara.TabIndex = 1;
            this.lblOtteluidenMaara.Text = "Otteluita pelattu";
            // 
            // lblVoittoprosentti
            // 
            this.lblVoittoprosentti.AutoSize = true;
            this.lblVoittoprosentti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblVoittoprosentti.Location = new System.Drawing.Point(346, 110);
            this.lblVoittoprosentti.Name = "lblVoittoprosentti";
            this.lblVoittoprosentti.Size = new System.Drawing.Size(68, 18);
            this.lblVoittoprosentti.TabIndex = 2;
            this.lblVoittoprosentti.Text = "Voitto- %";
            // 
            // lstOttelut
            // 
            this.lstOttelut.FormattingEnabled = true;
            this.lstOttelut.Location = new System.Drawing.Point(175, 153);
            this.lstOttelut.Name = "lstOttelut";
            this.lstOttelut.Size = new System.Drawing.Size(450, 173);
            this.lstOttelut.TabIndex = 3;
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(175, 332);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(110, 32);
            this.btnPaivita.TabIndex = 4;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnTakaisin
            // 
            this.btnTakaisin.Location = new System.Drawing.Point(515, 332);
            this.btnTakaisin.Name = "btnTakaisin";
            this.btnTakaisin.Size = new System.Drawing.Size(110, 32);
            this.btnTakaisin.TabIndex = 5;
            this.btnTakaisin.Text = "Takaisin";
            this.btnTakaisin.UseVisualStyleBackColor = true;
            this.btnTakaisin.Click += new System.EventHandler(this.btnTakaisin_Click);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(515, 370);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(110, 32);
            this.btnTyhjenna.TabIndex = 6;
            this.btnTyhjenna.Text = "Tyhjennä kaikki";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // btnPoistaValittu
            // 
            this.btnPoistaValittu.Location = new System.Drawing.Point(515, 406);
            this.btnPoistaValittu.Name = "btnPoistaValittu";
            this.btnPoistaValittu.Size = new System.Drawing.Size(110, 32);
            this.btnPoistaValittu.TabIndex = 7;
            this.btnPoistaValittu.Text = "Poista valittu";
            this.btnPoistaValittu.UseVisualStyleBackColor = true;
            this.btnPoistaValittu.Click += new System.EventHandler(this.btnPoistaValittu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPoistaValittu);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnTakaisin);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.lstOttelut);
            this.Controls.Add(this.lblVoittoprosentti);
            this.Controls.Add(this.lblOtteluidenMaara);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Mailapelistatistiikka - Tilastot";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOtteluidenMaara;
        private System.Windows.Forms.Label lblVoittoprosentti;
        private System.Windows.Forms.ListBox lstOttelut;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnTakaisin;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.Button btnPoistaValittu;
    }
}