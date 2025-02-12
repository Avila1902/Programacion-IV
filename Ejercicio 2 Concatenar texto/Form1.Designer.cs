namespace Ejercicio_2_Concatenar_texto
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
            this.txtPal1 = new System.Windows.Forms.TextBox();
            this.txtPal2 = new System.Windows.Forms.TextBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPal1
            // 
            this.txtPal1.Location = new System.Drawing.Point(107, 75);
            this.txtPal1.Multiline = true;
            this.txtPal1.Name = "txtPal1";
            this.txtPal1.Size = new System.Drawing.Size(171, 54);
            this.txtPal1.TabIndex = 0;
            // 
            // txtPal2
            // 
            this.txtPal2.Location = new System.Drawing.Point(520, 75);
            this.txtPal2.Multiline = true;
            this.txtPal2.Name = "txtPal2";
            this.txtPal2.Size = new System.Drawing.Size(171, 54);
            this.txtPal2.TabIndex = 1;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(295, 200);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(207, 52);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(391, 364);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(0, 16);
            this.lblPalabra.TabIndex = 3;
            this.lblPalabra.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.btnJuntar);
            this.Controls.Add(this.txtPal2);
            this.Controls.Add(this.txtPal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPal1;
        private System.Windows.Forms.TextBox txtPal2;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Label lblPalabra;
    }
}

