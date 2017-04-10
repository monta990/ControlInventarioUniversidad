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
    public partial class EliminarInventario : Form
    {
        public EliminarInventario()
        {
            InitializeComponent();
            cBcarreras.Text = cBcarreras.Items[0].ToString();//preseleccionada la carrera
            cBmateria.Text = cBmateria.Items[0].ToString();//preseleccionada el material
        }
        AccederBD basedatos = new AccederBD();
        private void btnInventario_Click(object sender, EventArgs e)
        {
            new VerInventario().Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Seguro que decea eliminar el material seleccionado?", "Eliminar material", MessageBoxButtons.YesNo); //confima eliminación
            if (dialog == DialogResult.Yes)
            {
                string carrera = cBcarreras.SelectedItem.ToString();
                string material = cBmateria.SelectedItem.ToString();
                //basedatos.ConectaDB();
                if (basedatos.EliminarInventario(material, carrera) == true) //verifica creación
                {
                    MessageBox.Show("Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error: " + AccederBD.Error);
                }
                basedatos.DesconectarDB();
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}
