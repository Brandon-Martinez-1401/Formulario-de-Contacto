namespace Formulario_de_Contacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtbEnviar_Click(object sender, EventArgs e)
        {
            //====================================
            // 1.- VALIDAR EL NOMBRE
            //====================================
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show(
                  "Por favor escribe tu nombre.",
                   "Validación",
                      MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
                TxtNombre.Focus();
            }
            //====================================
            // 2.- SLLECCIONAR LA CONULTA
            //====================================
            string Consulta = "";
            if (RbConsulta.Checked)
            {
                Consulta = 
            }



        }
    }
}
