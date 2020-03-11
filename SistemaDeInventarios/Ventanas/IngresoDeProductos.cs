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
    public partial class IngresoDeProductos : Form
    {

        public PgSqlConnection pro_conexion { get; set; }

        
        public IngresoDeProductos(PgSqlConnection p_conexion)
        {
            InitializeComponent();
            pro_conexion = p_conexion;
            CargarGrupoPruductos();
        }

       

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            int combodetalleproducto = (int)comboGrupoSeleccionado.SelectedValue;  //extraer id de combobox de detalle con "Selectedvalue"


            string query = @"SELECT * FROM public.ft_insert_nuevo_producto_detalle (
                                                                                    :p_nombre_producto,
                                                                                    :p_id_de_grupo,
                                                                                    :p_codigo_barras
                                                                                                        )";

            PgSqlCommand pg_comando = new PgSqlCommand(query, pro_conexion);
            pg_comando.Parameters.Add("p_id_de_grupo", PgSqlType.Int).Value = combodetalleproducto;
            pg_comando.Parameters.Add("p_nombre_producto", PgSqlType.VarChar).Value = txt_nombre_nuevo_producto.Text; // solo si hay parametros en la funcion sql
            pg_comando.Parameters.Add("p_codigo_barras", PgSqlType.VarChar).Value = txt_codigo_de_barras.Text;

            try
                   {
                       pg_comando.ExecuteNonQuery(); //executenonquery cuando no necesitamos retornar un valor
                       MessageBox.Show("Producto guardado con exito.");
                       txt_nombre_nuevo_producto.Clear();
                       txt_codigo_de_barras.Clear();

                    }
                   catch (Exception ex)

                   {

                       MessageBox.Show(ex.Message);

                   }
        }




        private void PictureBox1_Click(object sender, EventArgs e)
        {
            wf_Ingreso_Grupos wf_ingreso = new wf_Ingreso_Grupos(pro_conexion);
            wf_ingreso.on_GrupoAgregado += wf_ingreso_onGrupoAgregado; //asignacion del evento 
            wf_ingreso.ShowDialog();
        }

        

        private void wf_ingreso_onGrupoAgregado(object sender, EventArgs e)
        {

            //llamar a la funcion que llena el combo para completar el evento
            CargarGrupoPruductos(); 
        }

        private void ComboGrupoSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CargarGrupoPruductos()
        {
            string query = @"SELECT * FROM public.ft_view_grupo_productos()";
            PgSqlCommand pg_comando = new PgSqlCommand(query, pro_conexion);

            try
            {
                ds_grupo_productos1.dt_grupo_productos.Clear();
                new PgSqlDataAdapter(pg_comando).Fill(ds_grupo_productos1.dt_grupo_productos); //recomendado para llenar datasets

                

            }
            catch (Exception ex)
            {

               
            }
           
        }

        private void tablaGrupoSeleccionado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
