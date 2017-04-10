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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seguro que decea eliminar al usuario seleccionado?", "Eliminar usuario", MessageBoxButtons.YesNo); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                AccederBD basedatos = new AccederBD();
                //basedatos.ConectaDB();
                if (basedatos.EliminarUsuario(tBUsername.Text) == true) //verifica elimación
                {
                    MessageBox.Show("Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("Fallo Al Eliminar" + AccederBD.Error);
                    //MessageBox.Show("Error: " + AccederBD.Error);
                    tBUsername.Focus();
                }
                basedatos.DesconectarDB();
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerUsuario_Click(object sender, EventArgs e)
        {
            new VerUsuarios().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}
