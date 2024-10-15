using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    abstract class Vehiculo : ITransporte
    {
        public string Marca {  get; set; }
        public string Modelo { get; set; }

        public void Detenerse()
        {
            MessageBox.Show($"El vehiculo {Marca} {Modelo} se ha detenido");
        }

        public void Iniciar()
        {
            MessageBox.Show($"El vehiculo {Marca} {Modelo} está listo para su uso");
        }

        public abstract void Moverse();
    }
}
