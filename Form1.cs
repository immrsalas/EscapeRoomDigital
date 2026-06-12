global using System.Media;

namespace EscapeRoomDigital
{
    public partial class Form1 : Form
    {

        private SoundPlayer reproductorMusic;


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

            picComputadora.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
