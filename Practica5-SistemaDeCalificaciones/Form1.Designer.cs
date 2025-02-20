namespace Practica5_SistemaDeCalificaciones
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNote1 = new System.Windows.Forms.Label();
            this.lblNote2 = new System.Windows.Forms.Label();
            this.lblNote3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.txtNote3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(843, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 63);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Fira Code", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genera tu promedio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNote1
            // 
            this.lblNote1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNote1.AutoSize = true;
            this.lblNote1.BackColor = System.Drawing.Color.Transparent;
            this.lblNote1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNote1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote1.Location = new System.Drawing.Point(30, 128);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Size = new System.Drawing.Size(122, 32);
            this.lblNote1.TabIndex = 3;
            this.lblNote1.Text = "Parcial 1";
            this.lblNote1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNote1.Click += new System.EventHandler(this.lblNote1_Click);
            // 
            // lblNote2
            // 
            this.lblNote2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNote2.AutoSize = true;
            this.lblNote2.BackColor = System.Drawing.Color.Transparent;
            this.lblNote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNote2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote2.Location = new System.Drawing.Point(30, 205);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new System.Drawing.Size(122, 32);
            this.lblNote2.TabIndex = 4;
            this.lblNote2.Text = "Parcial 2";
            this.lblNote2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNote3
            // 
            this.lblNote3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNote3.AutoSize = true;
            this.lblNote3.BackColor = System.Drawing.Color.Transparent;
            this.lblNote3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNote3.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote3.Location = new System.Drawing.Point(30, 279);
            this.lblNote3.Name = "lblNote3";
            this.lblNote3.Size = new System.Drawing.Size(122, 32);
            this.lblNote3.TabIndex = 5;
            this.lblNote3.Text = "Parcial 3";
            this.lblNote3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblPromedio);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(316, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 184);
            this.panel2.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStatus.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(20, 112);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(258, 69);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Estatus: ";
            // 
            // lblPromedio
            // 
            this.lblPromedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPromedio.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.ForeColor = System.Drawing.Color.Black;
            this.lblPromedio.Location = new System.Drawing.Point(20, 28);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(134, 32);
            this.lblPromedio.TabIndex = 0;
            this.lblPromedio.Text = "Promedio: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Fira Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(62, 376);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(156, 48);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingresa tus calificaciones (000)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNote1
            // 
            this.txtNote1.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote1.Location = new System.Drawing.Point(183, 128);
            this.txtNote1.Multiline = true;
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(95, 32);
            this.txtNote1.TabIndex = 14;
            this.txtNote1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNote1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNote1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote1_KeyPress);
            // 
            // txtNote2
            // 
            this.txtNote2.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote2.Location = new System.Drawing.Point(183, 202);
            this.txtNote2.Multiline = true;
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.Size = new System.Drawing.Size(95, 32);
            this.txtNote2.TabIndex = 15;
            this.txtNote2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNote3
            // 
            this.txtNote3.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote3.Location = new System.Drawing.Point(183, 276);
            this.txtNote3.Multiline = true;
            this.txtNote3.Name = "txtNote3";
            this.txtNote3.Size = new System.Drawing.Size(95, 32);
            this.txtNote3.TabIndex = 16;
            this.txtNote3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Fira Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(373, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 48);
            this.button2.TabIndex = 17;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbResultado
            // 
            this.pbResultado.Location = new System.Drawing.Point(637, 127);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(184, 184);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResultado.TabIndex = 18;
            this.pbResultado.TabStop = false;
            this.pbResultado.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.pbResultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNote3);
            this.Controls.Add(this.txtNote2);
            this.Controls.Add(this.txtNote1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNote3);
            this.Controls.Add(this.lblNote2);
            this.Controls.Add(this.lblNote1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNote1;
        private System.Windows.Forms.Label lblNote2;
        private System.Windows.Forms.Label lblNote3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNote1;
        private System.Windows.Forms.TextBox txtNote2;
        private System.Windows.Forms.TextBox txtNote3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbResultado;
    }
}

