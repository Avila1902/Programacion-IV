namespace Ejercicio_3_AreaDeUnCirculo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTxt = new System.Windows.Forms.Label();
            this.txtVaIngresado = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(751, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(754, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "04 Area y Perimetro de un circulo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTxt.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt.Location = new System.Drawing.Point(238, 77);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(529, 44);
            this.lblTxt.TabIndex = 2;
            this.lblTxt.Text = "Ingresar el radio del circlulo";
            // 
            // txtVaIngresado
            // 
            this.txtVaIngresado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVaIngresado.Font = new System.Drawing.Font("Fira Code", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVaIngresado.Location = new System.Drawing.Point(371, 150);
            this.txtVaIngresado.Multiline = true;
            this.txtVaIngresado.Name = "txtVaIngresado";
            this.txtVaIngresado.Size = new System.Drawing.Size(327, 66);
            this.txtVaIngresado.TabIndex = 3;
            this.txtVaIngresado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnArea
            // 
            this.btnArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArea.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArea.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnArea.Location = new System.Drawing.Point(61, 150);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(208, 101);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Calcular Area";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerimetro.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnPerimetro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerimetro.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimetro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPerimetro.Location = new System.Drawing.Point(61, 288);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(208, 101);
            this.btnPerimetro.TabIndex = 5;
            this.btnPerimetro.Text = "Calcular Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = false;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Crimson;
            this.lblResultado.Font = new System.Drawing.Font("Fira Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(469, 306);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 47);
            this.lblResultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtVaIngresado);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.TextBox txtVaIngresado;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.Label lblResultado;
    }
}

