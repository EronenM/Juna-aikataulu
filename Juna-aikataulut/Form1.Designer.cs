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
            this.label1 = new System.Windows.Forms.Label();
            this.lbJunanKulku = new System.Windows.Forms.ListBox();
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
            this.bHae.Click += new System.EventHandler(this.bHae_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Asematiedot";
            // 
            // lbJunanKulku
            // 
            this.lbJunanKulku.FormattingEnabled = true;
            this.lbJunanKulku.ItemHeight = 16;
            this.lbJunanKulku.Location = new System.Drawing.Point(452, 169);
            this.lbJunanKulku.Name = "lbJunanKulku";
            this.lbJunanKulku.Size = new System.Drawing.Size(266, 196);
            this.lbJunanKulku.TabIndex = 10;
            this.lbJunanKulku.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 523);
            this.Controls.Add(this.lbJunanKulku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bHae);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bHae;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbJunanKulku;
    }
}

