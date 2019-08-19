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
        public MenuPrincipal()
        {
            InitializeComponent();

            TIPOS_AMBIENTE v_tipo_ambiente = (TIPOS_AMBIENTE) Convert.ToInt32(ConfigurationSettings.AppSettings["TIPO_AMBIENTE"]);
            switch (v_tipo_ambiente)
            {
                case TIPOS_AMBIENTE.PRUEBA:
                    break;
                case TIPOS_AMBIENTE.PRODUCCION:
                    Form1 frmLogin = new Form1();
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
            IngresoDeProductos vingresoDeProductos = new IngresoDeProductos();
            vingresoDeProductos.MdiParent = this;
            vingresoDeProductos.Show();

        }
    }
}
