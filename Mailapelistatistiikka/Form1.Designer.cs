namespace Mailapelistatistiikka
{
    partial class Form1
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
            this.cmbLaji = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVastustaja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPaivamaara = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOma1 = new System.Windows.Forms.TextBox();
            this.txtOma2 = new System.Windows.Forms.TextBox();
            this.txtOma3 = new System.Windows.Forms.TextBox();
            this.txtVastustaja1 = new System.Windows.Forms.TextBox();
            this.txtVastustaja2 = new System.Windows.Forms.TextBox();
            this.txtVastustaja3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMuistiinpanot = new System.Windows.Forms.TextBox();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.lblViesti = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNaytaTilastot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laji";
            // 
            // cmbLaji
            // 
            this.cmbLaji.FormattingEnabled = true;
            this.cmbLaji.Items.AddRange(new object[] {
            "Sulkapallo",
            "Tennis",
            "Pesäpallo",
            "Padel",
            "Pöytätennis"});
            this.cmbLaji.Location = new System.Drawing.Point(306, 74);
            this.cmbLaji.Name = "cmbLaji";
            this.cmbLaji.Size = new System.Drawing.Size(101, 21);
            this.cmbLaji.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vastustaja";
            // 
            // txtVastustaja
            // 
            this.txtVastustaja.Location = new System.Drawing.Point(306, 101);
            this.txtVastustaja.Name = "txtVastustaja";
            this.txtVastustaja.Size = new System.Drawing.Size(100, 20);
            this.txtVastustaja.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Päivämäärä";
            // 
            // dtpPaivamaara
            // 
            this.dtpPaivamaara.Location = new System.Drawing.Point(306, 48);
            this.dtpPaivamaara.Name = "dtpPaivamaara";
            this.dtpPaivamaara.Size = new System.Drawing.Size(200, 20);
            this.dtpPaivamaara.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "1. erä";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "2. erä";
            // 
            // txtOma1
            // 
            this.txtOma1.Location = new System.Drawing.Point(307, 178);
            this.txtOma1.Name = "txtOma1";
            this.txtOma1.Size = new System.Drawing.Size(100, 20);
            this.txtOma1.TabIndex = 9;
            // 
            // txtOma2
            // 
            this.txtOma2.Location = new System.Drawing.Point(307, 204);
            this.txtOma2.Name = "txtOma2";
            this.txtOma2.Size = new System.Drawing.Size(100, 20);
            this.txtOma2.TabIndex = 10;
            // 
            // txtOma3
            // 
            this.txtOma3.Location = new System.Drawing.Point(307, 230);
            this.txtOma3.Name = "txtOma3";
            this.txtOma3.Size = new System.Drawing.Size(100, 20);
            this.txtOma3.TabIndex = 11;
            // 
            // txtVastustaja1
            // 
            this.txtVastustaja1.Location = new System.Drawing.Point(447, 178);
            this.txtVastustaja1.Name = "txtVastustaja1";
            this.txtVastustaja1.Size = new System.Drawing.Size(100, 20);
            this.txtVastustaja1.TabIndex = 12;
            // 
            // txtVastustaja2
            // 
            this.txtVastustaja2.Location = new System.Drawing.Point(447, 204);
            this.txtVastustaja2.Name = "txtVastustaja2";
            this.txtVastustaja2.Size = new System.Drawing.Size(100, 20);
            this.txtVastustaja2.TabIndex = 13;
            // 
            // txtVastustaja3
            // 
            this.txtVastustaja3.Location = new System.Drawing.Point(447, 233);
            this.txtVastustaja3.Name = "txtVastustaja3";
            this.txtVastustaja3.Size = new System.Drawing.Size(100, 20);
            this.txtVastustaja3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "3. erä";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Muistiinpanot";
            // 
            // txtMuistiinpanot
            // 
            this.txtMuistiinpanot.Location = new System.Drawing.Point(241, 279);
            this.txtMuistiinpanot.Multiline = true;
            this.txtMuistiinpanot.Name = "txtMuistiinpanot";
            this.txtMuistiinpanot.Size = new System.Drawing.Size(306, 59);
            this.txtMuistiinpanot.TabIndex = 17;
            // 
            // btnTallenna
            // 
            this.btnTallenna.Location = new System.Drawing.Point(241, 344);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(95, 20);
            this.btnTallenna.TabIndex = 18;
            this.btnTallenna.Text = "Tallenna ottelu";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // lblViesti
            // 
            this.lblViesti.AutoSize = true;
            this.lblViesti.Location = new System.Drawing.Point(238, 373);
            this.lblViesti.Name = "lblViesti";
            this.lblViesti.Size = new System.Drawing.Size(0, 13);
            this.lblViesti.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Uusi ottelu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Erät";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Omat pisteet";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Vastustajan pisteet";
            // 
            // btnNaytaTilastot
            // 
            this.btnNaytaTilastot.Location = new System.Drawing.Point(447, 344);
            this.btnNaytaTilastot.Name = "btnNaytaTilastot";
            this.btnNaytaTilastot.Size = new System.Drawing.Size(95, 20);
            this.btnNaytaTilastot.TabIndex = 24;
            this.btnNaytaTilastot.Text = "Näytä tilastot";
            this.btnNaytaTilastot.UseVisualStyleBackColor = true;
            this.btnNaytaTilastot.Click += new System.EventHandler(this.btnNaytaTilastot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.btnNaytaTilastot);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblViesti);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.txtMuistiinpanot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVastustaja3);
            this.Controls.Add(this.txtVastustaja2);
            this.Controls.Add(this.txtVastustaja1);
            this.Controls.Add(this.txtOma3);
            this.Controls.Add(this.txtOma2);
            this.Controls.Add(this.txtOma1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpPaivamaara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVastustaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLaji);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mailapelistatistiikka - Uusi ottelu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLaji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVastustaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPaivamaara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOma1;
        private System.Windows.Forms.TextBox txtOma2;
        private System.Windows.Forms.TextBox txtOma3;
        private System.Windows.Forms.TextBox txtVastustaja1;
        private System.Windows.Forms.TextBox txtVastustaja2;
        private System.Windows.Forms.TextBox txtVastustaja3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMuistiinpanot;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.Label lblViesti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNaytaTilastot;
    }
}

