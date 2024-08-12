namespace Tarea_introduccion_a_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMensaje.Text) ||
                string.IsNullOrWhiteSpace(textBoxMensaje.Text) ||
                string.IsNullOrWhiteSpace(textBoxMensaje.Text))
            {
                LabelEstado.Text = "Error: Por favor, completa todos los campos.";
                LabelEstado.ForeColor = Color.Red; 
            }
            else
            {

                LabelEstado.Text = "Formulario enviado correctamente.";
                LabelEstado.ForeColor = Color.Green; 
            }
        }

    }
}
