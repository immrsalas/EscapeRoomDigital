global using System.Media;

namespace EscapeRoomDigital
{
    public partial class Form1 : Form
    {

        private SoundPlayer reproductorMusic;
        private AcertijoComputadora acertijoActual;
        private bool computadoraDesbloqueada = false;
        private bool tieneLlave = false;

        public Form1()
        {
            InitializeComponent();
            InicializarMusica();
        }


        private void InicializarMusica()
        {
            try
            {
                reproductorMusic = new SoundPlayer(Properties.Resources.AudioSuspenso);


                reproductorMusic.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la música de fondo: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnPLAY.Visible = false;
            titleName.Visible = false;

            panelLaboratorio.Visible = true;
            panelHistoria.Visible = true;

            string textoContexto = "¡ALERTA! El protocolo de confinamiento se ha activado.\n\n" +
                             "Estás atrapado en los laboratorios de alta seguridad del Área 51 \n" +
                             "y los agentes alienígenas te vigilan desde el exterior.\n\n" +
                             "Tu única oportunidad es interactuar con el equipo del laboratorio, \n" +
                             "descifrar los códigos ocultos y activar el interruptor de emergencia \n" +
                             "antes de que se termine el tiempo.";

            labelContexto.Text = textoContexto;

        }

        private void panelLaboratorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelHistoria_Click(object sender, EventArgs e)
        {
        }

        private void labelContexto_Click(object sender, EventArgs e)
        {

        }

        private void btnEntendido_Click(object sender, EventArgs e)
        {

            panelHistoria.Visible = false;
            labelContexto.Visible = false;

            txtRespuesta.Visible = false;
            btnRespuesta.Visible = false;

            picComputadora.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelHistoria.Visible = true;
            labelContexto.Visible = true;

            if (computadoraDesbloqueada)
            {
                labelContexto.Text =
                    "[ARCHIVOS DESCLASIFICADOS]\n\n" +
                    "Acceso autorizado al sistema central del Área 51.\n\n" +
                    "Registro recuperado:\n" +
                    "La llave de emergencia está oculta cerca del tanque biológico.\n\n" +
                    "Busca el objeto brillante y úsalo para abrir la salida.";

                txtRespuesta.Visible = false;
                btnRespuesta.Visible = false;
                btnEntendido.Visible = true;
                return;
            }

            acertijoActual = new AcertijoComputadora();

            labelContexto.Text = acertijoActual.Pregunta;

            txtRespuesta.Clear();

            btnEntendido.Visible = false;
            txtRespuesta.Visible = true;
            btnRespuesta.Visible = true;
            txtRespuesta.Focus();
        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            string respuesta = txtRespuesta.Text.Trim();

            if (acertijoActual.Resolver(respuesta))
            {
                computadoraDesbloqueada = true;
                

                MessageBox.Show(
                    "Acceso concedido.\n\nHas desbloqueado la computadora del Área 51.",
                    "Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                panelHistoria.Visible = false;
                txtRespuesta.Visible = false;
                btnRespuesta.Visible = false;

            }

            else
            {
                MessageBox.Show(
                    $"Código incorrecto.\nIntentos restantes: {acertijoActual.Intentos}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                if (acertijoActual.Intentos <= 0)
                {
                    MessageBox.Show(
                        "Has agotado todos los intentos.\nLos agentes alienígenas te han capturado.",
                        "GAME OVER",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    Application.Exit();
                }
            }
        }

       
    }
}
