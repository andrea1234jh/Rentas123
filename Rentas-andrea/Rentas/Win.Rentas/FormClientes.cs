using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormClientes : Form
    {
        ClientesBL _clientes;

        public FormClientes()
        {
            InitializeComponent();

            _clientes = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientes.ObtenerClientes();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;
            var resultado = _clientes.GuardarCliente(cliente);
           
            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                deshabilitraHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show("Ocurrio un error guardandno cliente");
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listaClientesBindingSource.MoveLast();

            deshabilitraHabilitarBotones(false);
        }

        private void deshabilitraHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;

            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;

            toolStripButtonCaancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var id = Convert.ToInt32(idTextBox.Text);
                eliminar(id);
            }
            
        }

        private void eliminar(int id)
        {
            var resultado = _clientes.eliminarCliente(id);

            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar Cliente");
            }
        }

        private void toolStripButtonCaancelar_Click(object sender, EventArgs e)
        {
            deshabilitraHabilitarBotones(true);
            eliminar(0);
        }
    }
}
