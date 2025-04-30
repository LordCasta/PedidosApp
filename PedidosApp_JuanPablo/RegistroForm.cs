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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }
        private void RegistroForm_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = txtCliente.Text;
                string producto = cmbProducto.SelectedItem.ToString();
                bool urgente = chkUrgente.Checked;
                double peso = Convert.ToDouble(nudPeso.Value);
                int distancia = Convert.ToInt32(nudDistancia.Value);
                Pedido pedido = new Pedido(cliente, producto, urgente, peso, distancia);
                RegistroPedidos.Instancia.AgregarPedido(pedido);
                lblResultado.Text = $"Entrega: {pedido.MetodoEntrega.TipoEntrega()} $Costo: ${pedido.ObtenerCosto():0.00}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LlenarComboBox()
        {
            #region LlenarComboBox
            cmbProducto.Items.Add("tecnología");
            cmbProducto.Items.Add("accesorio");
            cmbProducto.Items.Add("componente");
            cmbProducto.SelectedIndex = 0;
            #endregion
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            registroForm.Show();
        }
    }
}
