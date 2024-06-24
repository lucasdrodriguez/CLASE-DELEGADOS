using biblioteca_clases_form;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proceso unProceso = new Proceso();
            unProceso.HacerProceso(MostrarError);
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
