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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AccederBD basedatos = new AccederBD();
            //basedatos.ConectaDB();
            if (basedatos.EditarUsuario(tBUsername.Text, tBpassword.Text) == true) //verifica creación
            {
                MessageBox.Show("Cambiada Correctamente");
            }
            else
            {
                MessageBox.Show("Error: " + AccederBD.Error);
                tBUsername.Focus();
            }
            basedatos.DesconectarDB();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}
