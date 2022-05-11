namespace Biblioteca_Ingresar_Autores
{
    public partial class Form1 : Form
    {
        Autor myAutor = new Autor();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            //Validar que se ingrese un Dato.
            if (txtNombre.Text == "" ) 
            {
                error1.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "" );

            if (txtApellido.Text == "")
            {
                error1.SetError(txtApellido, "Debe ingresar un Apellido");
                txtApellido.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            if (txtNacionalidad.Text == "")
            {
                error1.SetError(txtNacionalidad, "Debe ingresar un nombre");
                txtNacionalidad.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            //validar que solo permita ingresar datos numericos.

            DateTime FechaDeNacimiento;
            if (!DateTime.TryParse(txtFechaDeNacimiento.Text, out DateTime dt))
            {
                error1.SetError(txtFechaDeNacimiento, "Debe ingresar una fecha");
                txtFechaDeNacimiento.Focus();
                return;
            }
            error1.SetError(txtFechaDeNacimiento, "" );

           

            myAutor.Nombre = txtNombre.Text;
            myAutor.Apellido = txtApellido.Text;
            myAutor.Nacionalidad = txtNacionalidad.Text;
            myAutor.FechaDeNacimiento = Convert.ToDateTime(txtFechaDeNacimiento.Text);
            MessageBox.Show("Se guardó el registro correctamente");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtNacionalidad.Clear();
            txtFechaDeNacimiento.Clear();
        }
    }
}