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
            this.lMistä.Location = new System.Drawing.Point(18, 21);
            this.lMistä.Name = "lMistä";
            this.lMistä.Size = new System.Drawing.Size(41, 17);
            this.lMistä.TabIndex = 1;
            this.lMistä.Text = "Mistä";
            this.lMistä.Click += new System.EventHandler(this.label1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 523);
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
    }
}

