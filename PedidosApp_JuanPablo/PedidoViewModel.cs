using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp_JuanPablo
{
    public class PedidoViewModel
    {
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public bool Urgente { get; set; }
        public double Peso { get; set; }
        public int Distancia { get; set; }
        public string MetodoEntrega { get; set; }
        public string Precio { get; set; }
    }
}
