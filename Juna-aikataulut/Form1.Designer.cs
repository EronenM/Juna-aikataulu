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
            this.tbTulos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bHae
            // 
            this.bHae.Location = new System.Drawing.Point(455, 40);
            this.bHae.Name = "bHae";
            this.bHae.Size = new System.Drawing.Size(176, 47);
            this.bHae.TabIndex = 0;
            this.bHae.Text = "Hae";
            this.bHae.UseVisualStyleBackColor = true;
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
            this.tbMistä.Location = new System.Drawing.Point(18, 52);
            this.tbMistä.Name = "tbMistä";
            this.tbMistä.Size = new System.Drawing.Size(131, 22);
            this.tbMistä.TabIndex = 2;
            // 
            // tbMinne
            // 
            this.tbMinne.Location = new System.Drawing.Point(228, 52);
            this.tbMinne.Name = "tbMinne";
            this.tbMinne.Size = new System.Drawing.Size(131, 22);
            this.tbMinne.TabIndex = 4;
            this.tbMinne.TextChanged += new System.EventHandler(this.tbMinne_TextChanged);
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
            // tbTulos
            // 
            this.tbTulos.Location = new System.Drawing.Point(21, 130);
            this.tbTulos.Name = "tbTulos";
            this.tbTulos.Size = new System.Drawing.Size(337, 22);
            this.tbTulos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 523);
            this.Controls.Add(this.tbTulos);
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
        private System.Windows.Forms.TextBox tbTulos;
    }
}

