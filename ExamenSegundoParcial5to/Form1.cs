using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSegundoParcial5to
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario cuando se presiona el botón "Cerrar".
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // Este evento se dispara cuando cambia el estado del radioButton4, pero no tiene ninguna acción.
        }

        private void btnCaclular_Click(object sender, EventArgs e)
        {
            pcbResultado.Visible = true; // Hace visible el PictureBox con la imagen del signo zodiacal.
            lblMensajeFinal.Visible = true; //Hace visible el label con el mensaje final.
            int dia; // Variable para almacenar el día ingresado por el usuario.

            // Intenta convertir el texto del TextBox a un número entero.
            // Si no es válido o está fuera del rango permitido (1-31), muestra un mensaje de error.
            if (!int.TryParse(txtBornDay.Text, out dia) || dia < 1 || dia > 31)
            {
                MessageBox.Show("Ingrese un día válido (1-31).");
                return; // Sale del método si la entrada no es válida.
            }
            

            string mesSeleccionado = ""; // Variable para almacenar el mes seleccionado.

            // Recorre los RadioButtons dentro del GroupBox para encontrar cuál está seleccionado.
            // Seccion de foreach generada con prompt de chatgpt
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked) // Si un RadioButton está seleccionado
                {
                    mesSeleccionado = rb.Text; // Guarda el texto del RadioButton (el nombre del mes).
                    break; // Sale del bucle una vez encontrado.
                }
            }

            // Se usa un switch para evaluar el mes seleccionado
            switch (mesSeleccionado)
            {
                case "Enero":
                    // Si el día está entre 20 y 31, el signo es Acuario.
                    if ((dia >= 20) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/acuario.png");
                        lblMensajeFinal.Text = "El visionario y rebelde. Acuario rompe las reglas," +
                            " piensa en el futuro y siempre va un paso adelante. Es original," +
                            " libre y con un pensamiento que pocos pueden seguir.";
                    }
                        
                    // Si el día está entre 1 y 19, el signo es Capricornio.
                    else if ((dia >= 1) && (dia <= 19))
                        pcbResultado.Image = Image.FromFile("Resources/capricornio.png");
                        lblMensajeFinal.Text = "El estratega del zodiaco. Trabajador, disciplinado" +
                            " y con la paciencia de un sabio. Puede parecer serio, pero detrás de su" +
                            " ambición hay un gran corazón que protege a los suyos.";
                    break;

                case "Febrero":
                    if ((dia >= 1) && (dia <= 18))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/acuario.png");
                        lblMensajeFinal.Text = "El visionario y rebelde. Acuario rompe las reglas," +
                            " piensa en el futuro y siempre va un paso adelante. Es original," +
                            " libre y con un pensamiento que pocos pueden seguir.";
                    }

                    else if ((dia >= 19) && (dia <= 31)){
                        pcbResultado.Image = Image.FromFile("Resources/piscis.png");
                        lblMensajeFinal.Text = "El soñador del zodiaco. Sensible, creativo" +
                            " y con un mundo interior fascinante. Piscis siente profundo y ama" +
                            " sin medida, siempre buscando conectar con el alma de los demás.";
                    }
                    break;

                case "Marzo":
                    if ((dia >= 1) && (dia <= 20)){
                        pcbResultado.Image = Image.FromFile("Resources/piscis.png");
                        lblMensajeFinal.Text = "El soñador del zodiaco. Sensible, creativo" +
                            " y con un mundo interior fascinante. Piscis siente profundo y ama" +
                            " sin medida, siempre buscando conectar con el alma de los demás.";
                    }
                    else if ((dia >= 21) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/aries.png");
                        lblMensajeFinal.Text = "¡El líder intrépido! Aventurero, impulsivo" +
                            " y con una energía que arrasa con todo. Aries no espera, actúa. " +
                            "Directo, valiente y siempre buscando nuevos desafíos.";
                    }
                    break;

                case "Abril":
                    if ((dia >= 1) && (dia <= 19))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/aries.png");
                        lblMensajeFinal.Text = "¡El líder intrépido! Aventurero, impulsivo" +
                            " y con una energía que arrasa con todo. Aries no espera, actúa. " +
                            "Directo, valiente y siempre buscando nuevos desafíos.";
                    }
                    else if ((dia >= 20) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/tauro.png");
                        lblMensajeFinal.Text = "El signo más terco, pero también el más leal." +
                            " Amante del lujo, la buena comida y la estabilidad. No lo apresures, " +
                            "Tauro va a su ritmo… pero cuando se compromete, ¡es para siempre!";
                    }
                    break;

                case "Mayo":
                    if ((dia >= 1) && (dia <= 20))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/tauro.png");
                        lblMensajeFinal.Text = "El signo más terco, pero también el más leal." +
                            " Amante del lujo, la buena comida y la estabilidad. No lo apresures, " +
                            "Tauro va a su ritmo… pero cuando se compromete, ¡es para siempre!";
                    }
                    else if ((dia >= 21) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/geminis.png");
                        lblMensajeFinal.Text = "El alma de la fiesta y el maestro de la conversación." +
                            " Curioso, ingenioso y con mil ideas al mismo tiempo. " +
                            "Nunca te aburrirás con un Géminis, pero... ¿puedes seguirle el paso?";
                    }
                    break;

                case "Junio":
                    if ((dia >= 1) && (dia <= 20))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/geminis.png");
                        lblMensajeFinal.Text = "El alma de la fiesta y el maestro de la conversación." +
                            " Curioso, ingenioso y con mil ideas al mismo tiempo. " +
                            "Nunca te aburrirás con un Géminis, pero... ¿puedes seguirle el paso?";
                    }
                    else if ((dia >= 21) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/cancer.png");
                        lblMensajeFinal.Text = "El más sentimental del zodiaco. Protector, hogareño" +
                            " y con un corazón enorme. Parece fuerte por fuera, pero su interior" +
                            " es puro sentimiento. ¡Si te quiere, te lo demuestra con hechos!";
                    }
                    break;

                case "Julio":
                    if ((dia >= 1) && (dia <= 22))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/cancer.png");
                        lblMensajeFinal.Text = "El más sentimental del zodiaco. Protector, hogareño" +
                            " y con un corazón enorme. Parece fuerte por fuera, pero su interior" +
                            " es puro sentimiento. ¡Si te quiere, te lo demuestra con hechos!";
                    }
                    else if ((dia >= 23) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/leo.png");
                        lblMensajeFinal.Text = "¡El rey de la selva y del drama! Carismático," +
                            " seguro de sí mismo y con un brillo natural que nadie puede ignorar. " +
                            "Ama ser el centro de atención y tiene un corazón gigante.";
                    }
                    break;

                case "Agosto":
                    if ((dia >= 1) && (dia <= 22))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/leo.png");
                        lblMensajeFinal.Text = "¡El rey de la selva y del drama! Carismático," +
                            " seguro de sí mismo y con un brillo natural que nadie puede ignorar. " +
                            "Ama ser el centro de atención y tiene un corazón gigante.";
                    }
                    else if ((dia >= 23) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/virgo.png");
                        lblMensajeFinal.Text = "El perfeccionista del zodiaco. Analítico, detallista" +
                            " y con un plan para todo. Le gusta el orden y la eficiencia, pero también" +
                            " sabe cuidar con pequeños detalles a quienes ama.";
                    }
                    break;

                case "Septiembre":
                    if ((dia >= 1) && (dia <= 22))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/virgo.png");
                        lblMensajeFinal.Text = "El perfeccionista del zodiaco. Analítico, detallista" +
                            " y con un plan para todo. Le gusta el orden y la eficiencia, pero también" +
                            " sabe cuidar con pequeños detalles a quienes ama.";
                    }
                    else if ((dia >= 23) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/libra.png");
                        lblMensajeFinal.Text = "El diplomático encantador. Amante de la paz," +
                            " la belleza y el equilibrio. Libra tiene un talento natural para" +
                            " ver los dos lados de la moneda… ¡pero a veces tarda en decidirse!";
                    }
                    break;

                case "Octubre":
                    if ((dia >= 1) && (dia <= 22))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/libra.png");
                        lblMensajeFinal.Text = "El diplomático encantador. Amante de la paz," +
                            " la belleza y el equilibrio. Libra tiene un talento natural para" +
                            " ver los dos lados de la moneda… ¡pero a veces tarda en decidirse!";
                    }
                    else if ((dia >= 23) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/escorpio.png");
                        lblMensajeFinal.Text = "Misterioso, intenso y apasionado. Un Escorpio" +
                            " no se anda con juegos, es todo o nada. Si te ganas su confianza," +
                            " te será leal para siempre... pero si lo traicionas, prepárate.";
                    }
                    break;

                case "Noviembre":
                    if ((dia >= 1) && (dia <= 21))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/escorpio.png");
                        lblMensajeFinal.Text = "Misterioso, intenso y apasionado. Un Escorpio" +
                            " no se anda con juegos, es todo o nada. Si te ganas su confianza," +
                            " te será leal para siempre... pero si lo traicionas, prepárate.";
                    }
                    else if ((dia >= 22) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/sagitario.png");
                        lblMensajeFinal.Text = "El aventurero del zodiaco. Amante de la libertad," +
                            " optimista y siempre en busca de la próxima gran experiencia." +
                            " Sagitario no se queda quieto, ¡su espíritu es indomable!";
                    }
                    break;

                case "Diciembre":
                    if ((dia >= 1) && (dia <= 21))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/sagitario.png");
                        lblMensajeFinal.Text = "El aventurero del zodiaco. Amante de la libertad," +
                            " optimista y siempre en busca de la próxima gran experiencia." +
                            " Sagitario no se queda quieto, ¡su espíritu es indomable!";
                    }
                    else if ((dia >= 22) && (dia <= 31))
                    {
                        pcbResultado.Image = Image.FromFile("Resources/capricornio.png");
                        lblMensajeFinal.Text = "El estratega del zodiaco. Trabajador, disciplinado" +
                            " y con la paciencia de un sabio. Puede parecer serio, pero detrás de su" +
                            " ambición hay un gran corazón que protege a los suyos.";
                    }
                    break;
            }
        }

        private void lblMensajeFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
