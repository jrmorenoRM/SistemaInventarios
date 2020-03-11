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

    public wf_crear_nuevo_proveedor(PgSqlConnection p_conexion)
        {
            InitializeComponent();
            pro_conexion = p_conexion;
            CargarDetalleProveedores();
        }



        #region FUNCIONES

        private void wf_ingreso_onProveedorAgreg(object sender, EventArgs e)
        {

            //llamar a la funcion que llena el combo para completar el evento personalizado
            CargarDetalleProveedores();
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

        public void LimpiarTextboxs()
        {
            txt_nombre_contacto.Clear();
            txt_correo_electronico.Clear();
            txt_numero_celular.Clear();
            txt_numero_telefono.Clear();
        }

        #endregion

        #region BOTONES

        #region EVENTO Y BOTON MAS
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            wf_insertar_nuevo_proveedor inp = new wf_insertar_nuevo_proveedor(pro_conexion);
            inp.on_ProveedorAgregado += wf_ingreso_onProveedorAgreg; //EVENTO PERSONALIZADO
            inp.ShowDialog();


        }

        #endregion

        #region CERRAR

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        #endregion


        #region GUARDAR

        private void button1_Click(object sender, EventArgs e)
        {
            int v_comboproveedores = (int)comboProveedor.SelectedValue;


            string query = @"SELECT * FROM public.ft_insert_agregar_nuevo_detalle_proveedor (
                                                                                               :p_nombre_contacto,
                                                                                               :p_id_proveedor,
                                                                                               :p_correo_electronico_proveedor,
                                                                                               :p_numero_cel,
                                                                                               :p_numero_tel 
                                                                                             )";

            PgSqlCommand pg_comando = new PgSqlCommand(query, pro_conexion);

            pg_comando.Parameters.Add("p_id_proveedor", PgSqlType.Int).Value = v_comboproveedores;
            pg_comando.Parameters.Add("p_nombre_contacto", PgSqlType.VarChar).Value = txt_nombre_contacto.Text;
            pg_comando.Parameters.Add("p_correo_electronico_proveedor", PgSqlType.VarChar).Value = txt_correo_electronico.Text;
            pg_comando.Parameters.Add("p_numero_cel", PgSqlType.VarChar).Value = txt_numero_celular.Text;
            pg_comando.Parameters.Add("p_numero_tel", PgSqlType.VarChar).Value = txt_numero_telefono.Text;

            try
            {
                pg_comando.ExecuteNonQuery();
                MessageBox.Show("NUEVO PROVEEDOR AGREGADO.");
                LimpiarTextboxs();
                

            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            };
        }


        #endregion



        #endregion

        #region PROPIEDADES
        public PgSqlConnection pro_conexion { get; set; }




        #endregion

    }
}
