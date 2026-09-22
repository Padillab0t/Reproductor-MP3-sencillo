using WMPLib;

namespace Reproductor_MP3_sencillo
{
    public partial class Form1 : Form
    {
        //Objeto que se encargará de reproducir el audio
        private WindowsMediaPlayer reproductor;

        //Guarda la ruta del archivo de audio seleccionado
        private string archivoSeleecionado = "";

        public Form1()
        {
            InitializeComponent();
            //Creamos el repdroductor
            reproductor = new WindowsMediaPlayer();
            //Evitar que se reproduzca un audio
            reproductor.settings.autoStart = false;
            //Configuramos el OpenFileDialog
            openFileDialog1.Filter =
                "Archivos de audio (*.mp3|*.mp3";
            openFileDialog1.Title = "Selecciona un archivo MP3";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*si no hay un archivo seleccionado,
                 abrimos el explorador de archivos*/
                if (string.IsNullOrEmpty(archivoSeleecionado))
                {
                    DialogResult resultado =
                        openFileDialog1.ShowDialog();
                    //El usuario cancelo la seleccion
                    if (resultado != DialogResult.OK)
                    {
                        return;
                    }
                    //Guardar la ruta del archivo
                    archivoSeleecionado =
                        openFileDialog1.FileName;
                    //Mostramos el nombre del archivo en el label
                    label2.Text = "Archivo seleccionado: "+
                        Path.GetFileName(archivoSeleecionado);
                }
                //Indicamos al reproductor que reproduzca al archivo seleccionado
                reproductor.URL = archivoSeleecionado;
                //Reproducir sonido
                reproductor.controls.play();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
