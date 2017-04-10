using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace ControlInventarioUniversidad
{
    public partial class VerInventario : Form
    {
        AccederBD basedatos = new AccederBD(); //llamar clase base de datos
        public VerInventario()
        {
            InitializeComponent();
            cBcarreras.Text = cBcarreras.Items[0].ToString();//preseleccionada la carrera izquierda
            cBmateria.Text = cBmateria.Items[0].ToString();//preseleccionada la material izquierda
            cBmaterial2.Text = cBmaterial2.Items[0].ToString();//preseleccionada la carrera derecha
            cBcarrera2.Text = cBcarrera2.Items[0].ToString();//preseleccionada la material derecha
        }
        
        private void btnTodoInventario_Click(object sender, EventArgs e)
        {
            dGVinventario.Columns.Clear(); //limpiar columnas antas de uso
            dGVinventario.DataSource = basedatos.ConsultaTodos("inventory_producto"); //consulta a completa
            basedatos.DesconectarDB(); //desconectar base de datos
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            dGVinventario.Columns.Clear(); //limpiar columnas antas de uso
            string carreras = cBcarreras.SelectedItem.ToString(); //carrera seleccionada convertida a string
            dGVinventario.DataSource = basedatos.ConsultaCarrera("inventory_producto", carreras); //consulta a tabla y carreras
            basedatos.DesconectarDB(); //desconectar base de datos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dGVinventario.Columns.Clear(); //limpiar columnas antas de uso
            string material = cBmateria.SelectedItem.ToString(); //material seleccionado convertido a string
            dGVinventario.DataSource = basedatos.ConsultaMaterial("inventory_producto", material); //consulta a tabla y material
            basedatos.DesconectarDB(); //desconectar base de datos
        }

        private void btnCarreraMaterial_Click(object sender, EventArgs e)
        {
            dGVinventario.Columns.Clear(); //limpiar columnas antas de uso
            string material = cBmaterial2.SelectedItem.ToString(); //material seleccionado convertido a string
            string carrera = cBcarrera2.SelectedItem.ToString(); //carrera seleccionada convertida a string
            dGVinventario.DataSource = basedatos.ConsultaCarreraMaterial("inventory_producto",carrera ,material); //consulta a tabla con carrera y material
            basedatos.DesconectarDB(); //desconectar base de datos
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //MySqlConnection d = new MySqlConnection("host=127.0.0.1;uid=root;pwd=moscaslibres;database=inventariouniversidad;"); //local
            MySqlConnection d = new MySqlConnection("Server = MYSQL5013.SmarterASP.NET;Database=db_a14f18_proguth;Uid=a14f18_proguth;Pwd=pr0gCon0"); //nube
            MySqlCommand comando = new MySqlCommand("SELECT nombre, carrera, cantidad, nota FROM inventory_producto", d);
            MySqlDataReader lector;
            d.Open();
            FileStream Fs = new FileStream(@"C:\reportes\reporte inventario.txt", FileMode.Create); //crear archivo
            StreamWriter sw = new StreamWriter(Fs); //manipular directiorio
            lector = comando.ExecuteReader(); //leer base
            while (lector.Read())
            {
                sw.WriteLine(lector.GetString("nombre"));
                sw.WriteLine(lector.GetString("carrera"));
                sw.WriteLine(lector.GetString("cantidad"));
                sw.WriteLine(lector.GetString("nota"));
            }
            lector.Close();
            d.Close();
            sw.Close();
            Fs.Close();
            MessageBox.Show("Exportado");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}