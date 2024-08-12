namespace Tarea___Introducción_al_diseñador_de_formularios
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

        private void ButtonLimpiar(object sender, EventArgs e)
        {

            LimpiarCampos();
            LabelEstado.Text = "Campos limpiados.";
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
        }

        private void ButtonAgregar(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBoxNombre.Text) &&
                !string.IsNullOrWhiteSpace(textBoxTelefono.Text) &&
                !string.IsNullOrWhiteSpace(textBoxCorreo.Text))
            {

                string contacto = $"{textBoxNombre.Text} - {textBoxTelefono.Text} - {textBoxCorreo.Text}";


                listBox1.Items.Add(contacto);


                LabelEstado.Text = "Contacto agregado.";


                LimpiarCampos();
            }
            else
            {
                LabelEstado.Text = "Completa todos los campos.";
            }
        }
    }
}


    

