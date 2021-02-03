
namespace PresentationLayer
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
            this.listBoxLista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.textBoxRok = new System.Windows.Forms.TextBox();
            this.DODAJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLista
            // 
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.Location = new System.Drawing.Point(12, 330);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(762, 95);
            this.listBoxLista.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rok trajanja:";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(61, 30);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxNaziv.TabIndex = 6;
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(219, 30);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(100, 20);
            this.textBoxOpis.TabIndex = 7;
            // 
            // textBoxRok
            // 
            this.textBoxRok.Location = new System.Drawing.Point(411, 30);
            this.textBoxRok.Name = "textBoxRok";
            this.textBoxRok.Size = new System.Drawing.Size(100, 20);
            this.textBoxRok.TabIndex = 8;
            // 
            // DODAJ
            // 
            this.DODAJ.Location = new System.Drawing.Point(188, 159);
            this.DODAJ.Name = "DODAJ";
            this.DODAJ.Size = new System.Drawing.Size(199, 71);
            this.DODAJ.TabIndex = 9;
            this.DODAJ.Text = "DODAJ";
            this.DODAJ.UseVisualStyleBackColor = true;
            this.DODAJ.Click += new System.EventHandler(this.DODAJ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DODAJ);
            this.Controls.Add(this.textBoxRok);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxLista);
            this.Name = "Form1";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.TextBox textBoxRok;
        private System.Windows.Forms.Button DODAJ;
    }
}

