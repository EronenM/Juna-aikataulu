﻿namespace Juna_aikataulut
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
            this.components = new System.ComponentModel.Container();
            this.bHae = new System.Windows.Forms.Button();
            this.lMistä = new System.Windows.Forms.Label();
            this.tbMistä = new System.Windows.Forms.TextBox();
            this.tbMinne = new System.Windows.Forms.TextBox();
            this.lMinne = new System.Windows.Forms.Label();
            this.lbTulos = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbJunanKulku = new System.Windows.Forms.ListBox();
            this.bVR = new System.Windows.Forms.Button();
            this.bSiirryJunat = new System.Windows.Forms.Button();
            this.bValitseJuna = new System.Windows.Forms.Button();
            this.lbValittuJuna = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bHae
            // 
            this.bHae.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bHae.Location = new System.Drawing.Point(352, 40);
            this.bHae.Name = "bHae";
            this.bHae.Size = new System.Drawing.Size(176, 47);
            this.bHae.TabIndex = 0;
            this.bHae.Text = "Hae";
            this.bHae.UseVisualStyleBackColor = false;
            this.bHae.Click += new System.EventHandler(this.bHae_Click);
            // 
            // lMistä
            // 
            this.lMistä.AutoSize = true;
            this.lMistä.Location = new System.Drawing.Point(18, 21);
            this.lMistä.Name = "lMistä";
            this.lMistä.Size = new System.Drawing.Size(41, 17);
            this.lMistä.TabIndex = 1;
            this.lMistä.Text = "Mistä";
            // 
            // tbMistä
            // 
            this.tbMistä.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbMistä.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMistä.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMistä.Location = new System.Drawing.Point(21, 52);
            this.tbMistä.Name = "tbMistä";
            this.tbMistä.Size = new System.Drawing.Size(131, 22);
            this.tbMistä.TabIndex = 2;
            // 
            // tbMinne
            // 
            this.tbMinne.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMinne.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMinne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMinne.Location = new System.Drawing.Point(173, 52);
            this.tbMinne.Name = "tbMinne";
            this.tbMinne.Size = new System.Drawing.Size(131, 22);
            this.tbMinne.TabIndex = 4;
            // 
            // lMinne
            // 
            this.lMinne.AutoSize = true;
            this.lMinne.Location = new System.Drawing.Point(170, 21);
            this.lMinne.Name = "lMinne";
            this.lMinne.Size = new System.Drawing.Size(46, 17);
            this.lMinne.TabIndex = 3;
            this.lMinne.Text = "Minne";
            // 
            // lbTulos
            // 
            this.lbTulos.FormattingEnabled = true;
            this.lbTulos.ItemHeight = 16;
            this.lbTulos.Location = new System.Drawing.Point(21, 88);
            this.lbTulos.Name = "lbTulos";
            this.lbTulos.Size = new System.Drawing.Size(283, 404);
            this.lbTulos.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // lbJunanKulku
            // 
            this.lbJunanKulku.FormattingEnabled = true;
            this.lbJunanKulku.ItemHeight = 16;
            this.lbJunanKulku.Location = new System.Drawing.Point(595, 88);
            this.lbJunanKulku.Name = "lbJunanKulku";
            this.lbJunanKulku.Size = new System.Drawing.Size(278, 372);
            this.lbJunanKulku.TabIndex = 7;
            // 
            // bVR
            // 
            this.bVR.Location = new System.Drawing.Point(754, 12);
            this.bVR.Name = "bVR";
            this.bVR.Size = new System.Drawing.Size(118, 40);
            this.bVR.TabIndex = 8;
            this.bVR.Text = "Siirry VR";
            this.bVR.UseVisualStyleBackColor = true;
            this.bVR.Click += new System.EventHandler(this.bVR_Click);
            // 
            // bSiirryJunat
            // 
            this.bSiirryJunat.Location = new System.Drawing.Point(623, 13);
            this.bSiirryJunat.Name = "bSiirryJunat";
            this.bSiirryJunat.Size = new System.Drawing.Size(116, 38);
            this.bSiirryJunat.TabIndex = 9;
            this.bSiirryJunat.Text = "Siirry junat.net";
            this.bSiirryJunat.UseVisualStyleBackColor = true;
            this.bSiirryJunat.Click += new System.EventHandler(this.bSiirryJunat_Click);
            // 
            // bValitseJuna
            // 
            this.bValitseJuna.BackColor = System.Drawing.Color.LawnGreen;
            this.bValitseJuna.Location = new System.Drawing.Point(352, 133);
            this.bValitseJuna.Name = "bValitseJuna";
            this.bValitseJuna.Size = new System.Drawing.Size(176, 47);
            this.bValitseJuna.TabIndex = 10;
            this.bValitseJuna.Text = "Valitse Juna";
            this.bValitseJuna.UseVisualStyleBackColor = false;
            this.bValitseJuna.Click += new System.EventHandler(this.bValitseJuna_Click);
            // 
            // lbValittuJuna
            // 
            this.lbValittuJuna.FormattingEnabled = true;
            this.lbValittuJuna.ItemHeight = 16;
            this.lbValittuJuna.Location = new System.Drawing.Point(356, 209);
            this.lbValittuJuna.Name = "lbValittuJuna";
            this.lbValittuJuna.Size = new System.Drawing.Size(171, 244);
            this.lbValittuJuna.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 523);
            this.Controls.Add(this.lbValittuJuna);
            this.Controls.Add(this.bValitseJuna);
            this.Controls.Add(this.bSiirryJunat);
            this.Controls.Add(this.bVR);
            this.Controls.Add(this.lbJunanKulku);
            this.Controls.Add(this.lbTulos);
            this.Controls.Add(this.tbMinne);
            this.Controls.Add(this.lMinne);
            this.Controls.Add(this.tbMistä);
            this.Controls.Add(this.lMistä);
            this.Controls.Add(this.bHae);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bHae;
        private System.Windows.Forms.Label lMistä;
        private System.Windows.Forms.TextBox tbMistä;
        private System.Windows.Forms.TextBox tbMinne;
        private System.Windows.Forms.Label lMinne;
        private System.Windows.Forms.ListBox lbTulos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lbJunanKulku;
        private System.Windows.Forms.Button bSiirryJunat;
        private System.Windows.Forms.Button bVR;
        private System.Windows.Forms.Button bValitseJuna;
        private System.Windows.Forms.ListBox lbValittuJuna;
    }
}

