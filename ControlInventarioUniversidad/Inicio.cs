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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AccederBD basedatos = new AccederBD();
            if (basedatos.login(tBusuario.Text, tBpass.Text) == true) //verifica estado de acceso para el error
            {
                //Sin Acciones ya que accedio correctamente
            }
            else
            {
                MessageBox.Show("Error: " + AccederBD.Error); //especifica el error
            }
            basedatos.DesconectarDB();
        }

        private void button2_Click(object sender, EventArgs e) //boton salir
        {
            DialogResult dialog = MessageBox.Show("Quieres salir del sistema", "Cerrar el programa", MessageBoxButtons.YesNo); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}