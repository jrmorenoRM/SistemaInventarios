using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventarios
{
    public partial class Form1 : Form
    {
        private string Pro_BaseDatos
        {
            get
            {
                return ConfigurationSettings.AppSettings["nombre_bd"];
            }
        }

        private string Pro_Usuario
        {
            get
            {
                return ConfigurationSettings.AppSettings["usser_bd"];
            }
        }

        private string Pro_pass
        {
            get
            {
                return ConfigurationSettings.AppSettings["password_bd"];
            }
        }

        private string Pro_host
        {
            get
            {
                return ConfigurationSettings.AppSettings["host_bd"];
            }
        }

        private string Pro_puerto
        {
            get
            {
                return ConfigurationSettings.AppSettings["puerto_bd"];
            }
        }

        PgSqlConnection pgConexion; //variable global conexion

        public Form1()
        {
            InitializeComponent();
            Conexion_DB();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnenter_Click(object sender, EventArgs e)
        {

              this.Hide();



      

    }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Conexion_DB()
        {
            StringBuilder v_cadena_conexion = new StringBuilder();
            v_cadena_conexion.Append("User Id=");
            v_cadena_conexion.Append(Pro_Usuario);
            v_cadena_conexion.Append(";Password=");
            v_cadena_conexion.Append(Pro_pass);
            v_cadena_conexion.Append(";Host=");
            v_cadena_conexion.Append(Pro_host);
            v_cadena_conexion.Append(";Database=");
            v_cadena_conexion.Append(Pro_BaseDatos);
            v_cadena_conexion.Append(";Port=");
            v_cadena_conexion.Append(Pro_puerto);

            string v_cadena = v_cadena_conexion.ToString();

            pgConexion = new PgSqlConnection(v_cadena);

            try
            {
               
                if (pgConexion.State != ConnectionState.Open)
                {
                    pgConexion.Open();
                }



            }
            catch (Exception e)
            {
            }
        }

    }


}
