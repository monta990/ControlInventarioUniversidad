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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tBname.Text.Trim()=="" || tBpassword.Text.Trim()=="" || tBUsername.Text.Trim()=="" || tBtipo.Text.Trim()=="") //verificar campos en blanco
            {
                MessageBox.Show("Algun campo esta en blanco verificalo");
                tBUsername.Focus();
            }
            else
            {
                if (tBtipo.Text=="0" || tBtipo.Text=="1" || tBtipo.Text=="2") //verifica si tipo de usuario es correcto
                {
                    try
                    {
                        //int.Parse(tBtipo.Text);
                        AccederBD basedatos = new AccederBD();
                        //basedatos.ConectaDB();
                        if (basedatos.CrearUsuario(int.Parse(tBtipo.Text), tBUsername.Text, tBpassword.Text, tBname.Text) == true) //verifica creación
                        {
                            MessageBox.Show("Agregado Correctamente");
                            tBUsername.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Error: " + AccederBD.Error);
                            tBUsername.Focus();
                        }
                        basedatos.DesconectarDB();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El tipo de usuario es una letra (0-2)");
                        tBtipo.Clear();
                        tBtipo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El tipo de usuario solo puede ser 0, 1 o 2");
                    tBtipo.Clear();
                    tBtipo.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}
