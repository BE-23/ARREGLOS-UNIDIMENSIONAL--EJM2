namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        int[] edades = new int[5];
        int posicion = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void Salir()
        {
            Application.Exit();
        }
        void Limpiar()
        {
            txtedad.Clear();
        }
        void Registrar()
        {
            if (posicion < edades.Length)
            {
                edades[posicion] = int.Parse(txtedad.Text);
                MessageBox.Show("Se registro correcamente");
                posicion++;
                VerEdades();
                Resumen();
            }
            else
            {
                MessageBox.Show("Se alcanzo el limite de registros");
            }
        }
        void VerEdades()
        {
            lstsalida.Items.Clear();
            for (int i = 0; i < posicion; i++)
            {
                lstsalida.Items.Add(edades[i]);
            }
        }
        void Resumen()
        {

            lblcantidadedades.Text = posicion.ToString();
            string listaEdades = "";
            for (int i = 0; i < posicion; i++)
            {
                listaEdades = listaEdades + edades[i] + "," ;
            }

            lbledadesregistradas.Text = listaEdades;
        }

        private void bttlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bttsalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void bttregistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        private void bttveredades_Click(object sender, EventArgs e)
        {

        }

        private void lblcantidad_Click(object sender, EventArgs e)
        {

        }
    }
}
