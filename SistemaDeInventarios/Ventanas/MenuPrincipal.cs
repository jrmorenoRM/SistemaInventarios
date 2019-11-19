using Devart.Data.PostgreSql;
using SistemaDeInventarios.Ventanas;
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
    public partial class MenuPrincipal : Form
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

        public PgSqlConnection pgConexion; //variable global conexion

        public MenuPrincipal()
        {
            InitializeComponent();
            Conexion_DB();

            TIPOS_AMBIENTE v_tipo_ambiente = (TIPOS_AMBIENTE) Convert.ToInt32(ConfigurationSettings.AppSettings["TIPO_AMBIENTE"]);
            switch (v_tipo_ambiente)
            {
                case TIPOS_AMBIENTE.PRUEBA:
                    break;
                case TIPOS_AMBIENTE.PRODUCCION:
                    Form1 frmLogin = new Form1(pgConexion);
                    frmLogin.MdiParent = this;
                    frmLogin.Show();
                    break;
                   
            }

           


            MdiClient ctlMDI;
          
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    
                    ctlMDI = (MdiClient)ctl;                   
                    ctlMDI.BackColor = Color.White; 
                    
                }
                catch (InvalidCastException exc)
                {
                    
                }
            }

        }

        public enum TIPOS_AMBIENTE
        {
            PRUEBA = 1,
            PRODUCCION = 2
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (panelSeleccion.Width == 292)
            {
                panelSeleccion.Width = 56;
            }
            else
            {
                panelSeleccion.Width = 292;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IngresoDeProductos vingresoDeProductos = new IngresoDeProductos(pgConexion);
            vingresoDeProductos.MdiParent = this;
            vingresoDeProductos.Show();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ControlDeUsuarios v_controldeusuarios = new ControlDeUsuarios();
            v_controldeusuarios.MdiParent = this;
            v_controldeusuarios.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {

            wf_crear_nuevo_proveedor v_controldeusuarios = new wf_crear_nuevo_proveedor(pgConexion);
            v_controldeusuarios.MdiParent = this;
            v_controldeusuarios.Show();

        }
    }
}
