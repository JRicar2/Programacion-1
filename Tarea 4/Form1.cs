using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tarea_4
{
    public partial class Form1 : Form
    {
        string Nombre, Apellido, Fecha, Residencia, Escolaridad, Carrera;
        int Edad;
        double Salario, Seguro, Impuestos, Gastos, Totalgral;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Capturando los datos y convirtiendo de ser necesario
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            Edad = int.Parse(txtEdad.Text);
            Fecha = txtFecha.Text;
            Salario = Convert.ToDouble(txtSalario.Text);
            Residencia = txtResidencia.Text;
            Escolaridad = txtEscolaridad.Text;
            Carrera = txtCarrera.Text;

            //Calculando los porcentajes
            Seguro = (3 * Salario) / 100;
            Impuestos = (5 * Salario) / 100;
            Gastos = (10 * Salario) / 100;

            //Restando los porcentajes para obtener el Total General
            Totalgral = Salario - Seguro - Impuestos - Gastos;


            //Messagebox de prueba para comprobar el Total General
            MessageBox.Show("Total General: " + Totalgral);
        }

        //Boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }






















        //Eventos
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
            }
        }


        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "Edad")
            {
                txtEdad.Text = "";
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "Edad";
            }
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "Fecha de Nacimiento")
            {
                txtFecha.Text = "";
            }
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            if (txtFecha.Text == "")
            {
                txtFecha.Text = "Fecha de Nacimiento";
            }
        }

        private void txtSalario_Enter(object sender, EventArgs e)
        {
            if (txtSalario.Text == "Salario")
            {
                txtSalario.Text = "";
            }
        }

        private void txtSalario_Leave(object sender, EventArgs e)
        {
            if (txtSalario.Text == "")
            {
                txtSalario.Text = "Salario";
            }
        }

        private void txtResidencia_Enter(object sender, EventArgs e)
        {
            if (txtResidencia.Text == "Lugar de Residencia")
            {
                txtResidencia.Text = "";
            }
        }

        private void txtResidencia_Leave(object sender, EventArgs e)
        {
            if (txtResidencia.Text == "")
            {
                txtResidencia.Text = "Lugar de Residencia";
            }
        }

        private void txtEscolaridad_Enter(object sender, EventArgs e)
        {
            if (txtEscolaridad.Text == "Nivel de Escolaridad")
            {
                txtEscolaridad.Text = "";
            }
        }

        private void txtEscolaridad_Leave(object sender, EventArgs e)
        {
            if (txtEscolaridad.Text == "")
            {
                txtEscolaridad.Text = "Nivel de Escolaridad";
            }
        }

        private void txtCarrera_Enter(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "Carrera que Estudia")
            {
                txtCarrera.Text = "";
            }
        }

        private void txtCarrera_Leave(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                txtCarrera.Text = "Carrera que Estudia";
            }
        }


        //script para arrastrar ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

    }
}
