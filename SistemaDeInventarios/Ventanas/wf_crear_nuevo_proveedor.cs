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
    public partial class wf_crear_nuevo_proveedor : Form
    {

        public PgSqlConnection pro_conexion { get; set; }

        public wf_crear_nuevo_proveedor(PgSqlConnection p_conexion)
        {
            InitializeComponent();
            pro_conexion = p_conexion;
            CargarDetalleProveedores();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CargarDetalleProveedores()
        {
            string query = @"SELECT * FROM public.ft_view_detalle_proveedores ()";
            PgSqlCommand pg_comando = new PgSqlCommand(query, pro_conexion);

            try
            {
                ds_detalle_proveedores.dt_detalle_producto.Clear();
                new PgSqlDataAdapter(pg_comando).Fill(ds_detalle_proveedores.dt_detalle_producto); //recomendado para llenar datasets



            }
            catch (Exception ex)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wf_insertar_nuevo_proveedor inp = new wf_insertar_nuevo_proveedor(pro_conexion);
            inp.ShowDialog();


        }
    }
}
