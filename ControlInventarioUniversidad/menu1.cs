using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventarioUniversidad
{
    public partial class menu1 : Form
    {
        public menu1()
        {
            InitializeComponent();
        }

        private void editarInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EditarInventario().ShowDialog();
        }

        private void editarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarInventario().ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //verifica servidor
        {
            AccederBD basedatos = new AccederBD();
            basedatos.ConectaDB();
            string test = "test";
            if (basedatos.login(test, test) == false)
            {
                MessageBox.Show("Servidor Activo");
            }
            else
            {
                MessageBox.Show("Servidor Caido");
            }
            basedatos.DesconectarDB();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void verInventarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new VerInventario().ShowDialog();
        }

        private void eliminarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarInventario().Show();
        }

        private void ayudaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}