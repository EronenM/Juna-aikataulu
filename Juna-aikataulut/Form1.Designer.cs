namespace Juna_aikataulut
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
            this.bValitseJuna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bHae
            // 
            this.bHae.AllowDrop = true;
            this.bHae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(215)))), ((int)(((byte)(144)))));
            this.bHae.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.bHae.Location = new System.Drawing.Point(381, 88);
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
            this.tbMistä.Location = new System.Drawing.Point(21, 41);
            this.tbMistä.Name = "tbMistä";
            this.tbMistä.Size = new System.Drawing.Size(131, 22);
            this.tbMistä.TabIndex = 2;
            //this.tbMistä.Leave += new System.EventHandler(this.tbMistä_Leave);
            // 
            // tbMinne
            // 
            this.tbMinne.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMinne.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbMinne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMinne.Location = new System.Drawing.Point(173, 41);
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
            this.lbTulos.Size = new System.Drawing.Size(283, 372);
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
            this.lbJunanKulku.Location = new System.Drawing.Point(618, 88);
            this.lbJunanKulku.Name = "lbJunanKulku";
            this.lbJunanKulku.Size = new System.Drawing.Size(373, 372);
            this.lbJunanKulku.TabIndex = 7;
            // 
            // bVR
            // 
            this.bVR.Location = new System.Drawing.Point(873, 33);
            this.bVR.Name = "bVR";
            this.bVR.Size = new System.Drawing.Size(118, 38);
            this.bVR.TabIndex = 8;
            this.bVR.Text = "Siirry VR";
            this.bVR.UseVisualStyleBackColor = true;
            this.bVR.Click += new System.EventHandler(this.bVR_Click);
            // 
            // bValitseJuna
            // 
            this.bValitseJuna.AllowDrop = true;
            this.bValitseJuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(215)))), ((int)(((byte)(144)))));
            this.bValitseJuna.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.bValitseJuna.Location = new System.Drawing.Point(381, 212);
            this.bValitseJuna.Name = "bValitseJuna";
            this.bValitseJuna.Size = new System.Drawing.Size(176, 47);
            this.bValitseJuna.TabIndex = 10;
            this.bValitseJuna.Text = "Valitse Juna";
            this.bValitseJuna.UseVisualStyleBackColor = false;
            this.bValitseJuna.Click += new System.EventHandler(this.bValitseJuna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1050, 563);
            this.Controls.Add(this.bValitseJuna);
            this.Controls.Add(this.bVR);
            this.Controls.Add(this.lbJunanKulku);
            this.Controls.Add(this.lbTulos);
            this.Controls.Add(this.tbMinne);
            this.Controls.Add(this.lMinne);
            this.Controls.Add(this.tbMistä);
            this.Controls.Add(this.lMistä);
            this.Controls.Add(this.bHae);
            this.Name = "Form1";
            this.Text = "Juna-aikataulut";
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
        private System.Windows.Forms.Button bVR;
        private System.Windows.Forms.Button bValitseJuna;
    }
}

