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

namespace SistemaDeInventarios.Ventanas
{
    public partial class wf_insertar_nuevo_proveedor : Form
    {

    public wf_insertar_nuevo_proveedor(PgSqlConnection p_conexion)
        {
            InitializeComponent();
            pro_conexion = p_conexion;
        }

        #region EVENTOS

        public event EventHandler on_ProveedorAgregado; //evento personalizado


        #endregion

        #region BOTONES
        private void btn_guardar_grupo_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM public.ft_insert_nuevo_proveedor (
                                                                              :p_nombre_proveedor
                                                                            )";

            PgSqlCommand pg_comando = new PgSqlCommand(query, pro_conexion);
            pg_comando.Parameters.Add("p_nombre_proveedor", PgSqlType.VarChar).Value = txt_nuevo_proveeor.Text; // solo si hay parametros en la funcion sql

            try
            {
                pg_comando.ExecuteNonQuery(); //executenonquery cuando no necesitamos retornar un valor
                MessageBox.Show("Proveedor guardado con exito.");
                txt_nuevo_proveeor.Clear();
                on_ProveedorAgregado?.Invoke(new object(), new EventArgs());  //invocacion del evento personalizado

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
        }


        #endregion

        #region PROPIEDADES
        public PgSqlConnection pro_conexion { get; set; }

        #endregion

    }
}
