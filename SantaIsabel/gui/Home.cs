using SantaIsabel.gui;
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

namespace SantaIsabel
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.TelaUsuario == null)
                Formularios.TelaUsuario = new Usuarios();

            Formularios.TelaUsuario.Show();
            Formularios.TelaUsuario.Focus();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.TelaCliente == null)
                Formularios.TelaCliente = new Clientes();

            Formularios.TelaCliente.Show();
            Formularios.TelaCliente.Focus();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Formularios.TelaFuncionario == null)
                Formularios.TelaFuncionario = new Funcionarios();

            Formularios.TelaFuncionario.Show();
            Formularios.TelaFuncionario.Focus();
        }
    }
}
