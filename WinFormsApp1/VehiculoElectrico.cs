using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class VehiculoElectrico : Vehiculo, IVehiculoElectrico
    {
        public int capacidaddeBateria {  get; set; }

        public void CargarBateria()
        {
            MessageBox.Show("Cargando bateria...");
            MessageBox.Show("Bateria cargada");
        }

        public override void Moverse()
        {
            MessageBox.Show($"Vehiculo electrico se está moviendo, carga actual: {capacidaddeBateria}% ");
        }
    }
}
