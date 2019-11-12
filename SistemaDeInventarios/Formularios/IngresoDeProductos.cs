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
            CargarDetalleProductos();




        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vIngresoDeProducto_onIngresoGrupo(object sender, EventArgs e)
        {
            CargarGrupoPruductos();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            IngresoDeProducto v_ingresoDeProducto = new IngresoDeProducto(pro_conexion);
            v_ingresoDeProducto.onIngresoGrupo += v_ingresoDeProducto_onIngresoGrupo;
            v_ingresoDeProducto.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            wf_Ingreso_Grupos wf_ingreso = new wf_Ingreso_Grupos(pro_conexion);
          //  wf_ingreso.onIngresoGrupo += v_ingresoDeProducto_onIngresoGrupo;
            wf_ingreso.ShowDialog();
        }

        private void v_ingresoDeProducto_onIngresoGrupo(object sender, EventArgs e)
        {
            CargarDetalleProductos();
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
                MessageBox.Show(ex.Message);
               
            }
           
        }

        public void CargarDetalleProductos()
        {
            string query = @"SELECT * FROM public.view_nombre_productos_detalle ()";
            PgSqlCommand pg_comando = new PgSqlCommand(query, pro_conexion);
            try
            {
                ds_nombre_producto_detalle.dt_nombre_producto_detalle.Clear();
                new PgSqlDataAdapter(pg_comando).Fill(ds_nombre_producto_detalle.dt_nombre_producto_detalle);

            }
            catch (Exception eex)
            {

              
            }
        }

        private void ComboNombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
