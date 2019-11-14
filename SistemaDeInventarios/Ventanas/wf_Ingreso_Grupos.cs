using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeInventarios
{
    public partial class wf_Ingreso_Grupos : Form
    {
        public PgSqlConnection pro_conexion { get; set; }

        public wf_Ingreso_Grupos(PgSqlConnection p_conexion)
        {

            InitializeComponent();
            pro_conexion = p_conexion;
        }

        private void Txt_nuevo_grupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_grupo_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM public.ft_insert_grupo_producto (
                                                                            :p_grupo_producto
                                                                            )";  

            PgSqlCommand pg_comando = new PgSqlCommand(query, pro_conexion);
            pg_comando.Parameters.Add("p_grupo_producto",PgSqlType.VarChar).Value = txt_nuevo_grupo.Text; // solo si hay parametros en la funcion sql

            try
            {
                pg_comando.ExecuteNonQuery(); //executenonquery cuando no necesitamos retornar un valor
                MessageBox.Show("Grupo guardado con exito.");
                txt_nuevo_grupo.Clear();
                on_GrupoAgregado?.Invoke(new object(),new EventArgs());  //invocacion del evento

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);
               
            }

           
        }


        #region EVENTOS

        public event EventHandler on_GrupoAgregado;


        #endregion

    }
}
