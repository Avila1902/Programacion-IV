namespace _01_Hola_Mundo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCambiar = new Button();
            lbltexto = new Label();
            txtTexto = new TextBox();
            SuspendLayout();
            // 
            // btnCambiar
            // 
            btnCambiar.Location = new Point(377, 255);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(94, 29);
            btnCambiar.TabIndex = 0;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // lbltexto
            // 
            lbltexto.AutoSize = true;
            lbltexto.BackColor = SystemColors.GradientActiveCaption;
            lbltexto.Location = new Point(345, 67);
            lbltexto.Name = "lbltexto";
            lbltexto.Size = new Size(92, 20);
            lbltexto.TabIndex = 1;
            lbltexto.Text = "Hola Mundo";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(356, 198);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(151, 27);
            txtTexto.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTexto);
            Controls.Add(lbltexto);
            Controls.Add(btnCambiar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiar;
        private Label lbltexto;
        private TextBox txtTexto;
    }
}
