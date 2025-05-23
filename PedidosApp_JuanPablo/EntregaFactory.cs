﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosApp_JuanPablo
{
    public class EntregaFactory
    {
        public static IMetodoEntrega CrearEntrega(string tipoProducto, bool urgente, double peso)
        {
            if (tipoProducto == "tecnología" && urgente)
                return new EntregaDron();
            else if (tipoProducto == "accesorio" && urgente)
                return new EntregaMoto();
            else if (tipoProducto == "componente" || peso > 10)
                return new EntregaCamion();
            else if (tipoProducto == "accesorio")
                return new EntregaBicicleta();
            else
                return new EntregaMoto(); // valor por defecto
        }
    }
}
