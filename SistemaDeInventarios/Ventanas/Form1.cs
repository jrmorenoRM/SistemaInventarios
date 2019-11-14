using Devart.Data.PostgreSql;
using Npgsql;
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


        public PgSqlConnection pro_conexion { get; set; }


        public Form1(PgSqlConnection p_conexion)
        {
            InitializeComponent();
            pro_conexion = p_conexion;
            
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

            bool v_resultado;
            string sentencia = @"SELECT * FROM public.ft_login_sistema (
                                                                        :p_usuario,
                                                                        :p_contrasena
                                                                        )";
             
            
            if (pro_conexion.State != ConnectionState.Open)
            {
                pro_conexion.Open();
            }

           

            PgSqlCommand v_comando = new PgSqlCommand(sentencia, pro_conexion);
            v_comando.Parameters.Add("p_usuario", NpgsqlTypes.NpgsqlDbType.Varchar).Value = txtusuario.Text;
            v_comando.Parameters.Add("p_contrasena", NpgsqlTypes.NpgsqlDbType.Varchar).Value = txtpass.Text;

            try
            {
                v_resultado = Convert.ToBoolean(v_comando.ExecuteScalar());


                if (v_resultado)
                {
                    MessageBox.Show("Bienvenido");
                    this.Close();
                }else
                {
                    MessageBox.Show("Error de usuario o contraseña");
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }



        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

    }


}
