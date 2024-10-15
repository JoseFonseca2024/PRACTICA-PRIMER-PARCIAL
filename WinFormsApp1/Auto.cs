using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    sealed class Auto : Vehiculo
    {
        public int cantidadPasajeros { get; set; }


        public override void Moverse()
        {
            MessageBox.Show($"El auto esta en movimiento con {cantidadPasajeros} pasajeros");
        }
    }
}
