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
    public partial class AltaCliente : Form
    {
        AccesoDatos oBD = new AccesoDatos();
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Nombre = txtNombre.Text;
            if (rbMasculino.Checked)
            {
                c.Sexo = "1";
            }
            else
            {
                c.Sexo = "2";
            }
            c.Codigo = Convert.ToInt32(txtCodigo.Text);



            string insert = "insert into clientes(nombre,sexo,codigo" +
                "values (@nombre,@sexo,@codigo))";

            int filas = oBD.InsertarBD("insert");
            if (filas == 1)
            {
                MessageBox.Show("Se inserto el cliente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGrabar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al insertar el cliente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
