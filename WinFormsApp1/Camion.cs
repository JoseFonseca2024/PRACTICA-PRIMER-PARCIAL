using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Camion : Vehiculo
    {
        public double capacidaddeCarga { get; set; }

        public override void Moverse()
        {
            MessageBox.Show($"Camión listo con una carga de {capacidaddeCarga} kilogramos");
        }
    }
}
