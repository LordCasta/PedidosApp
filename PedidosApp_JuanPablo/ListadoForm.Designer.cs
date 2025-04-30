using System.Drawing;
using System.Windows.Forms;

namespace PedidosApp_JuanPablo
{
    partial class ListadoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgPedidos = new DataGridView();
            cmbFiltrarCategoria = new ComboBox();
            label1 = new Label();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPedidos).BeginInit();
            SuspendLayout();
            // 
            // dtgPedidos
            // 
            dtgPedidos.AllowUserToDeleteRows = false;
            dtgPedidos.AllowUserToOrderColumns = true;
            dtgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPedidos.Location = new Point(33, 23);
            dtgPedidos.Name = "dtgPedidos";
            dtgPedidos.ReadOnly = true;
            dtgPedidos.Size = new Size(322, 338);
            dtgPedidos.TabIndex = 0;
            // 
            // cmbFiltrarCategoria
            // 
            cmbFiltrarCategoria.FormattingEnabled = true;
            cmbFiltrarCategoria.Location = new Point(565, 23);
            cmbFiltrarCategoria.Name = "cmbFiltrarCategoria";
            cmbFiltrarCategoria.Size = new Size(144, 23);
            cmbFiltrarCategoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 26);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Categoría";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(581, 75);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFiltrar);
            Controls.Add(label1);
            Controls.Add(cmbFiltrarCategoria);
            Controls.Add(dtgPedidos);
            Name = "RegistroForm";
            Text = "RegistroForm";
            ((System.ComponentModel.ISupportInitialize)dtgPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgPedidos;
        private ComboBox cmbFiltrarCategoria;
        private Label label1;
        private Button btnFiltrar;
    }
}