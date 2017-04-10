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
    public partial class AgregarInventario : Form
    {
        public AgregarInventario()
        {
            InitializeComponent();
            cBcarreras.Text = cBcarreras.Items[0].ToString();//preseleccionada la carrera
            cBmateria.Text = cBmateria.Items[0].ToString();//preseleccionada la carrera
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccederBD basedatos = new AccederBD();
            string seleccion = cBcarreras.SelectedItem.ToString(); //selección de carrera a string para agregar a la base de datos
            string seleccion2 = cBmateria.SelectedItem.ToString(); //selección del material a string para agregar a la base de datos
            int cantidad;
            try
            {
                cantidad = int.Parse(tBcantidad.Text); //verifica que cantidad se un numero
                if (basedatos.AgregarInventario(seleccion2, seleccion, cantidad.ToString(), rTBnota.Text) == true) //verifica creación
                {
                    MessageBox.Show("Agregado Correctamente");
                }
                else
                {
                    MessageBox.Show("Error: " + AccederBD.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cantidad no es numerica");
                tBcantidad.Clear();
                tBcantidad.Focus();
            }
            basedatos.DesconectarDB();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            new VerInventario().Show();
        }

        private void linkLabelAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}