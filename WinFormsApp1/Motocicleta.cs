using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Motocicleta : Vehiculo
    {

        public int cantidadPasajeros { get; set; }

        public override void Moverse()
        {
            MessageBox.Show($"La motocicleta está en movimiento con {cantidadPasajeros} pasajeros");
        }
        
    }
}
