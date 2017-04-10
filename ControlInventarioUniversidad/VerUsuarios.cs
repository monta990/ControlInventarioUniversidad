using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControlInventarioUniversidad
{
    public partial class VerUsuarios : Form
    {
        public VerUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dGVusuarios.Columns.Clear(); //limpiar columnas antas de uso
            AccederBD basedatos = new AccederBD(); //llamar clase base de datos
            dGVusuarios.DataSource = basedatos.ConsultaTodos("inventory_usuario"); //trae la lista de usuarios con sus datos
            basedatos.DesconectarDB(); //desconectar base de datos
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            btnActualizar_Click(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}