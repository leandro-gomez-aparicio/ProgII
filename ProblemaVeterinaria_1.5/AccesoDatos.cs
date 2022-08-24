using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProblemaVeterinaria_1._5
{
    internal class AccesoDatos
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string cadenaConexion = @"Data Source=DESKTOP-33JGS32;Initial Catalog=Veterinaria;Integrated Security=True";
    
        public AccesoDatos()
        {
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
        }
        public void Conectar()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            //cmd.CommandType = CommandType.StoredProcedure;
        }

        public void Desconectar()
        {
            cnn.Close();
        }
        public DataTable ConsultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            Conectar();
            cmd.CommandText = consultaSQL;
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;

            //con store procedure
            //DataTable tabla = new DataTable();
            //Conectar();
            //cmd.CommandText = sp;
            //tabla.Load(cmd.ExecuteReader());
            //Desconectar();
            //return tabla;

        }
        public int InsertarBD(string consultaSQL)
        {
            int filasAfectadas;
            Conectar();
            cmd.CommandText = consultaSQL;
            filasAfectadas = cmd.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;

            //con store procedure
            //int filasAfectadas;
            //Conectar();
            //cmd.CommandText = sp;
            //cmd.Parameters.AddWithValue("@nombre",txtNombre);
            //filasAfectadas = cmd.ExecuteNonQuery();
            //Desconectar();
            //return filasAfectadas;

        }
    }
}
