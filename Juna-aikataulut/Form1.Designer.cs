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
            this.bHae = new System.Windows.Forms.Button();
            this.lMistä = new System.Windows.Forms.Label();
            this.tbMistä = new System.Windows.Forms.TextBox();
            this.tbMinne = new System.Windows.Forms.TextBox();
            this.lMinne = new System.Windows.Forms.Label();
            this.lbTulos = new System.Windows.Forms.ListBox();
            this.valitsenappi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.poistanappi = new System.Windows.Forms.Button();
            this.VR = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.junatnet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bHae
            // 
            this.bHae.BackColor = System.Drawing.Color.Red;
            this.bHae.Location = new System.Drawing.Point(455, 40);
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
            this.lMistä.Location = new System.Drawing.Point(26, 21);
            this.lMistä.Name = "lMistä";
            this.lMistä.Size = new System.Drawing.Size(41, 17);
            this.lMistä.TabIndex = 1;
            this.lMistä.Text = "Mistä";
            this.lMistä.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbMistä
            // 
            this.tbMistä.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMistä.Location = new System.Drawing.Point(18, 52);
            this.tbMistä.Name = "tbMistä";
            this.tbMistä.Size = new System.Drawing.Size(131, 22);
            this.tbMistä.TabIndex = 2;
            // 
            // tbMinne
            // 
            this.tbMinne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMinne.Location = new System.Drawing.Point(228, 52);
            this.tbMinne.Name = "tbMinne";
            this.tbMinne.Size = new System.Drawing.Size(131, 22);
            this.tbMinne.TabIndex = 4;
            // 
            // lMinne
            // 
            this.lMinne.AutoSize = true;
            this.lMinne.Location = new System.Drawing.Point(236, 21);
            this.lMinne.Name = "lMinne";
            this.lMinne.Size = new System.Drawing.Size(46, 17);
            this.lMinne.TabIndex = 3;
            this.lMinne.Text = "Minne";
            // 
            // lbTulos
            // 
            this.lbTulos.FormattingEnabled = true;
            this.lbTulos.ItemHeight = 16;
            this.lbTulos.Location = new System.Drawing.Point(21, 168);
            this.lbTulos.Name = "lbTulos";
            this.lbTulos.Size = new System.Drawing.Size(337, 180);
            this.lbTulos.TabIndex = 6;
            // 
            // valitsenappi
            // 
            this.valitsenappi.Location = new System.Drawing.Point(441, 170);
            this.valitsenappi.Name = "valitsenappi";
            this.valitsenappi.Size = new System.Drawing.Size(104, 43);
            this.valitsenappi.TabIndex = 7;
            this.valitsenappi.Text = "Valitse";
            this.valitsenappi.UseVisualStyleBackColor = true;
            this.valitsenappi.Click += new System.EventHandler(this.valitsenappi_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(594, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 180);
            this.listBox1.TabIndex = 8;
            // 
            // poistanappi
            // 
            this.poistanappi.Location = new System.Drawing.Point(441, 219);
            this.poistanappi.Name = "poistanappi";
            this.poistanappi.Size = new System.Drawing.Size(104, 46);
            this.poistanappi.TabIndex = 9;
            this.poistanappi.Text = "Poista";
            this.poistanappi.UseVisualStyleBackColor = true;
            this.poistanappi.Click += new System.EventHandler(this.poistanappi_Click);
            // 
            // VR
            // 
            this.VR.Location = new System.Drawing.Point(789, 43);
            this.VR.Name = "VR";
            this.VR.Size = new System.Drawing.Size(112, 43);
            this.VR.TabIndex = 10;
            this.VR.Text = "VR";
            this.VR.UseVisualStyleBackColor = true;
            this.VR.Click += new System.EventHandler(this.VR_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(399, 111);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(161, 42);
            this.webBrowser1.TabIndex = 11;
            // 
            // junatnet
            // 
            this.junatnet.Location = new System.Drawing.Point(797, 104);
            this.junatnet.Name = "junatnet";
            this.junatnet.Size = new System.Drawing.Size(103, 48);
            this.junatnet.TabIndex = 12;
            this.junatnet.Text = "Junat.net";
            this.junatnet.UseVisualStyleBackColor = true;
            this.junatnet.Click += new System.EventHandler(this.junatnet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 523);
            this.Controls.Add(this.junatnet);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.VR);
            this.Controls.Add(this.poistanappi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.valitsenappi);
            this.Controls.Add(this.lbTulos);
            this.Controls.Add(this.tbMinne);
            this.Controls.Add(this.lMinne);
            this.Controls.Add(this.tbMistä);
            this.Controls.Add(this.lMistä);
            this.Controls.Add(this.bHae);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button valitsenappi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button poistanappi;
        private System.Windows.Forms.Button VR;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button junatnet;
    }
}

