using System.Drawing;
using System.Windows.Forms;

namespace PedidosApp_JuanPablo
{
    partial class RegistroForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCliente = new TextBox();
            label2 = new Label();
            cmbProducto = new ComboBox();
            label3 = new Label();
            chkUrgente = new CheckBox();
            label4 = new Label();
            nudPeso = new NumericUpDown();
            label5 = new Label();
            nudDistancia = new NumericUpDown();
            btnCalcular = new Button();
            lblResultado = new Label();
            linkLabel1 = new LinkLabel();
            btnNewForm = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente: ";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(81, 69);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(196, 23);
            txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Categoría: ";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(91, 123);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(224, 23);
            cmbProducto.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "¿Urgente?";
            // 
            // chkUrgente
            // 
            chkUrgente.AutoSize = true;
            chkUrgente.Location = new Point(91, 184);
            chkUrgente.Name = "chkUrgente";
            chkUrgente.Size = new Size(35, 19);
            chkUrgente.TabIndex = 5;
            chkUrgente.Text = "Sí";
            chkUrgente.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 234);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 6;
            label4.Text = "Peso del producto";
            // 
            // nudPeso
            // 
            nudPeso.Location = new Point(136, 232);
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(120, 23);
            nudPeso.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 281);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 8;
            label5.Text = "Distancia en kilómetros";
            // 
            // nudDistancia
            // 
            nudDistancia.Location = new Point(157, 279);
            nudDistancia.Name = "nudDistancia";
            nudDistancia.Size = new Size(120, 23);
            nudDistancia.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 325);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(23, 405);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(16, 15);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "...";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(572, 71);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 12;
            // 
            // btnNewForm
            // 
            btnNewForm.Location = new Point(23, 471);
            btnNewForm.Name = "btnNewForm";
            btnNewForm.Size = new Size(75, 23);
            btnNewForm.TabIndex = 13;
            btnNewForm.Text = "Ir a listarlos";
            btnNewForm.UseVisualStyleBackColor = true;
            btnNewForm.Click += btnNewForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 567);
            Controls.Add(btnNewForm);
            Controls.Add(linkLabel1);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(nudDistancia);
            Controls.Add(label5);
            Controls.Add(nudPeso);
            Controls.Add(label4);
            Controls.Add(chkUrgente);
            Controls.Add(label3);
            Controls.Add(cmbProducto);
            Controls.Add(label2);
            Controls.Add(txtCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCliente;
        private Label label2;
        private ComboBox cmbProducto;
        private Label label3;
        private CheckBox chkUrgente;
        private Label label4;
        private NumericUpDown nudPeso;
        private Label label5;
        private NumericUpDown nudDistancia;
        private Button btnCalcular;
        private Label lblResultado;
        private LinkLabel linkLabel1;
        private Button btnNewForm;
    }
}