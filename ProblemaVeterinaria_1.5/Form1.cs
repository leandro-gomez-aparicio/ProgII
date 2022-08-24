using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemaVeterinaria_1._5
{
    public partial class Form1 : Form
    {
        /*desarrollar un
        programa que permita las atenciones de una mascota indicando para cada una la
        descripción de los tratamientos y/o vacunas aplicadas.*/
        AccesoDatos oBD= new AccesoDatos();
        public Form1()
        {
            InitializeComponent();
            CargarLista();
            Habilitar(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        public void CargarLista()
        {
            lstClientes.Items.Clear();
            DataTable tabla = oBD.ConsultarBD("SELECT * FROM CLIENTES");
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.Nombre = fila["nombre"].ToString();
                c.Sexo = fila["sexo"].ToString();
                c.Codigo = Convert.ToInt32(fila["codigo"].ToString());
                //c.Mascota = new Mascota();
                lstClientes.Items.Add(c.ToString());
            }
        }
        //public void CargarCombo()
        //{
        //    DataTable tabla = oBD.ConsultarBD("SELECT * FROM MASCOTAS");
        //    cboMascota.DataSource = tabla;
        //    cboMascota.DisplayMember = "nombre";
        //    cboMascota.ValueMember = "codigo";
        //    cboMascota.DropDownStyle = ComboBoxStyle.DropDownList;
        //}
        public void Habilitar(bool x)
        {
            txtNombre.Enabled = x;
            lstClientes.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnGuardar.Enabled = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCliente a1 = new AltaCliente();
            a1.Show();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
