namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private Vehiculo vehiculoactual;

        public Form1()
        {
            InitializeComponent();
            //Seleccionar las opciones programadas en el diseño
            cboTipodeVehiculo.SelectedIndex = 0;
        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }

        private void cboTipodeVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboTipodeVehiculo.SelectedItem.ToString() == "Auto" || cboTipodeVehiculo.SelectedItem.ToString() == "Motocicleta")
            {
                lblPasajeros.Visible = true;
                txtPasajeros.Visible = true;
            }
            else
            {
                lblPasajeros.Visible = false;
                txtPasajeros.Visible = false;
            }


            if (cboTipodeVehiculo.SelectedItem.ToString() == "Camión")
            {
                lblCapacidad.Visible = true;
                txtCarga.Visible = true;
            }
            else
            {
                lblCapacidad.Visible = false;
                txtCarga.Visible = false;
            }

            if (cboTipodeVehiculo.SelectedItem.ToString() == "Vehiculo Electrico")
            {
                lblBateria.Visible = true;
                txtBateria.Visible = true;
                btnCargar.Visible = true;
            }
            else
            {
                lblBateria.Visible = false;
                txtBateria.Visible = false;
                btnCargar.Visible = false;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtMarca.Text) || (lblPasajeros.Visible && string.IsNullOrWhiteSpace(txtPasajeros.Text)) || (lblCapacidad.Visible && string.IsNullOrWhiteSpace(txtCarga.Text)) || (lblBateria.Visible && string.IsNullOrWhiteSpace(txtBateria.Text)))
            {
                MessageBox.Show("Por favor, rellene los parámetros necesarios.");
            }
            else
            {
                SeleccionarVehiculo();
                MessageBox.Show("Vehiculo agregado");

                vehiculoactual.Marca = txtMarca.Text;
                vehiculoactual.Modelo = txtModelo.Text;


            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoactual.Moverse();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoactual.Iniciar();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            vehiculoactual.Detenerse();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            SeleccionarVehiculo();
            (vehiculoactual as VehiculoElectrico)?.CargarBateria();
        }

        private void SeleccionarVehiculo()
        {
            string seleccion = cboTipodeVehiculo.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Auto":
                    vehiculoactual = new Auto();
                    Auto auto = (Auto)vehiculoactual;
                    auto.Marca = txtMarca.Text;
                    auto.Modelo = txtModelo.Text;
                    auto.cantidadPasajeros = int.Parse(txtPasajeros.Text);  
                    break;

                case "Motocicleta":
                    vehiculoactual = new Motocicleta();
                    Motocicleta motocicleta = (Motocicleta)vehiculoactual;
                    motocicleta.Marca = txtMarca.Text;
                    motocicleta.Modelo = txtModelo.Text;
                    motocicleta.cantidadPasajeros = int.Parse(txtPasajeros.Text);  
                    break;

                case "Camión":
                    vehiculoactual = new Camion();
                    Camion camion = (Camion)vehiculoactual;
                    camion.Marca = txtMarca.Text;
                    camion.Modelo = txtModelo.Text;
                    camion.capacidaddeCarga = double.Parse(txtCarga.Text);  
                    break;

                case "Vehiculo Electrico":
                    vehiculoactual = new VehiculoElectrico();
                    VehiculoElectrico electrico = (VehiculoElectrico)vehiculoactual;
                    electrico.Marca = txtMarca.Text;
                    electrico.Modelo = txtModelo.Text;
                    electrico.capacidaddeBateria = int.Parse(txtBateria.Text);  
                    break;

                default:
                    MessageBox.Show("Seleccione un tipo de vehículo.");
                    break;
            }
        }

    
    }
}

