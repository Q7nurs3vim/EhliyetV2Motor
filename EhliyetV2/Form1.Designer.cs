namespace EhliyetV2
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
            this.lblYas = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.BackColor = System.Drawing.Color.Transparent;
            this.lblYas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblYas.Location = new System.Drawing.Point(25, 37);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(31, 13);
            this.lblYas.TabIndex = 0;
            this.lblYas.Text = "Yaş :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDurum.Location = new System.Drawing.Point(28, 79);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 13);
            this.lblDurum.TabIndex = 1;
            this.lblDurum.Text = "Durum :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(57, 115);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 34);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(88, 34);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(100, 20);
            this.txtyas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(222, 190);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblYas);
            this.Name = "Form1";
            this.Text = "Motor Ehliyeti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtyas;
    }
}

