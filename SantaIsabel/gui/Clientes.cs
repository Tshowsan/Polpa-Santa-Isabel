using SantaIsabel.DAL;
using SantaIsabel.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantaIsabel.gui
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.clienteBindingSource.DataSource = DataFactory.DataContex.Clientes;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.AddNew();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.clienteBindingSource.CancelEdit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.ValidaCampos()) {
            this.clienteBindingSource.EndEdit();
            DataFactory.DataContex.SubmitChanges();
            MessageBox.Show("Cadastrado com Sucesso");
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("dejesa Excluir", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.clienteBindingSource.RemoveCurrent();
                DataFactory.DataContex.SubmitChanges();
                MessageBox.Show("Removido com Sucesso");
            }
         }

        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.TelaCliente = null;
        }

        private bool ValidaCampos()
        {
            if (textNome.Text.Trim() == string.Empty)
            {
                MessageBox.Show("campo nome é obrigatório");
                textNome.Focus();
                return false;
            }
            else if (textTelefone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("campo telefone é obrigatório");
                textTelefone.Focus();
                return false;
            }
            else if (textEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("campo email é obrigatório");
                textEmail.Focus();
                return false;
            }

            return true;
        }

    }
}
