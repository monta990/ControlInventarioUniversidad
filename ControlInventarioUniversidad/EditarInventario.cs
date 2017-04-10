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
    public partial class EditarInventario : Form
    {
        public EditarInventario()
        {
            InitializeComponent();
            cBcarreras.Text = cBcarreras.Items[0].ToString();//preseleccionada la carrera
            cBmateria.Text = cBmateria.Items[0].ToString();//preseleccionada la carrera
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            new VerInventario().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AccederBD basedatos = new AccederBD();
            string seleccion = cBcarreras.SelectedItem.ToString();
            string seleccion2 = cBmateria.SelectedItem.ToString();
            //basedatos.ConectaDB();
            if (basedatos.EditarInventario(seleccion2, seleccion, tBcantidad.Text, rTBnota.Text) == true) //verifica creación
            {
                MessageBox.Show("Editado Correctamente");
            }
            else
            {
                MessageBox.Show("Error: " + AccederBD.Error);
            }
            basedatos.DesconectarDB();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}
