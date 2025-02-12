namespace _01_Hola_Mundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            lbltexto.Text = txtTexto.Text;
            txtTexto.Text = ""; //Borrar texto
        }
    }
}
