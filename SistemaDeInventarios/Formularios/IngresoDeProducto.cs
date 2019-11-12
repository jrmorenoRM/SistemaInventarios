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
    public partial class IngresoDeProducto : Form
    {

        public PgSqlConnection pro_conexion { get; set; } 
        public IngresoDeProducto(PgSqlConnection p_conexion)
        {
            InitializeComponent();
            pro_conexion = p_conexion;
        }

   

        private void Button1_Click(object sender, EventArgs e)
        {

            string query = @"SELECT * FROM public.ft_insert_nuevo_producto_detalle (
                                                                                      :p_nombre_producto
                                                                                    )";

            PgSqlCommand pg_comando = new PgSqlCommand(query, pro_conexion);
            pg_comando.Parameters.Add("p_nombre_producto", PgSqlType.VarChar).Value = txtnuevoproducto.Text; // solo si hay parametros en la funcion sql

            try
            {
                pg_comando.ExecuteNonQuery(); //executenonquery cuando no necesitamos retornar un valor
                MessageBox.Show("producto guardado con exito.");
                txtnuevoproducto.Clear();
            


            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }



        }
        public event EventHandler onIngresoGrupo;
        public event EventHandler onIngresoProducto;
    }


       
    }

