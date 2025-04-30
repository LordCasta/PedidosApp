using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp_JuanPablo
{
    public partial class ListadoForm : Form
    {
        public ListadoForm()
        {
            InitializeComponent();
            LlenarDataGridView();
            LlenarComboBox();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var pedidos = ObtenerPedidosViewModel();
            string producto = cmbFiltrarCategoria.Text;
            pedidos = pedidos
                .Where(p => p.Producto == producto)
                .ToList();
            dtgPedidos.DataSource = pedidos;
        }

        private void LlenarDataGridView()
        {
            var pedidos = ObtenerPedidosViewModel();

            dtgPedidos.DataSource = pedidos;
        }

        public List<PedidoViewModel> ObtenerPedidosViewModel()
        {
            var pedidos = RegistroPedidos.Instancia.Pedidos;
            var pedidosViewModel = new List<PedidoViewModel>();

            foreach (var pedido in pedidos)
            {
                // Asegurarse de que MetodoEntrega no sea null
                var metodoEntrega = pedido.MetodoEntrega != null ? pedido.MetodoEntrega.TipoEntrega() : "N/A";

                pedidosViewModel.Add(new PedidoViewModel
                {
                    Cliente = pedido.Cliente,
                    Producto = pedido.Producto,
                    Urgente = pedido.Urgente,
                    Peso = pedido.Peso,
                    Distancia = pedido.Distancia,
                    MetodoEntrega = metodoEntrega,
                    Precio = pedido.ObtenerCosto().ToString(),

                });
            }

            return pedidosViewModel;
        }

        private void LlenarComboBox()
        {
            #region LlenarComboBox
            cmbFiltrarCategoria.Items.Add("tecnología");
            cmbFiltrarCategoria.Items.Add("accesorio");
            cmbFiltrarCategoria.Items.Add("componente");
            cmbFiltrarCategoria.SelectedIndex = 0;
            #endregion
        }
    }
}
