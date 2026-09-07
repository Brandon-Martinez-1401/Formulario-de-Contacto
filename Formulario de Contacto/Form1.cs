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
            string Contacto = "";
            if (RbConsulta.Checked)
            {
                Contacto = "Consulta";
            }
            else if (RbSugerencia.Checked)
            {
                Contacto = "Sugerencia";
            }
            else if (RbQueja.Checked)
            {
                Contacto = "Queja";
            }
            else
            {
                MessageBox.Show(
                  "Por favor selecciona el tipo de contacto.",
                   "Validación",
                      MessageBoxButtons.OK,
                          MessageBoxIcon.Warning
                        );
            }
            //=========================================
            // 3.-Recibir el resultado de la validación
            //=========================================
            List<string> Resultado = new List<string>();
            if (chkRespuesta.Checked)
            {
                Resultado.Add("El usuario sí desea recibir respuesta");
            }
            else
            {
                Resultado.Add("El usuario no desea recibir respuesta");
            }

            //======================================
            // 4.- Crear el resumen
            //======================================
            string resumen =
                "RESUMEN DE LA CITA\r\n" +
                "-------------------------\r\n" +
                "Nombre: " + TxtNombre.Text + "\r\n" +
                "Respuesta: " + string.Join(",", Resultado) + "\r\n" +
                "Contacto: " + Contacto;
            TxtResumen.Text = resumen;



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
        "POLÍTICA DE PRIVACIDAD\n\n" +
        "Los datos proporcionados en este formulario " +
        "serán utilizados únicamente para atender su solicitud.",
        "Política de privacidad",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        }
    }
}
