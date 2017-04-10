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
    public partial class menu0 : Form
    {
        AccederBD basedatos = new AccederBD();
        public menu0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basedatos.ConectaDB();
            //if (basedatos.Crear("almacen", "nombre,ubicacion,clave", "'Bodega B','Hermosillo','H1'"))
            string test="test";
            if (basedatos.login(test, test) == false)
            {
                MessageBox.Show("Servidor Activo");
            }
            else
            {
                MessageBox.Show("Servidor Caido, "+AccederBD.Error);
            }
            basedatos.DesconectarDB();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CrearUsuario().ShowDialog();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarUsuario().ShowDialog();
        }

        private void editarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AgregarInventario().ShowDialog();
        }

        private void editarInventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new EditarInventario().ShowDialog();
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditarUsuario().ShowDialog();
        }

        private void verInventarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new VerInventario().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }

        private void eliminarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarInventario().ShowDialog();
        }

        private void ayudaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }

        private void verUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new VerUsuarios().ShowDialog();
        }
    }
}
